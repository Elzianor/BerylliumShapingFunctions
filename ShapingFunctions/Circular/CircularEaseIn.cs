namespace Beryllium.ShapingFunctions;

public class CircularEaseIn : TranscendentalBase
{
    public CircularEaseIn()
    {
        Name = "Circular EaseIn";
    }

    public override float CalculateOutput(float input)
    {
        return 1.0f - (float)Math.Sqrt(1.0f - input * input);
    }
}
