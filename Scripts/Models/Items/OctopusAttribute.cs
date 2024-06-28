/*
     * OctopusAttribute.cs
     * Script Author: Charles d'Ansembourg
     * Creation Date: 27/06/2024
     * Contact: c.dansembourg@icloud.com
     */

using Brotato_Clone.Interfaces;

namespace Brotato_Clone.Models
{
    public class OctopusAttribute : IAttribute
    {
        [Stat(operation: StatOperation.Add)]
        public readonly int MaxHP = 12;

        [Stat(operation: StatOperation.Add)]
        public readonly int HPRegen = 5;

        [Stat(operation: StatOperation.Add)]
        public readonly int LifeSteal = 3;

        [Stat(operation: StatOperation.Add)]
        public readonly int CritChance = -8;
    }
}