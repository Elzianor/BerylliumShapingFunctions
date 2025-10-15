namespace Beryllium.ShapingFunctions;

public class QuinticEaseOut : QuinticBase
{
    public QuinticEaseOut()
    {
        Name = "Quintic EaseOut";
    }

    public override float CalculateOutput(float input)
    {
        return 1.0f - (float)Math.Pow(1 - input, 5);
    }
}
