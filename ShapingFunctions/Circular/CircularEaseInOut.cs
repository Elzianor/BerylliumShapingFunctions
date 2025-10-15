namespace Beryllium.ShapingFunctions;

public class CircularEaseInOut : TranscendentalBase
{
    public CircularEaseInOut()
    {
        Name = "Circular EaseInOut";
    }

    public override float CalculateOutput(float input)
    {
        return input < 0.5 ?
            (1.0f - (float)Math.Sqrt(1 - Math.Pow(2 * input, 2))) / 2.0f :
            ((float)Math.Sqrt(1 - Math.Pow(-2 * input + 2, 2)) + 1.0f) / 2.0f;
    }
}
