/*
     * WeirdGhostAttribute.cs
     * Script Author: Charles d'Ansembourg
     * Creation Date: 27/06/2024
     * Contact: c.dansembourg@icloud.com
     */

using Brotato_Clone.Interfaces;

namespace Brotato_Clone.Models
{
    public class WeirdGhostAttribute : IAttribute, IOnWaveStart
    {
        [Stat(operation: StatOperation.Add)]
        public readonly int MaxHP = 3;

        public void OnWaveStart()
        {
            throw new System.NotImplementedException();
        }
    }
}