/*
     * ChameleonAttribute.cs
     * Script Author: Charles d'Ansembourg
     * Creation Date: 27/06/2024
     * Contact: c.dansembourg@icloud.com
     */

using Brotato_Clone.Interfaces;

namespace Brotato_Clone.Models
{
    public class ChameleonAttribute : IAttribute, IOnMovement
    {
        [Stat(operation: StatOperation.Add)]
        public readonly int Damage = -4;

        [Stat(operation: StatOperation.Add)]
        public readonly int Dodge = 3;

        public void OnMovement(bool moving)
        {
            throw new System.NotImplementedException();
        }
    }
}