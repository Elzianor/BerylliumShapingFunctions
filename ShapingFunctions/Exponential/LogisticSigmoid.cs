namespace Beryllium.ShapingFunctions;

public class LogisticSigmoid : ParametricTranscendentalBase
{
    #region Customizables
    private float _a;
    public float A
    {
        get => _a;
        set => _a = Math.Clamp(value, 0.0f, 1.0f);
    }
    #endregion

    public LogisticSigmoid()
    {
        Name = "Logistic Sigmoid";
    }

    // this Logistic Sigmoid has been normalized (also it is expensive)
    public override float CalculateOutput(float input)
    {
        const float epsilon = 0.00001f;
        const float minParamA = 0.0f + epsilon;
        const float maxParamA = 1.0f - epsilon;

        A = Math.Min(maxParamA, Math.Max(minParamA, A));
        A = 1.0f / (1.0f - A) - 1.0f;

        var a = 1.0f / (1.0f + (float)Math.Exp(0.0f - (input - 0.5f) * A * 2.0f));
        var b = 1.0f / (1.0f + (float)Math.Exp(A));
        var c = 1.0f / (1.0f + (float)Math.Exp(0.0f - A));

        return (a - b) / (c - b);
    }
}
