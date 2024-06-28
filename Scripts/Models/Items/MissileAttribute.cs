/*
     * MissileAttribute.cs
     * Script Author: Charles d'Ansembourg
     * Creation Date: 27/06/2024
     * Contact: c.dansembourg@icloud.com
     */

using Brotato_Clone.Interfaces;

namespace Brotato_Clone.Models
{
    public class MissileAttribute : IAttribute
    {
        [Stat(operation: StatOperation.Add)]
        public readonly int Damage = 10;

        [Stat(operation: StatOperation.Add)]
        public readonly int AttackSpeed = -4;
    }
}