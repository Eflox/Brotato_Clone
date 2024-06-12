/*
 * MenuController.cs
 * Script Author: Charles d'Ansembourg
 * Creation Date: 28/05/2024
 * Contact: c.dansembourg@icloud.com
 */

using Brotato_Clone.Services;
using Brotato_Clone.Views;
using UnityEngine;
using UnityEngine.SceneManagement;

namespace Brotato_Clone.Controllers
{
    public class MenuController : MonoBehaviour
    {
        [SerializeField]
        private MenuView _menuView;

        private void Start()
        {
            _menuView.Initialize();
        }

        private void Update()
        {
            if (Input.GetKeyDown(KeyCode.Escape))
                _menuView.OpenMainMenu();
        }

        public void CharacterLoadScene()
        {
            SceneManager.LoadScene("CharacterSelectionScene");
        }

        public void Quit()
        {
            Application.Quit();
        }

        public void MuteAllSounds()
        {
            PlayerPrefsManager.SetKey("SoundVolume", 0);
            PlayerPrefsManager.SetKey("MusicVolume", 0);
        }
    }
}