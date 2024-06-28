/*
     * PocketFactoryAttribute.cs
     * Script Author: Charles d'Ansembourg
     * Creation Date: 27/06/2024
     * Contact: c.dansembourg@icloud.com
     */

using Brotato_Clone.Interfaces;

namespace Brotato_Clone.Models
{
    public class PocketFactoryAttribute : IAttribute, IOnTreeDie
    {
        [Stat(operation: StatOperation.Add)]
        public readonly int Engineering = 2;

        public void OnTreeDie()
        {
            throw new System.NotImplementedException();
        }
    }
}