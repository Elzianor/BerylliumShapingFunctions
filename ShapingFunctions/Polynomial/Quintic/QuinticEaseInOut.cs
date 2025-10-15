namespace Beryllium.ShapingFunctions;

public class QuinticEaseInOut : QuinticBase
{
    public QuinticEaseInOut()
    {
        Name = "Quintic EaseInOut";
    }

    public override float CalculateOutput(float input)
    {
        return input < 0.5 ?
            16.0f * input * input * input * input * input :
            1.0f - (float)Math.Pow(-2 * input + 2, 5) / 2.0f;
    }
}
