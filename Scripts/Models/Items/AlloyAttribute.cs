/*
 * AlloyAttribute.cs
 * Script Author: Charles d'Ansembourg
 * Creation Date: 26/06/2024
 * Contact: c.dansembourg@icloud.com
 */

using Brotato_Clone.Interfaces;

namespace Brotato_Clone.Models
{
    public class AlloyAttribute : IAttribute
    {
        [Stat(operation: StatOperation.Add)]
        public readonly int MeleeDmg = 3;

        [Stat(operation: StatOperation.Add)]
        public readonly int RangedDmg = 3;

        [Stat(operation: StatOperation.Add)]
        public readonly int ElementalDmg = 3;

        [Stat(operation: StatOperation.Add)]
        public readonly int Engineering = 3;

        [Stat(operation: StatOperation.Add)]
        public readonly int CritChance = 5;

        [Stat(operation: StatOperation.Add)]
        public readonly int Dodge = -6;
    }
}