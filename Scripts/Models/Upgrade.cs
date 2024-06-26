/*
 * Upgrade.cs
 * Script Author: Charles d'Ansembourg
 * Creation Date: 10/06/2024
 * Contact: c.dansembourg@icloud.com
 */

using System;

namespace Brotato_Clone.Models
{
    [Serializable]
    public class Upgrade : Item
    {
        public void SelectUpgrade() => EventManager.TriggerEvent(PlayerEvent.PlayerSelectUpgrade, this);
    }
}