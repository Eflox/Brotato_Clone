/*
     * NightGogglesAttribute.cs
     * Script Author: Charles d'Ansembourg
     * Creation Date: 27/06/2024
     * Contact: c.dansembourg@icloud.com
     */

using Brotato_Clone.Interfaces;

namespace Brotato_Clone.Models
{
    public class NightGogglesAttribute : IAttribute
    {
        [Stat(operation: StatOperation.Add)]
        public readonly int CritChance = 15;

        [Stat(operation: StatOperation.Add)]
        public readonly int Range = 50;

        [Stat(operation: StatOperation.Add)]
        public readonly int MaxHP = -3;

        [Stat(operation: StatOperation.Add)]
        public readonly int Armor = -1;
    }
}