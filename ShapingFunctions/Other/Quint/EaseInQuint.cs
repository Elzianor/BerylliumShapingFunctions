namespace Beryllium.ShapingFunctions;

public class EaseInQuint : BaseShapingFunction
{
    public override float CalculateOutput(float input)
    {
        return input * input * input * input * input;
    }
}
