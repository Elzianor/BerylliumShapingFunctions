namespace Beryllium.ShapingFunctions;

public class QuarticEaseInOut : QuarticBase
{
    public QuarticEaseInOut()
    {
        Name = "Quartic EaseInOut";
    }

    public override float CalculateOutput(float input)
    {
        return input < 0.5f ?
            8.0f * input * input * input * input :
            1.0f - (float)Math.Pow(-2 * input + 2, 4) / 2.0f;
    }
}
