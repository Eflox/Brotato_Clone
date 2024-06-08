/*
 * GameController.cs
 * Script Author: Charles d'Ansembourg
 * Creation Date: 06/06/2024
 * Contact: c.dansembourg@icloud.com
 */

using Brotato_Clone.Services;
using Brotato_Clone.Views;
using UnityEngine;
using UnityEngine.SceneManagement;

namespace Brotato_Clone.Controllers
{
    public class GameController : MonoBehaviour
    {
        [SerializeField]
        private GameView _gameView;

        [SerializeField]
        private PlayerController _playerController;

        private PlayerPrefsService _playerPrefsService;

        private bool _paused = false;

        private void Awake()
        {
            _playerPrefsService = new PlayerPrefsService();

            Application.targetFrameRate = 60;

            if (QualitySettings.vSyncCount != 0)
                QualitySettings.vSyncCount = 0;
        }

        private void Start()
        {
            _gameView.Initialize();
        }

        private void Update()
        {
            if (Input.GetKeyDown(KeyCode.Escape))
            {
                TogglePause();
            }
        }

        private void TogglePause()
        {
            _paused = !_paused;
            _gameView.TogglePauseMenu(_paused);
            Time.timeScale = _paused ? 0 : 1;
        }

        public void ResumeGame()
        {
            TogglePause();
        }

        public void RestartGame()
        {
            TogglePause();
            _playerPrefsService.NewSave(_playerController.Character);
            SceneManager.LoadScene("GameScene");
        }

        public void OptionsMenu()
        {
        }

        public void ReturnMainMenu()
        {
            TogglePause();
            SceneManager.LoadScene("MenuScene");
        }
    }
}