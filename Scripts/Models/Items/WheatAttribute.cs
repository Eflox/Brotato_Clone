/*
     * WheatAttribute.cs
     * Script Author: Charles d'Ansembourg
     * Creation Date: 27/06/2024
     * Contact: c.dansembourg@icloud.com
     */

using Brotato_Clone.Interfaces;

namespace Brotato_Clone.Models
{
    public class WheatAttribute : IAttribute
    {
        [Stat(operation: StatOperation.Add)]
        public readonly int MeleeDmg = 4;

        [Stat(operation: StatOperation.Add)]
        public readonly int RangedDmg = 2;

        [Stat(operation: StatOperation.Add)]
        public readonly int Harvesting = 10;

        [Stat(operation: StatOperation.Add)]
        public readonly int ElementalDmg = -2;
    }
}