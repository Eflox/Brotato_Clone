/*
     * DefectiveSteroidsAttribute.cs
     * Script Author: Charles d'Ansembourg
     * Creation Date: 27/06/2024
     * Contact: c.dansembourg@icloud.com
     */

using Brotato_Clone.Interfaces;

namespace Brotato_Clone.Models
{
    public class DefectiveSteroidsAttribute : IAttribute
    {
        [Stat(operation: StatOperation.Add)]
        public readonly int MeleeDmg = 2;

        [Stat(operation: StatOperation.Add)]
        public readonly int AttackSpeed = -3;

        [Stat(operation: StatOperation.Add)]
        public readonly int MaxHP = 2;
    }
}