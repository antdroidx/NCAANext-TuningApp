namespace NextTuningApp.Core;

public readonly record struct TuningColor(byte R, byte G, byte B)
{
    public override string ToString() => $"RGB: {R},{G},{B} (R:{R:X2} G:{G:X2} B:{B:X2})";
}
