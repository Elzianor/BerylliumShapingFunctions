namespace Beryllium.ShapingFunctions;

public class QuinticEaseIn : QuinticBase
{
    public QuinticEaseIn()
    {
        Name = "Quintic EaseIn";
    }

    public override float CalculateOutput(float input)
    {
        return input * input * input * input * input;
    }
}
