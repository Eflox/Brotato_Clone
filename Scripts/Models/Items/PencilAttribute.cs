/*
     * PencilAttribute.cs
     * Script Author: Charles d'Ansembourg
     * Creation Date: 27/06/2024
     * Contact: c.dansembourg@icloud.com
     */

using Brotato_Clone.Interfaces;

namespace Brotato_Clone.Models
{
    public class PencilAttribute : IAttribute
    {
        [Stat(operation: StatOperation.Add)]
        public readonly int Engineering = 2;

        [Stat(operation: StatOperation.Add)]
        public readonly int AttackSpeed = -1;

        [Stat(operation: StatOperation.Add)]
        public readonly int CritChance = -1;
    }
}