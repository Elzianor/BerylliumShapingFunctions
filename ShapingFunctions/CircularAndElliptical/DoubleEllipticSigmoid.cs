namespace Beryllium.ShapingFunctions;

public class DoubleEllipticSigmoid : BaseShapingFunction
{
    private float _a;
    public float A
    {
        get => _a;
        set => _a = Math.Clamp(value, 0.0f, 1.0f);
    }

    private float _b;
    public float B
    {
        get => _b;
        set => _b = Math.Clamp(value, 0.0f, 1.0f);
    }

    public override float CalculateOutput(float input)
    {
        const float epsilon = 0.00001f;
        const float minParamA = 0.0f + epsilon;
        const float maxParamA = 1.0f - epsilon;
        const float minParamB = 0.0f;
        const float maxParamB = 1.0f;

        A = Math.Min(maxParamA, Math.Max(minParamA, A));
        B = Math.Min(maxParamB, Math.Max(minParamB, B));

        return input <= A ?
            B * (1.0f - ((float)Math.Sqrt(A * A - input * input) / A)) :
            B + ((1.0f - B) / (1.0f - A)) * (float)Math.Sqrt((1.0f - A) * (1.0f - A) - (input - 1.0f) * (input - 1.0f));
    }
}
