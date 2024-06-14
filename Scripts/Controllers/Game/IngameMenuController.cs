/*
 * IngameMenuController.cs
 * Script Author: Charles d'Ansembourg
 * Creation Date: 14/06/2024
 * Contact: c.dansembourg@icloud.com
 */

using UnityEngine;
using UnityEngine.SceneManagement;

namespace Brotato_Clone.Controllers
{
    /// <summary>
    /// Controls the in-game menu, including pausing, resuming, restarting, and navigating to the main menu.
    /// </summary>
    public class IngameMenuController : MonoBehaviour
    {
        #region Fields

        private IngameController _ingameController;
        private bool _paused = false;

        #endregion Fields

        #region Public Methods

        /// <summary>
        /// Initializes the in-game menu controller with the given in-game controller.
        /// </summary>
        public void Initialize(IngameController ingameController)
        {
            _ingameController = ingameController;
        }

        /// <summary>
        /// Resumes the game from a paused state.
        /// </summary>
        public void ResumeGame()
        {
            TogglePause();
        }

        /// <summary>
        /// Restarts the game, reloading the game scene.
        /// </summary>
        public void RestartGame()
        {
            TogglePause();
            SaveManager.SaveCharacter(SaveManager.GetCharacter());
            SceneManager.LoadScene("GameScene");
        }

        /// <summary>
        /// Opens the options menu.
        /// </summary>
        public void OptionsMenu()
        {
            // Implementation for options menu
        }

        /// <summary>
        /// Returns to the main menu scene.
        /// </summary>
        public void ReturnMainMenu()
        {
            TogglePause();
            SceneManager.LoadScene("MenuScene");
        }

        #endregion Public Methods

        #region Private Methods

        private void Update()
        {
            if (Input.GetKeyDown(KeyCode.Escape))
                TogglePause();
        }

        private void TogglePause()
        {
            _paused = !_paused;
            Time.timeScale = _paused ? 0 : 1;

            EventManager.TriggerEvent(GameEvent.GamePaused, _paused);
        }

        #endregion Private Methods
    }
}