namespace Beryllium.ShapingFunctions;

public class QuarticEaseOut : QuarticBase
{
    public QuarticEaseOut()
    {
        Name = "Quartic EaseOut";
    }

    public override float CalculateOutput(float input)
    {
        return 1.0f - (float)Math.Pow(1 - input, 4);
    }
}
