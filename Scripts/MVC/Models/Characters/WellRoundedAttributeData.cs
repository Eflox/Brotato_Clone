/*
 * WellRoundedAttributeData.cs
 * Script Author: Charles d'Ansembourg
 * Creation Date: 05/06/2024
 * Contact: c.dansembourg@icloud.com
 */

using Brotato_Clone.Interfaces;

namespace Brotato_Clone.Models
{
    /// <summary>
    /// Well Rounded's attributes
    /// </summary>
    public class WellRoundedAttributeData : IAttribute
    {
        [Stat(operation: StatOperation.Add)]
        public readonly int Harvesting = 8;

        [Stat(operation: StatOperation.Add)]
        public readonly int MaxHP = 5;

        [Stat(operation: StatOperation.Add)]
        public readonly int Speed = 5;
    }
}