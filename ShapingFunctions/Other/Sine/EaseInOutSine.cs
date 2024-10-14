namespace Beryllium.ShapingFunctions;

public class EaseInOutSine : BaseShapingFunction
{
    public override float CalculateOutput(float input)
    {
        return -((float)Math.Cos(Math.PI * input) - 1.0f) / 2.0f;
    }
}
