/*
     * ShmoopAttribute.cs
     * Script Author: Charles d'Ansembourg
     * Creation Date: 27/06/2024
     * Contact: c.dansembourg@icloud.com
     */

using Brotato_Clone.Interfaces;

namespace Brotato_Clone.Models
{
    public class ShmoopAttribute : IAttribute
    {
        [Stat(operation: StatOperation.Add)]
        public readonly int MaxHP = 6;

        [Stat(operation: StatOperation.Add)]
        public readonly int HPRegen = 2;

        [Stat(operation: StatOperation.Add)]
        public readonly int MeleeDmg = -2;

        [Stat(operation: StatOperation.Add)]
        public readonly int RangedDmg = -1;
    }
}