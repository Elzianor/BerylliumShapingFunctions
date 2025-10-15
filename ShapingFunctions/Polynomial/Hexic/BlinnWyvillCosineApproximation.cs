namespace Beryllium.ShapingFunctions;

public class BlinnWyvillCosineApproximation : HexicBase
{
    public BlinnWyvillCosineApproximation()
    {
        Name = "Blinn-Wyvill Cosine Approximation";
    }

    public override float CalculateOutput(float input)
    {
        var x2 = input * input;
        var x4 = x2 * x2;
        var x6 = x4 * x2;

        const float fa = 4.0f / 9.0f;
        const float fb = 17.0f / 9.0f;
        const float fc = 22.0f / 9.0f;

        return fa * x6 - fb * x4 + fc * x2;
    }
}
