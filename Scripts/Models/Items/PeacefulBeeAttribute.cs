/*
     * PeacefulBeeAttribute.cs
     * Script Author: Charles d'Ansembourg
     * Creation Date: 27/06/2024
     * Contact: c.dansembourg@icloud.com
     */

using Brotato_Clone.Interfaces;

namespace Brotato_Clone.Models
{
    public class PeacefulBeeAttribute : IAttribute
    {
        [Stat(operation: StatOperation.Add)]
        public readonly int Dodge = 4;

        [Stat(operation: StatOperation.Add)]
        public readonly int Harvesting = 4;

        [Stat(operation: StatOperation.Add)]
        public readonly int MeleeDmg = -1;

        [Stat(operation: StatOperation.Add)]
        public readonly int RangedDmg = -1;
    }
}