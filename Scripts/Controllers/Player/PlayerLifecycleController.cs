/*
 * PlayerLifecycleController.cs
 * Script Author: Charles d'Ansembourg
 * Creation Date: 29/05/2024
 * Contact: c.dansembourg@icloud.com
 */

using UnityEngine;

namespace Brotato_Clone.Controllers
{
    /// <summary>
    /// Handles player lifecycle.
    /// </summary>
    public class PlayerLifecycleController : MonoBehaviour
    {
        #region Public Methods

        /// <summary>
        /// Kills the player
        /// </summary>
        public void KillPlayer()
        {
            EventManager.TriggerEvent(PlayerEvent.PlayerDead);
        }

        #endregion Public Methods
    }
}