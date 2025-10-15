namespace Beryllium.ShapingFunctions;

public class BounceEaseIn : QuadraticBase
{
    public BounceEaseIn()
    {
        Name = "Bounce EaseIn";
    }

    public override float CalculateOutput(float input)
    {
        return 1.0f - BounceEaseOut.Func(1.0f - input);
    }
}
