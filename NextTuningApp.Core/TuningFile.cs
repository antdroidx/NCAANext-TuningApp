using System.Globalization;

namespace NextTuningApp.Core;

public sealed class TuningFile : IDisposable
{
    private const double MinimumSupportedVersion = 16.4;
    private readonly FileStream _stream;
    private readonly long _originBase;

    private TuningFile(string path, FileStream stream, long originBase, string version)
    {
        FilePath = path;
        _stream = stream;
        _originBase = originBase;
        VersionString = version;
    }

    public string FilePath { get; }
    public string VersionString { get; }

    public static TuningFile Open(string filePath)
    {
        if (!File.Exists(filePath))
        {
            throw new FileNotFoundException("File not found.", filePath);
        }

        FileStream stream = new(filePath, FileMode.Open, FileAccess.ReadWrite, FileShare.Read);
        if (!SignatureScanner.TryFind(stream, TuningOffsets.SlusSignature, out long originBase))
        {
            stream.Dispose();
            throw new InvalidDataException("SLUS ELF header not found in the selected file.");
        }

        string version = ReadVersion(stream, originBase);
        if (double.TryParse(version, NumberStyles.Float, CultureInfo.InvariantCulture, out double parsedVersion)
            && parsedVersion < MinimumSupportedVersion)
        {
            stream.Dispose();
            throw new InvalidDataException($"This app only works with version {MinimumSupportedVersion} or higher. Loaded version: {version}.");
        }

        return new TuningFile(filePath, stream, originBase, version);
    }

    public TuningSettings LoadSettings()
    {
        ushort year = ReadUInt16LE(_originBase + TuningOffsets.StartYearOffsets[0]);
        byte plays = ReadByte(_originBase + TuningOffsets.PlaysPerGameOffset);
        byte autoBids = ReadByte(_originBase + TuningOffsets.AutoBidOffset);

        byte optoutYear = ReadByte(_originBase + TuningOffsets.OptOutYearOffset);
        byte optoutRating = ReadByte(_originBase + TuningOffsets.OptOutRatingOffset);
        bool optOutEnabled = optoutYear <= 3;
        byte optOutRatingAdjusted = optOutEnabled ? (byte)(optoutRating + 40) : (byte)80;

        byte bowlRank = ReadByte(_originBase + TuningOffsets.BowlRankingSkipOffset);
        bool bowlRankingEnabled = bowlRank == 0x00;

        bool speedNerfEnabled = ReadBytes(_originBase + TuningOffsets.SpeedNerfOffset1, TuningOffsets.SpeedNerfUpdate1.Length)
            .SequenceEqual(TuningOffsets.SpeedNerfUpdate1);

        int speedNerfPercent = 0;
        if (speedNerfEnabled)
        {
            sbyte speedAmt = ReadSByte(_originBase + TuningOffsets.SpeedNerfAmtOffset);
            speedNerfPercent = (int)Math.Round(speedAmt / 255.0 * 100.0, 0, MidpointRounding.AwayFromZero);
        }

        float fatigueJv = ReadFloatHighWordOnly(_originBase + TuningOffsets.FatigueJVOffset);
        float fatigueVarsity = ReadFloatWordSwapped(_originBase + TuningOffsets.FatigueVarsityOffset);
        float fatigueAa = ReadFloatWordSwapped(_originBase + TuningOffsets.FatigueAAOffset);
        float fatigueHeisman = ReadFloatWordSwapped(_originBase + TuningOffsets.FatigueHeismanOffset);

        TuningColor teamColor = new(
            ReadByte(_originBase + TuningOffsets.UserTeamTextR_Offset),
            ReadByte(_originBase + TuningOffsets.UserTeamTextG_Offset),
            ReadByte(_originBase + TuningOffsets.UserTeamTextB_Offset));

        TuningColor matchupColor = new(
            ReadByte(_originBase + TuningOffsets.MatchUpTextR_Offset),
            ReadByte(_originBase + TuningOffsets.MatchUpTextG_Offset),
            ReadByte(_originBase + TuningOffsets.MatchUpTextB_Offset));

        float kickingSlider = ReadFloatHighWordOnly(_originBase + TuningOffsets.KickingSliderOffset);

        bool polygonEnabled = ReadBytes(_originBase + TuningOffsets.PolygonOffset1, TuningOffsets.PolygonUpdate1.Length)
            .SequenceEqual(TuningOffsets.PolygonUpdate1);

        byte impact = ReadByte(_originBase + TuningOffsets.ImpactPlayerOffset);
        bool impactEnabled = impact != TuningOffsets.ImpactPlayersUpdate;

        return new TuningSettings
        {
            StartYear = year,
            PlaysPerGame = plays,
            AutoBids = autoBids,
            OptOutEnabled = optOutEnabled,
            OptOutRating = optOutRatingAdjusted,
            BowlRankingEnabled = bowlRankingEnabled,
            SpeedNerfEnabled = speedNerfEnabled,
            SpeedNerfPercent = speedNerfPercent,
            FatigueJuniorVarsity = fatigueJv,
            FatigueVarsity = fatigueVarsity,
            FatigueAllAmerican = fatigueAa,
            FatigueHeisman = fatigueHeisman,
            UserTeamTextColor = teamColor,
            MatchupTextColor = matchupColor,
            KickingSlider = kickingSlider,
            PolygonPatchEnabled = polygonEnabled,
            ImpactPlayersEnabled = impactEnabled,
            KickDifficultyIndex = 0
        };
    }

