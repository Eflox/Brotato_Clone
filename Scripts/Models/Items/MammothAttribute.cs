/*
     * MammothAttribute.cs
     * Script Author: Charles d'Ansembourg
     * Creation Date: 27/06/2024
     * Contact: c.dansembourg@icloud.com
     */

using Brotato_Clone.Interfaces;

namespace Brotato_Clone.Models
{
    public class MammothAttribute : IAttribute
    {
        [Stat(operation: StatOperation.Add)]
        public readonly int MeleeDmg = 20;

        [Stat(operation: StatOperation.Add)]
        public readonly int HPRegen = 5;

        [Stat(operation: StatOperation.Add)]
        public readonly int Damage = -8;

        [Stat(operation: StatOperation.Add)]
        public readonly int Speed = -3;
    }
}