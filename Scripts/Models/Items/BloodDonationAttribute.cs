/*
     * BloodDonationAttribute.cs
     * Script Author: Charles d'Ansembourg
     * Creation Date: 27/06/2024
     * Contact: c.dansembourg@icloud.com
     */

using Brotato_Clone.Interfaces;

namespace Brotato_Clone.Models
{
    public class BloodDonationAttribute : IAttribute, IOnTimer1
    {
        [Stat(operation: StatOperation.Add)]
        public readonly int Harvesting = 40;

        public void OnTimer1()
        {
            throw new System.NotImplementedException();
        }
    }
}