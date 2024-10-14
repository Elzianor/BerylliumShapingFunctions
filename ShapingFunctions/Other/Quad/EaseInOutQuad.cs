namespace Beryllium.ShapingFunctions;

public class EaseInOutQuad : BaseShapingFunction
{
    public override float CalculateOutput(float input)
    {
        return input < 0.5f ?
            2.0f * input * input :
            1.0f - (float)Math.Pow(-2 * input + 2, 2) / 2.0f;
    }
}
