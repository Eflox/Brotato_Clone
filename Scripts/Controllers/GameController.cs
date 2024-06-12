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

        [SerializeField]
        private WaveController _waveController;

        [SerializeField]
        private MobsController _mobsController;

        private bool _paused = false;

        private void Awake()
        {
            Application.targetFrameRate = 60;

            if (QualitySettings.vSyncCount != 0)
                QualitySettings.vSyncCount = 0;
        }

        private void Start()
        {
            _playerController.Initialize();
            _waveController.Initialize();
            _mobsController.Initialize(_playerController.GetPlayerObject().transform);

            _gameView.Initialize();

            EventManager.TriggerEvent(GameEvent.GameStart);
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
            PlayerPrefsManager.NewSave(_playerController.Character);
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