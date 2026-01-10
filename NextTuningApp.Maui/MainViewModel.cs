using System.ComponentModel;
using System.Runtime.CompilerServices;
using Microsoft.Maui.Controls;
using Microsoft.Maui.Storage;
using NextTuningApp.Core;

namespace NextTuningApp.Maui;

public sealed class MainViewModel : INotifyPropertyChanged
{
    private TuningFile? _tuningFile;
    private bool _isFileLoaded;
    private string _statusMessage = "Open an ISO or SLUS file to begin.";
    private string _fileDisplay = "No file loaded.";

    private double _startYear = 2026;
    private double _playsPerGame = 120;
    private double _autoBids = 12;
    private bool _optOutEnabled = true;
    private double _optOutRating = 80;
    private bool _bowlRankingEnabled = true;
    private bool _speedNerfEnabled;
    private double _speedNerfPercent = 20;
    private double _fatigueJuniorVarsity = 0.5;
    private double _fatigueVarsity = 0.5;
    private double _fatigueAllAmerican = 0.5;
    private double _fatigueHeisman = 0.5;
    private int _userTeamTextR = 255;
    private int _userTeamTextG = 255;
    private int _userTeamTextB = 255;
    private int _matchupTextR = 255;
    private int _matchupTextG = 255;
    private int _matchupTextB = 255;
    private double _kickingSlider = 1.0;
    private bool _polygonPatchEnabled;
    private bool _impactPlayersEnabled = true;

    public MainViewModel()
    {
        OpenFileCommand = new Command(async () => await OpenFileAsync());
        LoadConfigCommand = new Command(async () => await LoadConfigAsync());
        SaveCommand = new Command(async () => await SaveAsync());
    }

    public event PropertyChangedEventHandler? PropertyChanged;

    public Command OpenFileCommand { get; }
    public Command LoadConfigCommand { get; }
    public Command SaveCommand { get; }

    public bool IsFileLoaded
    {
        get => _isFileLoaded;
        private set => SetProperty(ref _isFileLoaded, value);
    }

    public string StatusMessage
    {
        get => _statusMessage;
        private set => SetProperty(ref _statusMessage, value);
    }

    public string FileDisplay
    {
        get => _fileDisplay;
        private set => SetProperty(ref _fileDisplay, value);
    }

    public double StartYear
    {
        get => _startYear;
        set => SetProperty(ref _startYear, value);
    }

    public double PlaysPerGame
    {
        get => _playsPerGame;
        set => SetProperty(ref _playsPerGame, value);
    }

    public double AutoBids
    {
        get => _autoBids;
        set => SetProperty(ref _autoBids, value);
    }

    public bool OptOutEnabled
    {
        get => _optOutEnabled;
        set => SetProperty(ref _optOutEnabled, value);
    }

    public double OptOutRating
    {
        get => _optOutRating;
        set => SetProperty(ref _optOutRating, value);
    }

    public bool BowlRankingEnabled
    {
        get => _bowlRankingEnabled;
        set => SetProperty(ref _bowlRankingEnabled, value);
    }

    public bool SpeedNerfEnabled
    {
        get => _speedNerfEnabled;
        set => SetProperty(ref _speedNerfEnabled, value);
    }

    public double SpeedNerfPercent
    {
        get => _speedNerfPercent;
        set => SetProperty(ref _speedNerfPercent, value);
    }

    public double FatigueJuniorVarsity
    {
        get => _fatigueJuniorVarsity;
        set => SetProperty(ref _fatigueJuniorVarsity, value);
    }

    public double FatigueVarsity
    {
        get => _fatigueVarsity;
        set => SetProperty(ref _fatigueVarsity, value);
    }

    public double FatigueAllAmerican
    {
        get => _fatigueAllAmerican;
        set => SetProperty(ref _fatigueAllAmerican, value);
    }

    public double FatigueHeisman
    {
        get => _fatigueHeisman;
        set => SetProperty(ref _fatigueHeisman, value);
    }

    public int UserTeamTextR
    {
        get => _userTeamTextR;
        set
        {
            if (SetProperty(ref _userTeamTextR, value))
            {
                OnPropertyChanged(nameof(UserTeamPreviewColor));
                OnPropertyChanged(nameof(UserTeamTextColorDisplay));
            }
        }
    }

