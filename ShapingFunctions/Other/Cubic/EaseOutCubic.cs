namespace Beryllium.ShapingFunctions;

public class EaseOutCubic : BaseShapingFunction
{
    public override float CalculateOutput(float input)
    {
        return 1.0f - (float)Math.Pow(1 - input, 3);
    }
}
