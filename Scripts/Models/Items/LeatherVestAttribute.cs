/*
     * LeatherVestAttribute.cs
     * Script Author: Charles d'Ansembourg
     * Creation Date: 27/06/2024
     * Contact: c.dansembourg@icloud.com
     */

using Brotato_Clone.Interfaces;

namespace Brotato_Clone.Models
{
    public class LeatherVestAttribute : IAttribute
    {
        [Stat(operation: StatOperation.Add)]
        public readonly int Armor = 2;

        [Stat(operation: StatOperation.Add)]
        public readonly int Dodge = 6;

        [Stat(operation: StatOperation.Add)]
        public readonly int MaxHP = -3;
    }
}