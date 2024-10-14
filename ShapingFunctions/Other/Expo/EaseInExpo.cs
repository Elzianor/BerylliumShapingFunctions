namespace Beryllium.ShapingFunctions;

public class EaseInExpo : BaseShapingFunction
{
    public override float CalculateOutput(float input)
    {
        return input == 0.0f ?
            0.0f :
            (float)Math.Pow(2, 10 * input - 10);
    }
}
