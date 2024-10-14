namespace Beryllium.ShapingFunctions;

public class DoubleCircleSigmoid : BaseShapingFunction
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

        return input <= A ?
            A - (float)Math.Sqrt(A * A - input * input) :
            A + (float)Math.Sqrt((1.0f - A) * (1.0f - A) - (input - 1.0f) * (input - 1.0f));
    }
}
