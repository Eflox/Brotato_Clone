/*
 * MenuView.cs
 * Script Author: Charles d'Ansembourg
 * Creation Date: 07/06/2024
 * Contact: c.dansembourg@icloud.com
 */

using Brotato_Clone.Controllers;
using UnityEngine;
using UnityEngine.UI;

namespace Brotato_Clone.Views
{
    public class MenuView : MonoBehaviour
    {
        [SerializeField]
        private MenuController _menuController;

        [SerializeField]
        private Button _startButton;

        [SerializeField]
        private Button _optionsButton;

        [SerializeField]
        private Button _backButton;

        [SerializeField]
        private Image _logo;

        [SerializeField]
        private GameObject _mainMenu;

        [SerializeField]
        private GameObject _subMenus;

        [SerializeField]
        private GameObject _optionsMenu;

        [SerializeField]
        private Button _quitButton;

        [SerializeField]
        private Button _muteButton;

        public void Initialize()
        {
            _startButton.onClick.AddListener(_menuController.CharacterLoadScene);
            _optionsButton.onClick.AddListener(OpenOptionsMenu);
            _backButton.onClick.AddListener(OpenMainMenu);
            _quitButton.onClick.AddListener(_menuController.Quit);
            _muteButton.onClick.AddListener(_menuController.MuteAllSounds);
        }

        public void OpenOptionsMenu()
        {
            _logo.enabled = false;
            _mainMenu.SetActive(false);
            _subMenus.SetActive(true);
            _optionsMenu.SetActive(true);
        }

        public void OpenMainMenu()
        {
            _logo.enabled = true;
            _mainMenu.SetActive(true);
            _subMenus.SetActive(false);
            _optionsMenu.SetActive(false);
        }
    }
}