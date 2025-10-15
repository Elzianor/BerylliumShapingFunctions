namespace Beryllium.ShapingFunctions;

public class ExponentialEasing : ParametricTranscendentalBase, IOneParameter
{
    #region Parameters
    private float _a;
    public float A
    {
        get => _a;
        set => _a = Math.Clamp(value, 0.0f, 1.0f);
    }
    #endregion

    public ExponentialEasing()
    {
        Name = "Exponential Easing";
    }

    public override float CalculateOutput(float input)
    {
        const float epsilon = 0.00001f;
        const float minParamA = 0.0f + epsilon;
        const float maxParamA = 1.0f - epsilon;

        A = Math.Min(maxParamA, Math.Max(minParamA, A));

        if (A < 0.5)
        {
            // emphasis
            A = 2.0f * A;

            return (float)Math.Pow(input, A);
        }

        // de-emphasis
        A = 2.0f * (A - 0.5f);

        return (float)Math.Pow(input, 1.0f / (1.0f - A));
    }
}
