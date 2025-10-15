namespace Beryllium.ShapingFunctions;

public class QuadraticEaseOut : QuadraticBase
{
    public QuadraticEaseOut()
    {
        Name = "Quadratic EaseOut";
    }

    public override float CalculateOutput(float input)
    {
        return 1.0f - (1.0f - input) * (1.0f - input);
    }
}
