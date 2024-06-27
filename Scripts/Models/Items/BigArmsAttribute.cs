/*
     * BigArmsAttribute.cs
     * Script Author: Charles d'Ansembourg
     * Creation Date: 27/06/2024
     * Contact: c.dansembourg@icloud.com
     */

using Brotato_Clone.Interfaces;

namespace Brotato_Clone.Models
{
    public class BigArmsAttribute : IAttribute
    {
        [Stat(operation: StatOperation.Add)]
        public readonly int MeleeDmg = 12;

        [Stat(operation: StatOperation.Add)]
        public readonly int RangedDmg = 6;

        [Stat(operation: StatOperation.Add)]
        public readonly int Armor = -1;

        [Stat(operation: StatOperation.Add)]
        public readonly int Speed = 15;
    }
}