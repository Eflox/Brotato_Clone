/*
     * SpiderAttribute.cs
     * Script Author: Charles d'Ansembourg
     * Creation Date: 27/06/2024
     * Contact: c.dansembourg@icloud.com
     */

using Brotato_Clone.Interfaces;

namespace Brotato_Clone.Models
{
    public class SpiderAttribute : IAttribute
    {
        [Stat(operation: StatOperation.Add)]
        public readonly int Damage = 12;

        [Stat(operation: StatOperation.Add)]
        public readonly int Dodge = -3;

        [Stat(operation: StatOperation.Add)]
        public readonly int Harvesting = -5;
    }
}