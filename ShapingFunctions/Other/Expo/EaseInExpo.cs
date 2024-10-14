namespace Beryllium.ShapingFunctions;
using BMath = Beryllium.Mathematics.Mathematics;

public class EaseInExpo : BaseShapingFunction
{
    public override float CalculateOutput(float input)
    {
        return BMath.IsEqual(input, 0.0f) ?
            0.0f :
            (float)Math.Pow(2, 10 * input - 10);
    }
}
