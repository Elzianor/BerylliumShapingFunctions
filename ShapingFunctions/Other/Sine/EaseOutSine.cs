namespace Beryllium.ShapingFunctions;

public class EaseOutSine : BaseShapingFunction
{
    public override float CalculateOutput(float input)
    {
        return (float)Math.Sin(input * Math.PI / 2);
    }
}