    public void ApplySettings(TuningSettings settings)
    {
        ushort startYear = settings.StartYear;
        ushort startYearPlus1 = (ushort)(startYear + 1);
        foreach (int off in TuningOffsets.StartYearOffsets)
        {
            WriteUInt16LE(_originBase + off, startYear);
        }

        foreach (int off in TuningOffsets.StartYearPlus1Offsets)
        {
            WriteUInt16LE(_originBase + off, startYearPlus1);
        }

        WriteByte(_originBase + TuningOffsets.PlaysPerGameOffset, settings.PlaysPerGame);
        WriteByte(_originBase + TuningOffsets.AutoBidOffset, settings.AutoBids);

        if (settings.OptOutEnabled)
        {
            WriteByte(_originBase + TuningOffsets.OptOutYearOffset, 3);
            int rating = Math.Clamp(settings.OptOutRating - 40, 0, 255);
            WriteByte(_originBase + TuningOffsets.OptOutRatingOffset, (byte)rating);
        }
        else
        {
            WriteByte(_originBase + TuningOffsets.OptOutYearOffset, 5);
            WriteByte(_originBase + TuningOffsets.OptOutRatingOffset, 0x28);
        }

        if (settings.BowlRankingEnabled)
        {
            WriteByteArray(_originBase + TuningOffsets.BowlRankingSkipOffset, TuningOffsets.BowlRankingSkipUpdate);
        }
        else
        {
            WriteByteArray(_originBase + TuningOffsets.BowlRankingSkipOffset, TuningOffsets.BowlRankingSkipRevert);
        }

        if (settings.SpeedNerfEnabled)
        {
            WriteByteArray(_originBase + TuningOffsets.SpeedNerfOffset1, TuningOffsets.SpeedNerfUpdate1);
            WriteByteArray(_originBase + TuningOffsets.SpeedNerfOffset2, TuningOffsets.SpeedNerfUpdate2);

            int speedAmt = Math.Clamp(settings.SpeedNerfPercent, -100, 100) * 255 / 100;
            sbyte speedAmtByte = unchecked((sbyte)speedAmt);
            WriteSByte(_originBase + TuningOffsets.SpeedNerfAmtOffset, speedAmtByte);
        }
        else
        {
            WriteByteArray(_originBase + TuningOffsets.SpeedNerfOffset1, TuningOffsets.SpeedNerfRevert1);
            WriteByteArray(_originBase + TuningOffsets.SpeedNerfOffset2, TuningOffsets.SpeedNerfRevert2);
        }

        WriteFloatHighWordOnly(_originBase + TuningOffsets.FatigueJVOffset, settings.FatigueJuniorVarsity);
        WriteFloatWordSwapped(_originBase + TuningOffsets.FatigueVarsityOffset, settings.FatigueVarsity);
        WriteFloatWordSwapped(_originBase + TuningOffsets.FatigueAAOffset, settings.FatigueAllAmerican);
        WriteFloatWordSwapped(_originBase + TuningOffsets.FatigueHeismanOffset, settings.FatigueHeisman);

        WriteByte(_originBase + TuningOffsets.UserTeamTextR_Offset, settings.UserTeamTextColor.R);
        WriteByte(_originBase + TuningOffsets.UserTeamTextG_Offset, settings.UserTeamTextColor.G);
        WriteByte(_originBase + TuningOffsets.UserTeamTextB_Offset, settings.UserTeamTextColor.B);

        WriteByte(_originBase + TuningOffsets.MatchUpTextR_Offset, settings.MatchupTextColor.R);
        WriteByte(_originBase + TuningOffsets.MatchUpTextG_Offset, settings.MatchupTextColor.G);
        WriteByte(_originBase + TuningOffsets.MatchUpTextB_Offset, settings.MatchupTextColor.B);

        WriteFloatHighWordOnly(_originBase + TuningOffsets.KickingSliderOffset, settings.KickingSlider);

        if (settings.PolygonPatchEnabled)
        {
            WriteByteArray(_originBase + TuningOffsets.PolygonOffset1, TuningOffsets.PolygonUpdate1);
            WriteByteArray(_originBase + TuningOffsets.PolygonOffset2, TuningOffsets.PolygonUpdate2);
        }
        else
        {
            WriteByteArray(_originBase + TuningOffsets.PolygonOffset1, TuningOffsets.PolygonRevert1);
            WriteByteArray(_originBase + TuningOffsets.PolygonOffset2, TuningOffsets.PolygonRevert2);
        }

        WriteByte(_originBase + TuningOffsets.ImpactPlayerOffset,
            settings.ImpactPlayersEnabled ? TuningOffsets.ImpactPlayersRevert : TuningOffsets.ImpactPlayersUpdate);

        _stream.Flush();
    }

