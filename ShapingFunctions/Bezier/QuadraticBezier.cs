namespace Beryllium.ShapingFunctions;

public class QuadraticBezier : BaseShapingFunction
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
        A = Math.Max(0.0f, Math.Min(1.0f, A));
        B = Math.Max(0.0f, Math.Min(1.0f, B));

        if (A == 0.5f) A += epsilon;

        // solve t from x (an inverse operation)
        var om2a = 1.0f - 2.0f * A;
        var t = (float)(Math.Sqrt(A * A + om2a * input) - A) / om2a;
        return (1.0f - 2.0f * B) * (t * t) + 2.0f * B * t;
    }
}
