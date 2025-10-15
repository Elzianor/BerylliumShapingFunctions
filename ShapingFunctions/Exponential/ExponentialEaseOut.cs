namespace Beryllium.ShapingFunctions;

public class ExponentialEaseOut : TranscendentalBase
{
    public ExponentialEaseOut()
    {
        Name = "Exponential EaseOut";
    }

    public override float CalculateOutput(float input)
    {
        return BMath.IsEqual(input, 1.0f) ?
            1.0f :
            1.0f - (float)Math.Pow(2, -10 * input);
    }
}
