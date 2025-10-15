namespace Beryllium.ShapingFunctions;

public class QuarticEaseIn : QuarticBase
{
    public QuarticEaseIn()
    {
        Name = "Quartic EaseIn";
    }

    public override float CalculateOutput(float input)
    {
        return input * input * input * input;
    }
}
