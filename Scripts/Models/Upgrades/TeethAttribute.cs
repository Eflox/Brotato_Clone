/*
 * TeethAttribute.cs
 * Script Author: Charles d'Ansembourg
 * Creation Date: 25/06/2024
 * Contact: c.dansembourg@icloud.com
 */

using Brotato_Clone.Interfaces;

namespace Brotato_Clone.Models
{
    public class TeethAttribute : IAttribute
    {
        [Stat(operation: StatOperation.Add)]
        public readonly int LifeSteal = 1;
    }
}