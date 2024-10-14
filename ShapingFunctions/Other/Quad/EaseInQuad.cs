namespace Beryllium.ShapingFunctions;

public class EaseInQuad : BaseShapingFunction
{
    public override float CalculateOutput(float input)
    {
        return input * input;
    }
}
