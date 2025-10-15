namespace Beryllium.ShapingFunctions;

public class SineEaseOut : TranscendentalBase
{
    public SineEaseOut()
    {
        Name = "Sine EaseOut";
    }

    public override float CalculateOutput(float input)
    {
        return (float)Math.Sin(input * Math.PI / 2);
    }
}
