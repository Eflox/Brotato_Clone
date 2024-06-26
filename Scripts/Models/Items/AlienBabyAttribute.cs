/*
 * AlienBabyAttribute.cs
 * Script Author: Charles d'Ansembourg
 * Creation Date: 28/05/2024
 * Contact: c.dansembourg@icloud.com
 */

using Brotato_Clone.Interfaces;

namespace Brotato_Clone.Models
{
    public class AlienBabyAttribute : IAttribute
    {
        [Stat(operation: StatOperation.Add)]
        public readonly int EnemySpeed = 8;

        [Stat(operation: StatOperation.Add)]
        public readonly int MaxHP = 15;
    }
}