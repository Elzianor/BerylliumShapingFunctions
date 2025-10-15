namespace Beryllium.ShapingFunctions;

public class BackEaseInOut : CubicBase
{
    public BackEaseInOut()
    {
        Name = "Back EaseInOut";
    }

    public override float CalculateOutput(float input)
    {
        const float c1 = 1.70158f;
        const float c2 = c1 * 1.525f;

        return input < 0.5f ?
            (float)(Math.Pow(2 * input, 2) * ((c2 + 1) * 2 * input - c2)) / 2.0f :
            (float)(Math.Pow(2 * input - 2, 2) * ((c2 + 1) * (input * 2 - 2) + c2) + 2) / 2.0f;
    }
}
