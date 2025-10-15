namespace Beryllium.ShapingFunctions;

public class QuadraticEaseIn : QuadraticBase
{
    public QuadraticEaseIn()
    {
        Name = "Quadratic EaseIn";
    }

    public override float CalculateOutput(float input)
    {
        return input * input;
    }
}
