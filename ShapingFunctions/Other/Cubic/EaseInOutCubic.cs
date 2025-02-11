﻿namespace Beryllium.ShapingFunctions;

public class EaseInOutCubic : BaseShapingFunction
{
    public override float CalculateOutput(float input)
    {
        return input < 0.5 ?
            4 * input * input * input :
            1.0f - (float)Math.Pow(-2 * input + 2, 3) / 2.0f;
    }
}
