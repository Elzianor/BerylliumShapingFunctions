namespace Beryllium.ShapingFunctions;

public class EaseOutQuart : BaseShapingFunction
{
    public override float CalculateOutput(float input)
    {
        return 1.0f - (float)Math.Pow(1 - input, 4);
    }
}
