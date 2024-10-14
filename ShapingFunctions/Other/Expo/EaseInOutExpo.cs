﻿namespace Beryllium.ShapingFunctions;

public class EaseInOutExpo : BaseShapingFunction
{
    public override float CalculateOutput(float input)
    {
        return input == 0.0f ?
            0.0f :
            input == 1.0f ?
                1.0f :
                input < 0.5f ?
                    (float)Math.Pow(2, 20 * input - 10) / 2.0f :
                    (float)(2 - Math.Pow(2, -20 * input + 10)) / 2.0f;
    }
}