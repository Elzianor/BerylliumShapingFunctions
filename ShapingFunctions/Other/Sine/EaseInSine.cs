namespace Beryllium.ShapingFunctions;

public class EaseInSine : BaseShapingFunction
{
    public override float CalculateOutput(float input)
    {
        return 1.0f - (float)Math.Cos(input * Math.PI / 2);
    }
}
