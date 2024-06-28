/*
     * SadTomatoAttribute.cs
     * Script Author: Charles d'Ansembourg
     * Creation Date: 27/06/2024
     * Contact: c.dansembourg@icloud.com
     */

using Brotato_Clone.Interfaces;

namespace Brotato_Clone.Models
{
    public class SadTomatoAttribute : IAttribute, IOnWaveStart
    {
        [Stat(operation: StatOperation.Add)]
        public readonly int HPRegen = 8;

        public void OnWaveStart()
        {
            throw new System.NotImplementedException();
        }
    }
}