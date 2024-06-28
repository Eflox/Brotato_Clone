/*
     * MetalDetectorAttribute.cs
     * Script Author: Charles d'Ansembourg
     * Creation Date: 27/06/2024
     * Contact: c.dansembourg@icloud.com
     */

using Brotato_Clone.Interfaces;

namespace Brotato_Clone.Models
{
    public class MetalDetectorAttribute : IAttribute, IOnMaterialPickup
    {
        [Stat(operation: StatOperation.Add)]
        public readonly int Luck = 6;

        [Stat(operation: StatOperation.Add)]
        public readonly int Engineering = 2;

        [Stat(operation: StatOperation.Add)]
        public readonly int Damage = -5;

        public void OnMaterialPickup()
        {
            throw new System.NotImplementedException();
        }
    }
}