/*
 * BarricadeAttribute.cs
 * Script Author: Charles d'Ansembourg
 * Creation Date: 26/06/2024
 * Contact: c.dansembourg@icloud.com
 */

using Brotato_Clone.Interfaces;

namespace Brotato_Clone.Models
{
    public class BarricadeAttribute : IAttribute, IOnMovement
    {
        [Stat(operation: StatOperation.Add)]
        public readonly int Speed = -5;

        public void OnMovement(bool moving)
        {
            throw new System.NotImplementedException();
        }
    }
}