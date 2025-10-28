namespace Beryllium.ShapingFunctions;

public enum ShapingFunctionTypes
{
    Back,
    Bezier,
    Bounce,
    Circular,
    Elastic,
    Elliptical,
    Exponential,
    Linear,
    Quadratic,
    Cubic,
    Quartic,
    Quintic,
    Hexic,
    NOrder,
    Sine
}

public static class ShapingFunctionsCatalog
{
    private static readonly Dictionary<ShapingFunctionTypes, List<ShapingFunctions>> Catalog;

    static ShapingFunctionsCatalog()
    {
        Catalog = [];

        Catalog.Add(ShapingFunctionTypes.Back, CreateFunctionsList(ShapingFunctionTypes.Back));
        Catalog.Add(ShapingFunctionTypes.Bezier, CreateFunctionsList(ShapingFunctionTypes.Bezier));
        Catalog.Add(ShapingFunctionTypes.Bounce, CreateFunctionsList(ShapingFunctionTypes.Bounce));
        Catalog.Add(ShapingFunctionTypes.Circular, CreateFunctionsList(ShapingFunctionTypes.Circular));
        Catalog.Add(ShapingFunctionTypes.Elastic, CreateFunctionsList(ShapingFunctionTypes.Elastic));
        Catalog.Add(ShapingFunctionTypes.Elliptical, CreateFunctionsList(ShapingFunctionTypes.Elliptical));
        Catalog.Add(ShapingFunctionTypes.Exponential, CreateFunctionsList(ShapingFunctionTypes.Exponential));
        Catalog.Add(ShapingFunctionTypes.Linear, CreateFunctionsList(ShapingFunctionTypes.Linear));
        Catalog.Add(ShapingFunctionTypes.Quadratic, CreateFunctionsList(ShapingFunctionTypes.Quadratic));
        Catalog.Add(ShapingFunctionTypes.Cubic, CreateFunctionsList(ShapingFunctionTypes.Cubic));
        Catalog.Add(ShapingFunctionTypes.Quartic, CreateFunctionsList(ShapingFunctionTypes.Quartic));
        Catalog.Add(ShapingFunctionTypes.Quintic, CreateFunctionsList(ShapingFunctionTypes.Quintic));
        Catalog.Add(ShapingFunctionTypes.Hexic, CreateFunctionsList(ShapingFunctionTypes.Hexic));
        Catalog.Add(ShapingFunctionTypes.NOrder, CreateFunctionsList(ShapingFunctionTypes.NOrder));
        Catalog.Add(ShapingFunctionTypes.Sine, CreateFunctionsList(ShapingFunctionTypes.Sine));
    }

    public static ICollection<ShapingFunctionTypes> GetAvailableFunctionTypes()
    {
        return Catalog.Keys;
    }

    public static List<ShapingFunctions> GetFunctionsOfType(ShapingFunctionTypes type)
    {
        return Catalog.GetValueOrDefault(type);
    }

    private static List<ShapingFunctions> CreateFunctionsList(ShapingFunctionTypes type)
    {
        return type switch
        {
            ShapingFunctionTypes.Back =>
            [
                ShapingFunctions.BackEaseIn,
                ShapingFunctions.BackEaseInOut,
                ShapingFunctions.BackEaseOut
            ],
            ShapingFunctionTypes.Bezier =>
            [
                ShapingFunctions.BezierCubic,
                ShapingFunctions.BezierQuadratic
            ],
            ShapingFunctionTypes.Bounce =>
            [
                ShapingFunctions.BounceEaseIn,
                ShapingFunctions.BounceEaseInOut,
                ShapingFunctions.BounceEaseOut
            ],
            ShapingFunctionTypes.Circular =>
            [
                ShapingFunctions.CircularDoubleSeat,
                ShapingFunctions.CircularDoubleSigmoid,
                ShapingFunctions.CircularEaseIn,
                ShapingFunctions.CircularEaseInOut,
                ShapingFunctions.CircularEaseOut
            ],
            ShapingFunctionTypes.Elastic =>
            [
                ShapingFunctions.ElasticEaseIn,
                ShapingFunctions.ElasticEaseInOut,
                ShapingFunctions.ElasticEaseOut
            ],
            ShapingFunctionTypes.Elliptical =>
            [
                ShapingFunctions.EllipticalDoubleSeat,
                ShapingFunctions.EllipticalDoubleSigmoid
            ],
            ShapingFunctionTypes.Exponential =>
            [
                ShapingFunctions.ExponentialDoubleSeat,
                ShapingFunctions.ExponentialDoubleSigmoid,
                ShapingFunctions.ExponentialEaseIn,
                ShapingFunctions.ExponentialEaseInOut,
                ShapingFunctions.ExponentialEaseOut,
                ShapingFunctions.ExponentialEasing
            ],
            ShapingFunctionTypes.Linear => [ShapingFunctions.Linear],
            ShapingFunctionTypes.Quadratic =>
            [
                ShapingFunctions.QuadraticEaseIn,
                ShapingFunctions.QuadraticEaseInOut,
                ShapingFunctions.QuadraticEaseOut,
                ShapingFunctions.QuadraticThroughAGivenPoint
            ],
            ShapingFunctionTypes.Cubic =>
            [
                ShapingFunctions.CubicDoubleSeat,
                ShapingFunctions.CubicDoubleSeatWithLinearBlend,
                ShapingFunctions.CubicEaseIn,
                ShapingFunctions.CubicEaseInOut,
                ShapingFunctions.CubicEaseOut
            ],
            ShapingFunctionTypes.Quartic =>
            [
                ShapingFunctions.QuarticEaseIn,
                ShapingFunctions.QuarticEaseInOut,
                ShapingFunctions.QuarticEaseOut
            ],
            ShapingFunctionTypes.Quintic =>
            [
                ShapingFunctions.QuinticEaseIn,
                ShapingFunctions.QuinticEaseInOut,
                ShapingFunctions.QuinticEaseOut
            ],
            ShapingFunctionTypes.Hexic => [ShapingFunctions.BlinnWyvillCosineApproximation],
            ShapingFunctionTypes.NOrder =>
            [
                ShapingFunctions.DoubleOddPolynomialSeat,
                ShapingFunctions.DoublePolynomialSigmoid
            ],
            ShapingFunctionTypes.Sine =>
            [
                ShapingFunctions.SineEaseIn,
                ShapingFunctions.SineEaseInOut,
                ShapingFunctions.SineEaseOut
            ],
            _ => null
        };
    }
}
