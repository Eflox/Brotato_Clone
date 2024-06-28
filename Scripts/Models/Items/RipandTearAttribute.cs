/*
     * RipandTearAttribute.cs
     * Script Author: Charles d'Ansembourg
     * Creation Date: 27/06/2024
     * Contact: c.dansembourg@icloud.com
     */

using Brotato_Clone.Interfaces;

namespace Brotato_Clone.Models
{
    public class RipandTearAttribute : IAttribute, IOnMobDie
    {
        [Stat(operation: StatOperation.Add)]
        public readonly int Harvesting = -12;

        public void OnMobDie()
        {
            throw new System.NotImplementedException();
        }
    }
}