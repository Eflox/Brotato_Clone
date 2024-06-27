/*
 * GameView.cs
 * Script Author: Charles d'Ansembourg
 * Creation Date: 07/06/2024
 * Contact: c.dansembourg@icloud.com
 */

using Brotato_Clone.Controllers;
using UnityEngine;
using UnityEngine.UI;

namespace Brotato_Clone.Views
{
    /// <summary>
    /// Manages the in-game UI, including the pause menu and confirmation dialogs.
    /// </summary>
    public class IngameView : MonoBehaviour
    {
        #region Fields

        [SerializeField]
        private GameObject _pauseMenuBackground;

        [SerializeField]
        private GameObject _pauseMenu;

        [SerializeField]
        private GameObject _restartConfirmation;

        [SerializeField]
        private GameObject _returnMainMenuConfirmation;

        [SerializeField]
        private Button _resumeButton;

        [SerializeField]
        private Button _restartButton;

        [SerializeField]
        private Button _optionsButton;

        [SerializeField]
        private Button _mainMenuButton;

        [SerializeField]
        private Button _restartYesButton;

        [SerializeField]
        private Button _restartNoButton;

        [SerializeField]
        private Button _mainMenuYesButton;

        [SerializeField]
        private Button _mainMenuNoButton;

        [SerializeField]
        private GameObject _playerInventory;

        private IngameController _ingameController;

        #endregion Fields

        #region Public Methods

        /// <summary>
        /// Initializes the in-game view with the given in-game controller.
        /// </summary>
        public void Initialize(IngameController ingameController)
        {
            _ingameController = ingameController;
            _resumeButton.onClick.AddListener(_ingameController.ResumeGame);
            _restartButton.onClick.AddListener(OpenRestartConfirmationMenu);
            _restartYesButton.onClick.AddListener(_ingameController.RestartGame);
            _restartNoButton.onClick.AddListener(CloseRestartConfirmationMenu);
            _mainMenuButton.onClick.AddListener(OpenMainMenuConfirmationMenu);
            _mainMenuYesButton.onClick.AddListener(_ingameController.ReturnMainMenu);
            _mainMenuNoButton.onClick.AddListener(CloseMainMenuConfirmationMenu);
            _optionsButton.onClick.AddListener(_ingameController.OptionsMenu);

            EventManager.Subscribe<bool>(GameEvent.GamePaused, OnGamePause);
        }

        /// <summary>
        /// Handles the game pause event by toggling the pause menu.
        /// </summary>
        public void OnGamePause(bool open)
        {
            CloseRestartConfirmationMenu();
            CloseMainMenuConfirmationMenu();
            _pauseMenuBackground.SetActive(open);
            _pauseMenu.SetActive(open);
            _playerInventory.SetActive(open);
        }

        #endregion Public Methods

        #region Private Methods

        private void OpenRestartConfirmationMenu()
        {
            _pauseMenu.SetActive(false);
            _restartConfirmation.SetActive(true);
        }

        private void CloseRestartConfirmationMenu()
        {
            _pauseMenu.SetActive(true);
            _restartConfirmation.SetActive(false);
        }

        private void OpenMainMenuConfirmationMenu()
        {
            _pauseMenu.SetActive(false);
            _returnMainMenuConfirmation.SetActive(true);
        }

        private void CloseMainMenuConfirmationMenu()
        {
            _pauseMenu.SetActive(true);
            _returnMainMenuConfirmation.SetActive(false);
        }

        #endregion Private Methods
    }
}