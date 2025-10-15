namespace Beryllium.ShapingFunctions;

public class SineEaseInOut : TranscendentalBase
{
    public SineEaseInOut()
    {
        Name = "Sine EaseInOut";
    }

    public override float CalculateOutput(float input)
    {
        return -((float)Math.Cos(Math.PI * input) - 1.0f) / 2.0f;
    }
}