    public static TuningSettings ReadConfig(string configPath, TuningSettings baseSettings)
    {
        if (!File.Exists(configPath))
        {
            throw new FileNotFoundException("Configuration file not found.", configPath);
        }

        string[] lines = File.ReadAllLines(configPath);
        if (lines.Length == 0 || !lines[0].StartsWith("User Configuration", StringComparison.OrdinalIgnoreCase))
        {
            throw new InvalidDataException("This is not a configuration file.");
        }

        List<decimal> config = new();
        for (int i = 0; i < lines.Length; i++)
        {
            if (string.IsNullOrWhiteSpace(lines[i]))
            {
                continue;
            }

            string[] parts = lines[i].Split(':');
            if (parts.Length == 2 && decimal.TryParse(parts[1], NumberStyles.Number, CultureInfo.InvariantCulture, out decimal value))
            {
                config.Add(value);
            }
        }

        TuningSettings updated = new()
        {
            StartYear = baseSettings.StartYear,
            PlaysPerGame = baseSettings.PlaysPerGame,
            AutoBids = baseSettings.AutoBids,
            OptOutEnabled = baseSettings.OptOutEnabled,
            OptOutRating = baseSettings.OptOutRating,
            BowlRankingEnabled = baseSettings.BowlRankingEnabled,
            SpeedNerfEnabled = baseSettings.SpeedNerfEnabled,
            SpeedNerfPercent = baseSettings.SpeedNerfPercent,
            FatigueJuniorVarsity = baseSettings.FatigueJuniorVarsity,
            FatigueVarsity = baseSettings.FatigueVarsity,
            FatigueAllAmerican = baseSettings.FatigueAllAmerican,
            FatigueHeisman = baseSettings.FatigueHeisman,
            UserTeamTextColor = baseSettings.UserTeamTextColor,
            MatchupTextColor = baseSettings.MatchupTextColor,
            KickingSlider = baseSettings.KickingSlider,
            KickDifficultyIndex = baseSettings.KickDifficultyIndex,
            PolygonPatchEnabled = baseSettings.PolygonPatchEnabled,
            ImpactPlayersEnabled = baseSettings.ImpactPlayersEnabled
        };

        for (int i = 0; i < config.Count; i++)
        {
            switch (i)
            {
                case 0:
                    updated.StartYear = (ushort)config[0];
                    break;
                case 1:
                    updated.PlaysPerGame = (byte)config[1];
                    break;
                case 2:
                    updated.AutoBids = (byte)config[2];
                    break;
                case 3:
                    updated.OptOutEnabled = config[3] != 0;
                    break;
                case 4:
                    updated.OptOutRating = (byte)config[4];
                    break;
                case 5:
                    updated.BowlRankingEnabled = config[5] != 0;
                    break;
                case 6:
                    updated.SpeedNerfEnabled = config[6] != 0;
                    break;
                case 7:
                    updated.SpeedNerfPercent = (int)config[7];
                    break;
                case 8:
                    updated.FatigueJuniorVarsity = (float)config[8];
                    break;
                case 9:
                    updated.FatigueVarsity = (float)config[9];
                    break;
                case 10:
                    updated.FatigueAllAmerican = (float)config[10];
                    break;
                case 11:
                    updated.FatigueHeisman = (float)config[11];
                    break;
                case 12:
                    updated.UserTeamTextColor = updated.UserTeamTextColor with { R = (byte)config[12] };
                    break;
                case 13:
                    updated.UserTeamTextColor = updated.UserTeamTextColor with { G = (byte)config[13] };
                    break;
                case 14:
                    updated.UserTeamTextColor = updated.UserTeamTextColor with { B = (byte)config[14] };
                    break;
                case 15:
                    updated.MatchupTextColor = updated.MatchupTextColor with { R = (byte)config[15] };
                    break;
                case 16:
                    updated.MatchupTextColor = updated.MatchupTextColor with { G = (byte)config[16] };
                    break;
                case 17:
                    updated.MatchupTextColor = updated.MatchupTextColor with { B = (byte)config[17] };
                    break;
                case 18:
                    updated.KickDifficultyIndex = (int)config[18];
                    break;
                case 19:
                    updated.KickingSlider = (float)config[19];
                    break;
                case 20:
                    updated.PolygonPatchEnabled = config[20] != 0;
                    break;
                case 21:
                    updated.ImpactPlayersEnabled = config[21] != 0;
                    break;
            }
        }

        return updated;
    }

