/*
     * FuelTankAttribute.cs
     * Script Author: Charles d'Ansembourg
     * Creation Date: 27/06/2024
     * Contact: c.dansembourg@icloud.com
     */

using Brotato_Clone.Interfaces;

namespace Brotato_Clone.Models
{
    public class FuelTankAttribute : IAttribute
    {
        [Stat(operation: StatOperation.Add)]
        public readonly int ElementalDmg = 4;

        [Stat(operation: StatOperation.Add)]
        public readonly int MeleeDmg = -1;

        [Stat(operation: StatOperation.Add)]
        public readonly int RangedDmg = -1;
    }
}