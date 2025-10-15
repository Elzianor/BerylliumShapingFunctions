namespace Beryllium.ShapingFunctions;

public class DoubleOddPolynomialSeat : ParametricNOrderBase, ITwoParameters, INOrder
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

    #region Order
    // good working range is 1 to ~20
    public int N { get; set; }
    #endregion

    public DoubleOddPolynomialSeat()
    {
        Name = "Double Odd Polynomial Seat";
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

        var p = 2 * N + 1;

        return input <= A ?
            B - B * (float)Math.Pow(1.0f - input / A, p) :
            B + (1.0f - B) * (float)Math.Pow((input - A) / (1.0f - A), p);
    }
}
