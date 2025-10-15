namespace Beryllium.ShapingFunctions;

public class Linear : LinearBase
{
    public Linear()
    {
        Name = "Linear";
    }

    public override float CalculateOutput(float input)
    {
        return input;
    }
}
