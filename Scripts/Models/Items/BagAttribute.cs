/*
 * BagAttribute.cs
 * Script Author: Charles d'Ansembourg
 * Creation Date: 26/06/2024
 * Contact: c.dansembourg@icloud.com
 */

using Brotato_Clone.Interfaces;

namespace Brotato_Clone
{
    public class BagAttribute : IAttribute, IOnCratePickup
    {
        [Stat(operation: StatOperation.Add)]
        public readonly int Speed = -1;

        public void OnCratePickup()
        {
            throw new System.NotImplementedException();
        }
    }
}