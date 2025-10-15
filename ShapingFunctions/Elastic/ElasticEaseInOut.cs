namespace Beryllium.ShapingFunctions;

public class ElasticEaseInOut : TranscendentalBase
{
    public ElasticEaseInOut()
    {
        Name = "Elastic EaseInOut";
    }

    public override float CalculateOutput(float input)
    {
        const float c5 = (float)(2 * Math.PI) / 4.5f;

        return BMath.IsEqual(input, 0.0f) ?
            0.0f :
            BMath.IsEqual(input, 1.0f) ?
                1.0f :
                input < 0.5f ?
                    (float)(-(Math.Pow(2, 20 * input - 10) * Math.Sin((20 * input - 11.125) * c5)) / 2.0f) :
                    (float)(Math.Pow(2, -20 * input + 10) * Math.Sin((20 * input - 11.125) * c5)) / 2.0f + 1.0f;
    }
}
