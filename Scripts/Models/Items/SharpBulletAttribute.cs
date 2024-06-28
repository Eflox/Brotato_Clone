/*
     * SharpBulletAttribute.cs
     * Script Author: Charles d'Ansembourg
     * Creation Date: 27/06/2024
     * Contact: c.dansembourg@icloud.com
     */

using Brotato_Clone.Interfaces;

namespace Brotato_Clone.Models
{
    public class SharpBulletAttribute : IAttribute
    {
        [Stat(operation: StatOperation.Add)]
        public readonly int Pierces = 1;

        [Stat(operation: StatOperation.Add)]
        public readonly int PiercingDmg = -20;

        [Stat(operation: StatOperation.Add)]
        public readonly int Damage = -5;
    }
}