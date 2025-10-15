namespace Beryllium.ShapingFunctions;

public abstract class BaseShapingFunction
{
    public string Name { get; protected set; }
    public int? Order { get; protected set; }
    public bool Parametric { get; protected set; }

    public abstract float CalculateOutput(float input);
}
