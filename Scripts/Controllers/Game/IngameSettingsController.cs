/*
 * IngameSettingsController.cs
 * Script Author: Charles d'Ansembourg
 * Creation Date: 14/06/2024
 * Contact: c.dansembourg@icloud.com
 */

using UnityEngine;

namespace Brotato_Clone.Controllers
{
    /// <summary>
    /// Controls the in-game settings such as frame rate and vSync.
    /// </summary>
    public class IngameSettingsController : MonoBehaviour
    {
        #region Public Methods

        /// <summary>
        /// Sets the application settings for the game.
        /// </summary>
        public void SetSettings()
        {
            Application.targetFrameRate = 60;

            if (QualitySettings.vSyncCount != 0)
                QualitySettings.vSyncCount = 0;
        }

        #endregion Public Methods
    }
}