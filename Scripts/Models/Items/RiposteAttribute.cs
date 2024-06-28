/*
     * RiposteAttribute.cs
     * Script Author: Charles d'Ansembourg
     * Creation Date: 27/06/2024
     * Contact: c.dansembourg@icloud.com
     */

using Brotato_Clone.Interfaces;

namespace Brotato_Clone.Models
{
    public class RiposteAttribute : IAttribute, IOnDodge
    {
        [Stat(operation: StatOperation.Add)]
        public readonly int MeleeDmg = 2;

        public void OnDodge()
        {
            throw new System.NotImplementedException();
        }
    }
}