    public static void WriteConfig(string configPath, TuningSettings settings)
    {
        using StreamWriter writer = new(configPath);
        writer.WriteLine("User Configuration");
        writer.WriteLine(string.Empty);
        writer.WriteLine($"Start Year:{settings.StartYear}");
        writer.WriteLine($"Sim Plays:{settings.PlaysPerGame}");
        writer.WriteLine($"AutoBids:{settings.AutoBids}");
        writer.WriteLine($"Opt Out:{(settings.OptOutEnabled ? 1 : 0)}");
        writer.WriteLine($"Opt Out Rating:{settings.OptOutRating}");
        writer.WriteLine($"Bowl Ranking:{(settings.BowlRankingEnabled ? 1 : 0)}");
        writer.WriteLine($"Speed Nerf:{(settings.SpeedNerfEnabled ? 1 : 0)}");
        writer.WriteLine($"Speed Nerf Amount:{settings.SpeedNerfPercent}");
        writer.WriteLine($"Fatigue JV:{settings.FatigueJuniorVarsity}");
        writer.WriteLine($"Fatigue Varsity:{settings.FatigueVarsity}");
        writer.WriteLine($"Fatigue All-American:{settings.FatigueAllAmerican}");
        writer.WriteLine($"Fatigue Heisman:{settings.FatigueHeisman}");
        writer.WriteLine($"UserTeam Text Color R:{settings.UserTeamTextColor.R}");
        writer.WriteLine($"UserTeam Text Color G:{settings.UserTeamTextColor.G}");
        writer.WriteLine($"UserTeam Text Color B:{settings.UserTeamTextColor.B}");
        writer.WriteLine($"MatchUp Text Color R:{settings.MatchupTextColor.R}");
        writer.WriteLine($"MatchUp Text Color G:{settings.MatchupTextColor.G}");
        writer.WriteLine($"MatchUp Text Color B:{settings.MatchupTextColor.B}");
        writer.WriteLine($"User Difficulty:{settings.KickDifficultyIndex}");
        writer.WriteLine($"Kicking Slider:{settings.KickingSlider}");
        writer.WriteLine($"Polygon Patch:{(settings.PolygonPatchEnabled ? 1 : 0)}");
        writer.WriteLine($"Impact Players:{(settings.ImpactPlayersEnabled ? 1 : 0)}");
    }

