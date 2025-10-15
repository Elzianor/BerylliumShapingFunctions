namespace Beryllium.ShapingFunctions;

public class BounceEaseInOut : QuadraticBase
{
    public BounceEaseInOut()
    {
        Name = "Bounce EaseInOut";
    }

    public override float CalculateOutput(float input)
    {
        return input < 0.5f ?
            (1.0f - BounceEaseOut.Func(1.0f - 2.0f * input)) / 2.0f :
            (1.0f + BounceEaseOut.Func(2.0f * input - 1.0f)) / 2.0f;
    }
}
