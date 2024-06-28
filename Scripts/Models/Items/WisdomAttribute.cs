/*
     * WisdomAttribute.cs
     * Script Author: Charles d'Ansembourg
     * Creation Date: 27/06/2024
     * Contact: c.dansembourg@icloud.com
     */

using Brotato_Clone.Interfaces;

namespace Brotato_Clone.Models
{
    public class WisdomAttribute : IAttribute, IOnTimer5
    {
        [Stat(operation: StatOperation.Add)]
        public readonly int Damage = -20;

        public void OnTimer5()
        {
            throw new System.NotImplementedException();
        }
    }
}