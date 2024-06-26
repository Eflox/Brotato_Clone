/*
 * AlienWormAttribute.cs
 * Script Author: Charles d'Ansembourg
 * Creation Date: 26/06/2024
 * Contact: c.dansembourg@icloud.com
 */

using Brotato_Clone.Interfaces;

namespace Brotato_Clone.Models
{
    public class AlienWormAttribute : IAttribute
    {
        [Stat(operation: StatOperation.Add)]
        public readonly int HPRegen = 2;

        [Stat(operation: StatOperation.Add)]
        public readonly int HPPerConsumable = -1;

        [Stat(operation: StatOperation.Add)]
        public readonly int MaxHP = 3;
    }
}