namespace Beryllium.ShapingFunctions;
using BMath = Beryllium.Mathematics.Mathematics;

public class EaseInOutExpo : BaseShapingFunction
{
    public override float CalculateOutput(float input)
    {
        return BMath.IsEqual(input, 0.0f) ?
            0.0f :
            BMath.IsEqual(input, 1.0f) ?
                1.0f :
                input < 0.5f ?
                    (float)Math.Pow(2, 20 * input - 10) / 2.0f :
                    (float)(2 - Math.Pow(2, -20 * input + 10)) / 2.0f;
    }
}
