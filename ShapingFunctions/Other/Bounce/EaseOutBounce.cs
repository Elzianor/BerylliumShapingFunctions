namespace Beryllium.ShapingFunctions;

public class EaseOutBounce : BaseShapingFunction
{
    internal static float Func(float input)
    {
        const float n1 = 7.5625f;
        const float d1 = 2.75f;

        return input switch
        {
            < 1.0f / d1 => n1 * input * input,
            < 2.0f / d1 => n1 * (input -= 1.5f / d1) * input + 0.75f,
            < 2.5f / d1 => n1 * (input -= 2.25f / d1) * input + 0.9375f,
            _ => n1 * (input -= 2.625f / d1) * input + 0.984375f
        };
    }

    public override float CalculateOutput(float input)
    {
        return Func(input);
    }
}
