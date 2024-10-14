namespace Beryllium.ShapingFunctions;

public class EaseOutBack : BaseShapingFunction
{
    public override float CalculateOutput(float input)
    {
        const float c1 = 1.70158f;
        const float c3 = c1 + 1.0f;

        return 1.0f + c3 * (float)Math.Pow(input - 1, 3) + c1 * (float)Math.Pow(input - 1, 2);
    }
}
