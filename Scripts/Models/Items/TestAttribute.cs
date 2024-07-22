/*
 * TestAttribute.cs
 * Script Author: Charles d'Ansembourg
 * Creation Date: 22/07/2024
 * Contact: c.dansembourg@icloud.com
 */

using Brotato_Clone.Interfaces;
using UnityEngine;

namespace Brotato_Clone.Models
{
    public class TestAttribute : IAttribute, IOnTimer1
    {
        public void OnTimer1()
        {
            Debug.Log("Test Attribute Timer Called");
            EventManager.TriggerEvent(PlayerEvent.PlayerHeal, 1);
            EventManager.TriggerEvent(PlayerEvent.PlayerTakeDamage, 1);
        }
    }
}