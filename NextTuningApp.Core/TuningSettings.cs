namespace NextTuningApp.Core;

public sealed class TuningSettings
{
    public ushort StartYear { get; set; }
    public byte PlaysPerGame { get; set; }
    public byte AutoBids { get; set; }
    public bool OptOutEnabled { get; set; }
    public byte OptOutRating { get; set; }
    public bool BowlRankingEnabled { get; set; }
    public bool SpeedNerfEnabled { get; set; }
    public int SpeedNerfPercent { get; set; }
    public float FatigueJuniorVarsity { get; set; }
    public float FatigueVarsity { get; set; }
    public float FatigueAllAmerican { get; set; }
    public float FatigueHeisman { get; set; }
    public TuningColor UserTeamTextColor { get; set; }
    public TuningColor MatchupTextColor { get; set; }
    public float KickingSlider { get; set; }
    public int KickDifficultyIndex { get; set; }
    public bool PolygonPatchEnabled { get; set; }
    public bool ImpactPlayersEnabled { get; set; }
}
