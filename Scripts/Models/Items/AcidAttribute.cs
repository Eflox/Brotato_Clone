/*
 * AcidAttribute.cs
 * Script Author: Charles d'Ansembourg
 * Creation Date: 26/06/2024
 * Contact: c.dansembourg@icloud.com
 */

using Brotato_Clone.Interfaces;

namespace Brotato_Clone.Models
{
    public class AcidAttribute : IAttribute
    {
        [Stat(operation: StatOperation.Add)]
        public readonly int MaxHP = 8;

        [Stat(operation: StatOperation.Add)]
        public readonly int Dodge = -4;
    }
}