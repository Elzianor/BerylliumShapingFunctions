namespace Beryllium.ShapingFunctions;

public class EaseInOutBounce : BaseShapingFunction
{
    public override float CalculateOutput(float input)
    {
        return input < 0.5f ?
            (1.0f - EaseOutBounce.Func(1.0f - 2.0f * input)) / 2.0f :
            (1.0f + EaseOutBounce.Func(2.0f * input - 1.0f)) / 2.0f;
    }
}
