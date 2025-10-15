namespace Beryllium.ShapingFunctions;

public class QuadraticThroughAGivenPoint : ParametricQuadraticBase
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
    #endregion

    public QuadraticThroughAGivenPoint()
    {
        Name = "Quadratic Through A Given Point";
    }

    // Caution: Not all points in the unit square will produce curves which pass through the locations (0,0) and (1,1)
    public override float CalculateOutput(float input)
    {
        const float epsilon = 0.00001f;
        const float minParamA = 0.0f + epsilon;
        const float maxParamA = 1.0f - epsilon;
        const float minParamB = 0.0f;
        const float maxParamB = 1.0f;

        A = Math.Min(maxParamA, Math.Max(minParamA, A));
        B = Math.Min(maxParamB, Math.Max(minParamB, B));

        var a = (1.0f - B) / (1.0f - A) - B / A;
        var b = (a * (A * A) - B) / A;
        var output = a * (input * input) - b * input;

        return Math.Min(1.0f, Math.Max(0.0f, output));
    }
}
