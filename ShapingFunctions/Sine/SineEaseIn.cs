namespace Beryllium.ShapingFunctions;

public class SineEaseIn : TranscendentalBase
{
    public SineEaseIn()
    {
        Name = "Sine EaseIn";
    }

    public override float CalculateOutput(float input)
    {
        return 1.0f - (float)Math.Cos(input * Math.PI / 2);
    }
}
