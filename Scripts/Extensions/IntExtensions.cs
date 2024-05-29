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
}