/*
     * WarriorHelmetAttribute.cs
     * Script Author: Charles d'Ansembourg
     * Creation Date: 27/06/2024
     * Contact: c.dansembourg@icloud.com
     */

using Brotato_Clone.Interfaces;

namespace Brotato_Clone.Models
{
    public class WarriorHelmetAttribute : IAttribute
    {
        [Stat(operation: StatOperation.Add)]
        public readonly int Armor = 3;

        [Stat(operation: StatOperation.Add)]
        public readonly int MaxHP = 5;

        [Stat(operation: StatOperation.Add)]
        public readonly int Speed = -5;
    }
}