/*
     * CuteMonkeyAttribute.cs
     * Script Author: Charles d'Ansembourg
     * Creation Date: 27/06/2024
     * Contact: c.dansembourg@icloud.com
     */

using Brotato_Clone.Interfaces;

namespace Brotato_Clone.Models
{
    public class CuteMonkeyAttribute : IAttribute, IOnMaterialPickup
    {
        [Stat(operation: StatOperation.Add)]
        public readonly int RangedDmg = -1;

        public void OnMaterialPickup()
        {
            throw new System.NotImplementedException();
        }
    }
}