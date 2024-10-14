namespace Beryllium.ShapingFunctions;

public class EaseInCubic : BaseShapingFunction
{
    public override float CalculateOutput(float input)
    {
        return input * input * input;
    }
}