    public int UserTeamTextG
    {
        get => _userTeamTextG;
        set
        {
            if (SetProperty(ref _userTeamTextG, value))
            {
                OnPropertyChanged(nameof(UserTeamPreviewColor));
                OnPropertyChanged(nameof(UserTeamTextColorDisplay));
            }
        }
    }

    public int UserTeamTextB
    {
        get => _userTeamTextB;
        set
        {
            if (SetProperty(ref _userTeamTextB, value))
            {
                OnPropertyChanged(nameof(UserTeamPreviewColor));
                OnPropertyChanged(nameof(UserTeamTextColorDisplay));
            }
        }
    }

    public int MatchupTextR
    {
        get => _matchupTextR;
        set
        {
            if (SetProperty(ref _matchupTextR, value))
            {
                OnPropertyChanged(nameof(MatchupPreviewColor));
                OnPropertyChanged(nameof(MatchupTextColorDisplay));
            }
        }
    }

    public int MatchupTextG
    {
        get => _matchupTextG;
        set
        {
            if (SetProperty(ref _matchupTextG, value))
            {
                OnPropertyChanged(nameof(MatchupPreviewColor));
                OnPropertyChanged(nameof(MatchupTextColorDisplay));
            }
        }
    }

    public int MatchupTextB
    {
        get => _matchupTextB;
        set
        {
            if (SetProperty(ref _matchupTextB, value))
            {
                OnPropertyChanged(nameof(MatchupPreviewColor));
                OnPropertyChanged(nameof(MatchupTextColorDisplay));
            }
        }
    }

    public double KickingSlider
    {
        get => _kickingSlider;
        set => SetProperty(ref _kickingSlider, value);
    }

    public bool PolygonPatchEnabled
    {
        get => _polygonPatchEnabled;
        set => SetProperty(ref _polygonPatchEnabled, value);
    }

    public bool ImpactPlayersEnabled
    {
        get => _impactPlayersEnabled;
        set => SetProperty(ref _impactPlayersEnabled, value);
    }

    public Color UserTeamPreviewColor => Color.FromRgb(ClampByte(UserTeamTextR), ClampByte(UserTeamTextG), ClampByte(UserTeamTextB));

    public string UserTeamTextColorDisplay => new TuningColor(ClampByte(UserTeamTextR), ClampByte(UserTeamTextG), ClampByte(UserTeamTextB)).ToString();

    public Color MatchupPreviewColor => Color.FromRgb(ClampByte(MatchupTextR), ClampByte(MatchupTextG), ClampByte(MatchupTextB));

    public string MatchupTextColorDisplay => new TuningColor(ClampByte(MatchupTextR), ClampByte(MatchupTextG), ClampByte(MatchupTextB)).ToString();

    private async Task OpenFileAsync()
    {
        FileResult? file = await FilePicker.PickAsync(new PickOptions
        {
            PickerTitle = "Select the NCAA Next ISO or SLUS file"
        });

        if (file == null)
        {
            return;
        }

        string? path = file.FullPath;
        if (string.IsNullOrWhiteSpace(path))
        {
            StatusMessage = "Selected file does not expose a writable path on this platform. Copy the file to local storage and try again.";
            return;
        }

        try
        {
            _tuningFile?.Dispose();
            _tuningFile = TuningFile.Open(path);

            TuningSettings settings = _tuningFile.LoadSettings();
            ApplySettingsToView(settings);

            IsFileLoaded = true;
            FileDisplay = path;
            StatusMessage = $"Loaded file version {_tuningFile.VersionString}.";
        }
        catch (Exception ex)
        {
            IsFileLoaded = false;
            StatusMessage = ex.Message;
        }
    }

    private async Task LoadConfigAsync()
    {
        if (_tuningFile == null)
        {
            return;
        }

        FileResult? file = await FilePicker.PickAsync(new PickOptions
        {
            PickerTitle = "Select a user-config.cfg"
        });

        if (file == null)
        {
            return;
        }

        string? path = file.FullPath;
        if (string.IsNullOrWhiteSpace(path))
        {
            StatusMessage = "Selected configuration does not expose a readable path on this platform.";
            return;
        }

        try
        {
            TuningSettings current = BuildSettingsFromView();
            TuningSettings updated = TuningFile.ReadConfig(path, current);
            ApplySettingsToView(updated);
            StatusMessage = "Configuration file loaded.";
        }
        catch (Exception ex)
        {
            StatusMessage = ex.Message;
        }
    }

