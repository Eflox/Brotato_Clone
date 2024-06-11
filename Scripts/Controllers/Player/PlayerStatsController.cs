/*
 * PlayerStatsController.cs
 * Script Author: Charles d'Ansembourg
 * Creation Date: 11/06/2024
 * Contact: c.dansembourg@icloud.com
 */

using UnityEngine;

namespace Brotato_Clone
{
    public class PlayerStatsController : MonoBehaviour
    {
        public void UpdateStats()
        {
            EventManager.TriggerEvent(PlayerEvent.PlayerStatsChanged);
        }
    }
}