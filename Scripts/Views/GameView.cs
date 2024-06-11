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
    public class GameView : MonoBehaviour
    {
        [SerializeField]
        private GameController _gameController;

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

        public void Initialize()
        {
            _resumeButton.onClick.AddListener(_gameController.ResumeGame);

            _restartButton.onClick.AddListener(OpenRestartConfirmationMenu);
            _restartYesButton.onClick.AddListener(_gameController.RestartGame);
            _restartNoButton.onClick.AddListener(CloseRestartConfirmationMenu);

            _mainMenuButton.onClick.AddListener(OpenMainMenuConfirmationMenu);
            _mainMenuYesButton.onClick.AddListener(_gameController.ReturnMainMenu);
            _mainMenuNoButton.onClick.AddListener(CloseMainMenuConfirmationMenu);

            _optionsButton.onClick.AddListener(_gameController.OptionsMenu);
        }

        public void TogglePauseMenu(bool open)
        {
            CloseRestartConfirmationMenu();
            CloseMainMenuConfirmationMenu();
            _pauseMenuBackground.SetActive(open);
            _pauseMenu.SetActive(open);
        }

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
    }
}