/*
     * RegenerationPotionAttribute.cs
     * Script Author: Charles d'Ansembourg
     * Creation Date: 27/06/2024
     * Contact: c.dansembourg@icloud.com
     */

using Brotato_Clone.Interfaces;

namespace Brotato_Clone.Models
{
    public class RegenerationPotionAttribute : IAttribute, IOnHPHalf
    {
        [Stat(operation: StatOperation.Add)]
        public readonly int HPRegen = 3;

        public void OnHPHalf(bool under50)
        {
            throw new System.NotImplementedException();
        }
    }
}