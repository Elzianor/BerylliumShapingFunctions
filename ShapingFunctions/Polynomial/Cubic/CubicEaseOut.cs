namespace Beryllium.ShapingFunctions;

public class CubicEaseOut : CubicBase
{
    public CubicEaseOut()
    {
        Name = "Cubic EaseOut";
    }

    public override float CalculateOutput(float input)
    {
        return 1.0f - (float)Math.Pow(1 - input, 3);
    }
}
