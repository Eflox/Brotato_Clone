/*
 * RarityColorsData.cs
 * Script Author: Charles d'Ansembourg
 * Creation Date: 27/06/2024
 * Contact: c.dansembourg@icloud.com
 */

using System.Collections.Generic;
using UnityEngine;

public static class RarityColorsData
{
    public static readonly Dictionary<Rarity, Color> Colors = new Dictionary<Rarity, Color>
    {
        { Rarity.Tier1, HexToColor("#302C2C") },
        { Rarity.Tier2, HexToColor("#423F7B") },
        { Rarity.Tier3, HexToColor("#763E87") },
        { Rarity.Tier4, HexToColor("#802728") },
    };

    private static Color HexToColor(string hex)
    {
        if (ColorUtility.TryParseHtmlString(hex, out Color color))
            return color;

        return Color.black;
    }
}