namespace Beryllium.ShapingFunctions;

public class CubicEaseIn : CubicBase
{
    public CubicEaseIn()
    {
        Name = "Cubic EaseIn";
    }

    public override float CalculateOutput(float input)
    {
        return input * input * input;
    }
}
