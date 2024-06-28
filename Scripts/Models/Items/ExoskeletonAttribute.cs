/*
     * ExoskeletonAttribute.cs
     * Script Author: Charles d'Ansembourg
     * Creation Date: 27/06/2024
     * Contact: c.dansembourg@icloud.com
     */

using Brotato_Clone.Interfaces;

namespace Brotato_Clone.Models
{
    public class ExoskeletonAttribute : IAttribute
    {
        [Stat(operation: StatOperation.Add)]
        public readonly int Armor = 5;

        [Stat(operation: StatOperation.Add)]
        public readonly int CritChance = 5;

        [Stat(operation: StatOperation.Add)]
        public readonly int Engineering = 5;

        [Stat(operation: StatOperation.Add)]
        public readonly int Speed = 5;

        [Stat(operation: StatOperation.Add)]
        public readonly int HPRegen = -2;

        [Stat(operation: StatOperation.Add)]
        public readonly int LifeSteal = -2;
    }
}