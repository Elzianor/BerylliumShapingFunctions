namespace Beryllium.ShapingFunctions;

public class EaseOutExpo : BaseShapingFunction
{
    public override float CalculateOutput(float input)
    {
        return input == 1.0f ?
            1.0f :
            1.0f - (float)Math.Pow(2, -10 * input);
    }
}
