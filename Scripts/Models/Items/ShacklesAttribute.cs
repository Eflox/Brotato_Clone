/*
     * ShacklesAttribute.cs
     * Script Author: Charles d'Ansembourg
     * Creation Date: 27/06/2024
     * Contact: c.dansembourg@icloud.com
     */

using Brotato_Clone.Interfaces;

namespace Brotato_Clone.Models
{
    public class ShacklesAttribute : IAttribute
    {
        [Stat(operation: StatOperation.Add)]
        public readonly int HPRegen = 8;

        [Stat(operation: StatOperation.Add)]
        public readonly int Engineering = 8;

        [Stat(operation: StatOperation.Add)]
        public readonly int Range = 80;
    }
}