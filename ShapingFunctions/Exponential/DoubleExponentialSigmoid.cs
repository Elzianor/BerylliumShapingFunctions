namespace Beryllium.ShapingFunctions;

public class DoubleExponentialSigmoid : BaseShapingFunction
{
    private float _a;
    public float A
    {
        get => _a;
        set => _a = Math.Clamp(value, 0.0f, 1.0f);
    }

    public override float CalculateOutput(float input)
    {
        const float epsilon = 0.00001f;
        const float minParamA = 0.0f + epsilon;
        const float maxParamA = 1.0f - epsilon;

        A = Math.Min(maxParamA, Math.Max(minParamA, A));
        A = 1.0f - A; // for sensible results

        return input <= 0.5f ?
            (float)Math.Pow(2.0f * input, 1.0f / A) / 2.0f :
            1.0f - (float)Math.Pow(2.0f * (1.0f - input), 1.0f / A) / 2.0f;
    }
}
