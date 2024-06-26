/*
 * BannerAttribute.cs
 * Script Author: Charles d'Ansembourg
 * Creation Date: 26/06/2024
 * Contact: c.dansembourg@icloud.com
 */

using Brotato_Clone.Interfaces;

namespace Brotato_Clone.Models
{
    public class BannerAttribute : IAttribute
    {
        [Stat(operation: StatOperation.Add)]
        public readonly int Range = 20;

        [Stat(operation: StatOperation.Add)]
        public readonly int AttackSpeed = 10;

        [Stat(operation: StatOperation.Add)]
        public readonly int LifeSteal = -2;
    }
}