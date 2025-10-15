namespace Beryllium.ShapingFunctions;

public class DoublePolynomialSigmoid : ParametricNOrderBase
{
    #region Customizables
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

    // good working range is 1 to ~10
    public int N { get; set; }
    #endregion

    public DoublePolynomialSigmoid()
    {
        Name = "Double Polynomial Sigmoid";
    }

    public override float CalculateOutput(float input)
    {
        float output;

        if (N % 2 == 0)
        {
            // even polynomial
            if (input <= 0.5f)
                output = (float)Math.Pow(2.0f * input, N) / 2.0f;
            else
                output = 1.0f - (float)Math.Pow(2.0f * (input - 1.0f), N) / 2.0f;
        }
        else
        {
            // odd polynomial
            if (input <= 0.5f)
                output = (float)Math.Pow(2.0f * input, N) / 2.0f;
            else
                output = 1.0f + (float)Math.Pow(2.0f * (input - 1.0f), N) / 2.0f;
        }

        return output;
    }
}
