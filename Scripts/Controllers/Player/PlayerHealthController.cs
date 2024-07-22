/*
 * PlayerHealthController.cs
 * Script Author: Charles d'Ansembourg
 * Creation Date: 11/06/2024
 * Contact: c.dansembourg@icloud.com
 */

using UnityEngine;

namespace Brotato_Clone.Controllers
{
    /// <summary>
    /// Controls the player's health, including setting and updating the maximum health points.
    /// </summary>
    public class PlayerHealthController : MonoBehaviour
    {
        #region Public Methods

        public void Initialize()
        {
            EventManager.Subscribe<int>(PlayerEvent.PlayerTakeDamage, OnTakeDamage);
        }

        #endregion Public Methods

        #region Private Methods

        private void OnTakeDamage(int damage)
        {
        }

        #endregion Private Methods
    }
}