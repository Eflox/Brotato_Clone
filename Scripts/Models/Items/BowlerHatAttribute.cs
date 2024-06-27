/*
     * BowlerHatAttribute.cs
     * Script Author: Charles d'Ansembourg
     * Creation Date: 27/06/2024
     * Contact: c.dansembourg@icloud.com
     */

using Brotato_Clone.Interfaces;

namespace Brotato_Clone.Models
{
    public class BowlerHatAttribute : IAttribute
    {
        [Stat(operation: StatOperation.Add)]
        public readonly int Luck = 15;

        [Stat(operation: StatOperation.Add)]
        public readonly int Harvesting = 18;

        [Stat(operation: StatOperation.Add)]
        public readonly int AttackSpeed = -5;

        [Stat(operation: StatOperation.Add)]
        public readonly int CritChance = -3;
    }
}