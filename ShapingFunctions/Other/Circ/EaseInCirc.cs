namespace Beryllium.ShapingFunctions;

public class EaseInCirc : BaseShapingFunction
{
    public override float CalculateOutput(float input)
    {
        return 1.0f - (float)Math.Sqrt(1 - Math.Pow(input, 2));
    }
}