    private async Task SaveAsync()
    {
        if (_tuningFile == null)
        {
            return;
        }

        try
        {
            TuningSettings settings = BuildSettingsFromView();
            _tuningFile.ApplySettings(settings);

            string directory = Path.GetDirectoryName(_tuningFile.FilePath) ?? AppContext.BaseDirectory;
            string configPath = Path.Combine(directory, "user-config.cfg");
            TuningFile.WriteConfig(configPath, settings);

            StatusMessage = $"Saved changes and wrote config to {configPath}.";
        }
        catch (Exception ex)
        {
            StatusMessage = ex.Message;
        }

        await Task.CompletedTask;
    }

    private TuningSettings BuildSettingsFromView()
    {
        return new TuningSettings
        {
            StartYear = (ushort)StartYear,
            PlaysPerGame = (byte)PlaysPerGame,
            AutoBids = (byte)AutoBids,
            OptOutEnabled = OptOutEnabled,
            OptOutRating = (byte)OptOutRating,
            BowlRankingEnabled = BowlRankingEnabled,
            SpeedNerfEnabled = SpeedNerfEnabled,
            SpeedNerfPercent = (int)SpeedNerfPercent,
            FatigueJuniorVarsity = (float)FatigueJuniorVarsity,
            FatigueVarsity = (float)FatigueVarsity,
            FatigueAllAmerican = (float)FatigueAllAmerican,
            FatigueHeisman = (float)FatigueHeisman,
            UserTeamTextColor = new TuningColor(ClampByte(UserTeamTextR), ClampByte(UserTeamTextG), ClampByte(UserTeamTextB)),
            MatchupTextColor = new TuningColor(ClampByte(MatchupTextR), ClampByte(MatchupTextG), ClampByte(MatchupTextB)),
            KickingSlider = (float)KickingSlider,
            KickDifficultyIndex = 0,
            PolygonPatchEnabled = PolygonPatchEnabled,
            ImpactPlayersEnabled = ImpactPlayersEnabled
        };
    }

    private void ApplySettingsToView(TuningSettings settings)
    {
        StartYear = settings.StartYear;
        PlaysPerGame = settings.PlaysPerGame;
        AutoBids = settings.AutoBids;
        OptOutEnabled = settings.OptOutEnabled;
        OptOutRating = settings.OptOutRating;
        BowlRankingEnabled = settings.BowlRankingEnabled;
        SpeedNerfEnabled = settings.SpeedNerfEnabled;
        SpeedNerfPercent = settings.SpeedNerfPercent;
        FatigueJuniorVarsity = settings.FatigueJuniorVarsity;
        FatigueVarsity = settings.FatigueVarsity;
        FatigueAllAmerican = settings.FatigueAllAmerican;
        FatigueHeisman = settings.FatigueHeisman;
        UserTeamTextR = settings.UserTeamTextColor.R;
        UserTeamTextG = settings.UserTeamTextColor.G;
        UserTeamTextB = settings.UserTeamTextColor.B;
        MatchupTextR = settings.MatchupTextColor.R;
        MatchupTextG = settings.MatchupTextColor.G;
        MatchupTextB = settings.MatchupTextColor.B;
        KickingSlider = settings.KickingSlider;
        PolygonPatchEnabled = settings.PolygonPatchEnabled;
        ImpactPlayersEnabled = settings.ImpactPlayersEnabled;
    }

    private bool SetProperty<T>(ref T backingStore, T value, [CallerMemberName] string? propertyName = null)
    {
        if (EqualityComparer<T>.Default.Equals(backingStore, value))
        {
            return false;
        }

        backingStore = value;
        OnPropertyChanged(propertyName);
        return true;
    }

    private void OnPropertyChanged([CallerMemberName] string? propertyName = null)
    {
        PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
    }

    private static byte ClampByte(int value) => (byte)Math.Clamp(value, 0, 255);
}
