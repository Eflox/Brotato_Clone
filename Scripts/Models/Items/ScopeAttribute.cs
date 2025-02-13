/*
     * ScopeAttribute.cs
     * Script Author: Charles d'Ansembourg
     * Creation Date: 27/06/2024
     * Contact: c.dansembourg@icloud.com
     */

using Brotato_Clone.Interfaces;

namespace Brotato_Clone.Models
{
    public class ScopeAttribute : IAttribute
    {
        [Stat(operation: StatOperation.Add)]
        public readonly int RangedDmg = 2;

        [Stat(operation: StatOperation.Add)]
        public readonly int Range = 25;

        [Stat(operation: StatOperation.Add)]
        public readonly int AttackSpeed = -7;
    }
}