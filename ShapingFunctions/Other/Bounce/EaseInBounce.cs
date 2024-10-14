namespace Beryllium.ShapingFunctions;

public class EaseInBounce : BaseShapingFunction
{
    public override float CalculateOutput(float input)
    {
        return 1.0f - EaseOutBounce.Func(1.0f - input);
    }
}
