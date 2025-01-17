﻿namespace Beryllium.ShapingFunctions;

public class EaseInBack : BaseShapingFunction
{
    public override float CalculateOutput(float input)
    {
        const float c1 = 1.70158f;
        const float c3 = c1 + 1.0f;

        return c3 * input * input * input - c1 * input * input;
    }
}
