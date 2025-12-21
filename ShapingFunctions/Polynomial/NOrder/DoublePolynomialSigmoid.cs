namespace Beryllium.ShapingFunctions;

public class DoublePolynomialSigmoid : NOrderBase, INOrder
{
    #region Order
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
