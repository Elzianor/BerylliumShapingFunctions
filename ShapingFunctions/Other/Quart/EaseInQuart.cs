namespace Beryllium.ShapingFunctions;

public class EaseInQuart : BaseShapingFunction
{
    public override float CalculateOutput(float input)
    {
        return input * input * input * input;
    }
}
