namespace Beryllium.ShapingFunctions;

public class CircularEaseOut : TranscendentalBase
{
    public CircularEaseOut()
    {
        Name = "Circular EaseOut";
    }

    public override float CalculateOutput(float input)
    {
        return (float)Math.Sqrt(1.0f - (1.0f - input) * (1.0f - input));
    }
}
