namespace Beryllium.ShapingFunctions;

public class CircularEaseIn : BaseShapingFunction
{
    public override float CalculateOutput(float input)
    {
        return 1.0f - (float)Math.Sqrt(1.0f - input * input);
    }
}
