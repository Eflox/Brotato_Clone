/*
 * Script Author: Charles d'Ansembourg
 * Creation Date: 28/05/2024
 * Contact: c.dansembourg@icloud.com
 */

public static class StringExtensions
{
    public static string WithColors(this string text)
    {
        return text.Replace("[g]", "<color=green>")
                    .Replace("[r]", "<color=red>")
                    .Replace("[c]", "</color>");
    }

    public static string WithNL(this string text)
    {
        return text.Replace("[nl]", "\n");
    }
}