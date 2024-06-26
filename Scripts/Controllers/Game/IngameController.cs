/*
 * GameController.cs
 * Script Author: Charles d'Ansembourg
 * Creation Date: 06/06/2024
 * Contact: c.dansembourg@icloud.com
 */

using Brotato_Clone.Views;
using UnityEngine;

namespace Brotato_Clone.Controllers
{
    /// <summary>
    /// Controls the main game flow, including initialization, pausing, and scene management.
    /// </summary>
    public class IngameController : MonoBehaviour
    {
        #region Fields

        [SerializeField]
        private PlayerController _playerController;

        [SerializeField]
        private WaveController _waveController;

        [SerializeField]
        private MobsController _mobsController;

        [SerializeField]
        private ShopController _shopController;

        private IngameView _ingameView;
        private IngameMenuController _ingameMenuController;
        private IngameSettingsController _ingameSettingsController;

        #endregion Fields

        #region Public Methods

        /// <summary>
        /// Resumes the game from a paused state.
        /// </summary>
        public void ResumeGame()
        {
            _ingameMenuController.ResumeGame();
        }

        /// <summary>
        /// Restarts the game, reloading the game scene.
        /// </summary>
        public void RestartGame()
        {
            _ingameMenuController.RestartGame();
            PlayerPrefs.SetInt("NewGame", 1);
        }

        /// <summary>
        /// Returns to the main menu scene.
        /// </summary>
        public void ReturnMainMenu()
        {
            _ingameMenuController.ReturnMainMenu();
        }

        /// <summary>
        /// Opens the options menu.
        /// </summary>
        public void OptionsMenu()
        {
            _ingameMenuController.OptionsMenu();
        }

        #endregion Public Methods

        #region Private Methods

        private void Start()
        {
            Initialize();
            StartGame();
        }

        private void Initialize()
        {
            _ingameMenuController = GetComponent<IngameMenuController>();
            _ingameSettingsController = GetComponent<IngameSettingsController>();
            _ingameView = GetComponent<IngameView>();

            _playerController.Initialize();
            _shopController.Initialize();
            _waveController.Initialize();
            _mobsController.Initialize(_playerController.GetPlayerObject().transform);
        }

        private void StartGame()
        {
            _ingameSettingsController.SetSettings();
            _ingameView.Initialize(this);
            _ingameMenuController.Initialize(this);

            if (PlayerPrefs.GetInt("NewGame") == 1)
                EventManager.TriggerEvent(GameEvent.GameNewGame);

            PlayerPrefs.SetInt("NewGame", 0);

            EventManager.TriggerEvent(GameEvent.GameStart);
        }

        private void OnDisable()
        {
            EventManager.ClearEvents();
        }

        #endregion Private Methods
    }
}