namespace Beryllium.ShapingFunctions;
using BMath = Beryllium.Mathematics.Mathematics;

public class EaseOutExpo : BaseShapingFunction
{
    public override float CalculateOutput(float input)
    {
        return BMath.IsEqual(input, 1.0f) ?
            1.0f :
            1.0f - (float)Math.Pow(2, -10 * input);
    }
}
