namespace Beryllium.ShapingFunctions;

public class ExponentialEaseIn : TranscendentalBase
{
    public ExponentialEaseIn()
    {
        Name = "Exponential EaseIn";
    }

    public override float CalculateOutput(float input)
    {
        return BMath.IsEqual(input, 0.0f) ?
            0.0f :
            (float)Math.Pow(2, 10 * input - 10);
    }
}
