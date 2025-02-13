/*
     * ReflexesAttribute.cs
     * Script Author: Charles d'Ansembourg
     * Creation Date: 28/06/2024
     * Contact: c.dansembourg@icloud.com
     */

using Brotato_Clone.Interfaces;

namespace Brotato_Clone.Models
{
    public class ReflexesAttribute : IAttribute
    {
        [Stat(operation: StatOperation.Add)]
        public readonly int AttackSpeed = 5;
    }
}