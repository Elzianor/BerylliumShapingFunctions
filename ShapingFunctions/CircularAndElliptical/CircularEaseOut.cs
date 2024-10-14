namespace Beryllium.ShapingFunctions;

public class CircularEaseOut : BaseShapingFunction
{
    public override float CalculateOutput(float input)
    {
        return (float)Math.Sqrt(1.0f - (1.0f - input) * (1.0f - input));
    }
}
