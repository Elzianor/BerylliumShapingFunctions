namespace Beryllium.ShapingFunctions;

public class CubicDoubleSeat : ParametricCubicBase, ITwoParameters
{
    #region Parameters
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
    #endregion

    public CubicDoubleSeat()
    {
        Name = "Cubic Double Seat";
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
            B - B * (float)Math.Pow(1.0f - input / A, 3.0f) :
            B + (1 - B) * (float)Math.Pow((input - A) / (1.0f - A), 3.0f);
    }
}
