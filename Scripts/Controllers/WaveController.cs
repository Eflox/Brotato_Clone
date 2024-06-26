/*
 * WaveController.cs
 * Script Author: Charles d'Ansembourg
 * Creation Date: 05/06/2024
 * Contact: c.dansembourg@icloud.com
 */

using Brotato_Clone.Models;
using Brotato_Clone.Views;
using UnityEngine;

namespace Brotato_Clone.Controllers
{
    /// <summary>
    /// Manages the behavior and state of waves in the game, including starting, updating, and ending waves.
    /// </summary>
    public class WaveController : MonoBehaviour
    {
        [SerializeField]
        private WaveView _waveView;

        private float _countdownTimer;
        private bool _waveStarted = false;

        #region Public Methods

        /// <summary>
        /// Initializes the WaveController by subscribing to the GameStart event.
        /// </summary>
        public void Initialize()
        {
            EventManager.Subscribe(GameEvent.GameStart, OnGameStart);
        }

        /// <summary>
        /// Handles the GameStart event, setting up the wave and triggering the WaveStart event.
        /// </summary>
        public void OnGameStart()
        {
            Wave wave = WaveData.Waves[PlayerPrefs.GetInt("Wave")];

            _waveView.SetWaveCount(PlayerPrefs.GetInt("Wave"));

            _countdownTimer = wave.Duration;
            _waveStarted = true;

            EventManager.TriggerEvent(WaveEvent.WaveStart, wave);
        }

        #endregion Public Methods

        #region Private Methods

        /// <summary>
        /// Unsubscribes from the GameStart event when the object is disabled.
        /// </summary>
        private void OnDisable()
        {
            EventManager.Unsubscribe(GameEvent.GameStart, OnGameStart);
        }

        /// <summary>
        /// Updates the wave countdown timer and checks if the wave has ended.
        /// </summary>
        private void Update()
        {
            if (!_waveStarted)
                return;

            if (_countdownTimer > 0)
            {
                _countdownTimer -= Time.deltaTime;
                int timeLeft = Mathf.CeilToInt(_countdownTimer);
                _waveView.SetTimer(timeLeft);
            }
            else
                WaveEnd();
        }

        /// <summary>
        /// Handles the end of the wave, updating the timer and triggering the WaveEnd event.
        /// </summary>
        private void WaveEnd()
        {
            _waveView.SetTimer(0);

            EventManager.TriggerEvent(WaveEvent.WaveEnd);

            _waveStarted = false;
        }

        #endregion Private Methods
    }
}