namespace Beryllium.ShapingFunctions;

public class EaseOutElastic : BaseShapingFunction
{
    public override float CalculateOutput(float input)
    {
        const float c4 = (float)(2.0f * Math.PI) / 3.0f;

        return input == 0.0f ?
            0.0f :
            input == 1.0f ?
                1.0f :
                (float)(Math.Pow(2, -10 * input) * Math.Sin((input * 10 - 0.75) * c4) + 1.0f);
    }
}
