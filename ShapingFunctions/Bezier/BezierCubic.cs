namespace Beryllium.ShapingFunctions;

public class BezierCubic : ParametricCubicBase, IFourParameters
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

    private float _c;
    public float C
    {
        get => _c;
        set => _c = Math.Clamp(value, 0.0f, 1.0f);
    }

    private float _d;
    public float D
    {
        get => _d;
        set => _d = Math.Clamp(value, 0.0f, 1.0f);
    }
    #endregion

    public BezierCubic()
    {
        Name = "Bezier Cubic";
    }

    public override float CalculateOutput(float input)
    {
        const float y0a = 0.0f;
        const float x0a = 0.0f;
        var y1a = B;
        var x1a = A;
        var y2a = D;
        var x2a = C;
        const float y3a = 1.0f;
        const float x3a = 1.0f;

        var a = x3a - 3.0f * x2a + 3.0f * x1a - x0a;
        var b = 3.0f * x2a - 6.0f * x1a + 3.0f * x0a;
        var c = 3.0f * x1a - 3.0f * x0a;

        var e = y3a - 3.0f * y2a + 3.0f * y1a - y0a;
        var f = 3.0f * y2a - 6.0f * y1a + 3.0f * y0a;
        var g = 3.0f * y1a - 3.0f * y0a;

        var currentT = input;
        const int nRefinementIterations = 5;

        for (var i = 0; i < nRefinementIterations; i++)
        {
            var currentX = XFromT(currentT, a, b, c, x0a);
            var currentSlope = SlopeFromT(currentT, a, b, c);
            currentT -= (currentX - input) * currentSlope;
            currentT = Math.Clamp(currentT, 0.0f, 1.0f);
        }

        return YFromT(currentT, e, f, g, y0a);
    }

    #region Helpers
    private static float SlopeFromT(float t, float a, float b, float c)
    {
        return 1.0f / (3.0f * a * t * t + 2.0f * b * t + c);
    }

    private static float XFromT(float t, float a, float b, float c, float d)
    {
        return a * (t * t * t) + b * (t * t) + c * t + d;
    }

    private static float YFromT(float t, float e, float f, float g, float h)
    {
        return e * (t * t * t) + f * (t * t) + g * t + h;
    }
    #endregion
}
