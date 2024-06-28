/*
     * TriangleofPowerAttribute.cs
     * Script Author: Charles d'Ansembourg
     * Creation Date: 27/06/2024
     * Contact: c.dansembourg@icloud.com
     */

using Brotato_Clone.Interfaces;

namespace Brotato_Clone.Models
{
    public class TriangleofPowerAttribute : IAttribute, IOnTakeDamage
    {
        [Stat(operation: StatOperation.Add)]
        public readonly int Damage = 20;

        [Stat(operation: StatOperation.Add)]
        public readonly int Armor = 1;

        public void OnTakeDamage()
        {
            throw new System.NotImplementedException();
        }
    }
}