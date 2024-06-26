/*
 * StringExtensions.cs
 * Script Author: Charles d'Ansembourg
 * Creation Date: 28/05/2024
 * Contact: c.dansembourg@icloud.com
 */

using System.Text.RegularExpressions;

namespace Brotato_Clone.Extensions
{
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

        public static string WithPN(this string text)
        {
            var regex = new Regex(@"-?\d+");

            return regex.Replace(text, match =>
            {
                int number = int.Parse(match.Value);
                if (number == 0)
                    return match.Value;

                string color = number < 0 ? "red" : "green";
                return $"<color={color}>{number}</color>";
            });
        }
    }
}