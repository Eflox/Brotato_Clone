/*
     * BlindfoldAttribute.cs
     * Script Author: Charles d'Ansembourg
     * Creation Date: 27/06/2024
     * Contact: c.dansembourg@icloud.com
     */

using Brotato_Clone.Interfaces;

namespace Brotato_Clone.Models
{
    public class BlindfoldAttribute : IAttribute
    {
        [Stat(operation: StatOperation.Add)]
        public readonly int CritChance = 5;

        [Stat(operation: StatOperation.Add)]
        public readonly int Dodge = 5;

        [Stat(operation: StatOperation.Add)]
        public readonly int Range = -15;
    }
}