    public void Dispose()
    {
        _stream.Dispose();
    }

    private static string ReadVersion(FileStream stream, long originBase)
    {
        stream.Position = originBase + TuningOffsets.VersionNum;
        char[] chars = new char[4];
        for (int i = 0; i < chars.Length; i++)
        {
            int value = stream.ReadByte();
            if (value < 0)
            {
                break;
            }

            chars[i] = Convert.ToChar(value);
        }

        return new string(chars).Trim();
    }

    private byte ReadByte(long offset)
    {
        _stream.Position = offset;
        int value = _stream.ReadByte();
        if (value < 0)
        {
            throw new EndOfStreamException("Unexpected EOF reading byte.");
        }

        return (byte)value;
    }

    private sbyte ReadSByte(long offset)
    {
        _stream.Position = offset;
        int value = _stream.ReadByte();
        if (value < 0)
        {
            throw new EndOfStreamException("Unexpected EOF reading sbyte.");
        }

        return unchecked((sbyte)value);
    }

    private ushort ReadUInt16LE(long offset)
    {
        _stream.Position = offset;
        int b0 = _stream.ReadByte();
        int b1 = _stream.ReadByte();
        if (b0 < 0 || b1 < 0)
        {
            throw new EndOfStreamException("Unexpected EOF reading UInt16.");
        }

        return (ushort)(b0 | (b1 << 8));
    }

    private float ReadFloatWordSwapped(long offset)
    {
        ushort hi = ReadUInt16LE(offset);
        ushort lo = ReadUInt16LE(offset + 4);
        uint bits = ((uint)hi << 16) | lo;
        return BitConverter.Int32BitsToSingle((int)bits);
    }

    private float ReadFloatHighWordOnly(long offset)
    {
        ushort hi = ReadUInt16LE(offset);
        uint bits = ((uint)hi << 16);
        return BitConverter.Int32BitsToSingle((int)bits);
    }

    private byte[] ReadBytes(long offset, int length)
    {
        byte[] buffer = new byte[length];
        _stream.Position = offset;
        int read = _stream.Read(buffer, 0, length);
        if (read != length)
        {
            throw new EndOfStreamException("Unexpected EOF reading bytes.");
        }

        return buffer;
    }

    private void WriteByte(long offset, byte value)
    {
        _stream.Position = offset;
        _stream.WriteByte(value);
    }

    private void WriteSByte(long offset, sbyte value)
    {
        _stream.Position = offset;
        _stream.WriteByte(unchecked((byte)value));
    }

    private void WriteUInt16LE(long offset, ushort value)
    {
        _stream.Position = offset;
        _stream.WriteByte((byte)(value & 0xFF));
        _stream.WriteByte((byte)((value >> 8) & 0xFF));
    }

    private void WriteFloatWordSwapped(long offset, float value)
    {
        uint bits = (uint)BitConverter.SingleToInt32Bits(value);
        ushort hi = (ushort)(bits >> 16);
        ushort lo = (ushort)(bits & 0xFFFF);
        WriteUInt16LE(offset, hi);
        WriteUInt16LE(offset + 4, lo);
    }

    private void WriteFloatHighWordOnly(long offset, float value)
    {
        uint bits = (uint)BitConverter.SingleToInt32Bits(value);
        ushort hi = (ushort)(bits >> 16);
        WriteUInt16LE(offset, hi);
    }

    private void WriteByteArray(long offset, byte[] bytes)
    {
        _stream.Position = offset;
        _stream.Write(bytes, 0, bytes.Length);
    }
}
