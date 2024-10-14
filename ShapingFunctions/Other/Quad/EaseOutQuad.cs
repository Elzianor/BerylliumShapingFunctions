namespace Beryllium.ShapingFunctions;

public class EaseOutQuad : BaseShapingFunction
{
    public override float CalculateOutput(float input)
    {
        return 1.0f - (1.0f - input) * (1.0f - input);
    }
}
