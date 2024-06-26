/*
 * AdrenalineAttribute.cs
 * Script Author: Charles d'Ansembourg
 * Creation Date: 26/06/2024
 * Contact: c.dansembourg@icloud.com
 */

using Brotato_Clone.Interfaces;

namespace Brotato_Clone.Models
{
    public class AdrenalineAttribute : IAttribute, IOnDodge
    {
        [Stat(operation: StatOperation.Add)]
        public readonly int Dodge = 5;

        public void OnDodge()
        {
            EventManager.TriggerEvent(PlayerEvent.PlayerHeal, 5);
            throw new System.NotImplementedException();
        }
    }
}