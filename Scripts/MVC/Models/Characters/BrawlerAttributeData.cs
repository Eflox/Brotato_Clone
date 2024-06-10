/*
 * BrawlerAttributeData.cs
 * Script Author: Charles d'Ansembourg
 * Creation Date: 05/06/2024
 * Contact: c.dansembourg@icloud.com
 */

using Brotato_Clone.Interfaces;

namespace Brotato_Clone.Models
{
    /// <summary>
    /// Brawler character attributes
    /// </summary>
    public class BrawlerAttributeData : IAttribute
    {
        [Stat(operation: StatOperation.Add)]
        public readonly int Dodge = 15;

        [Stat(operation: StatOperation.Add)]
        public readonly int Range = -50;

        [Stat(operation: StatOperation.Add)]
        public readonly int RangedDmg = -50;

        [Item]
        public string[] Item = { "Fist" };
    }
}