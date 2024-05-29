/*
 * Script Author: Charles d'Ansembourg
 * Creation Date: 29/05/2024
 * Contact: c.dansembourg@icloud.com
 */

using System;

public static class IntExtensions
{
    public static int MultiplyAndRoundUp(this int input, float multiplier)
    {
        float result = input * multiplier;
        return (int)Math.Ceiling(result);
    }

    public static int ApplyMultiplier(this int baseValue, int multiplierPercent)
    {
        return (int)Math.Round(baseValue * (1 + multiplierPercent / 100.0));
    }
}