namespace Beryllium.ShapingFunctions;

public class EaseOutCirc : BaseShapingFunction
{
    public override float CalculateOutput(float input)
    {
        return (float)Math.Sqrt(1 - Math.Pow(input - 1, 2));
    }
}
