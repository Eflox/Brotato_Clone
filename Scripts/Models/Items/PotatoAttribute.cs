/*
     * PotatoAttribute.cs
     * Script Author: Charles d'Ansembourg
     * Creation Date: 27/06/2024
     * Contact: c.dansembourg@icloud.com
     */

using Brotato_Clone.Interfaces;

namespace Brotato_Clone.Models
{
    public class PotatoAttribute : IAttribute
    {
        [Stat(operation: StatOperation.Add)]
        public readonly int MaxHP = 3;

        [Stat(operation: StatOperation.Add)]
        public readonly int HPRegen = 2;

        [Stat(operation: StatOperation.Add)]
        public readonly int LifeSteal = 1;

        [Stat(operation: StatOperation.Add)]
        public readonly int Damage = 5;

        [Stat(operation: StatOperation.Add)]
        public readonly int AttackSpeed = 5;

        [Stat(operation: StatOperation.Add)]
        public readonly int Speed = 3;

        [Stat(operation: StatOperation.Add)]
        public readonly int Dodge = 3;

        [Stat(operation: StatOperation.Add)]
        public readonly int Armor = 1;

        [Stat(operation: StatOperation.Add)]
        public readonly int Luck = 5;
    }
}