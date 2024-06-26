/*
 * BabyWithABeardAttribute.cs
 * Script Author: Charles d'Ansembourg
 * Creation Date: 26/06/2024
 * Contact: c.dansembourg@icloud.com
 */

using Brotato_Clone.Interfaces;

namespace Brotato_Clone.Models
{
    public class BabyWithABeardAttribute : IAttribute, IOnMobDie
    {
        [Stat(operation: StatOperation.Add)]
        public readonly int Range = -50;

        public void OnMobDie()
        {
            throw new System.NotImplementedException();
        }
    }
}