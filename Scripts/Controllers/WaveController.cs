/*
 * WaveController.cs
 * Script Author: Charles d'Ansembourg
 * Creation Date: 05/06/2024
 * Contact: c.dansembourg@icloud.com
 */

using Brotato_Clone.Models;
using Brotato_Clone.Services;
using Brotato_Clone.Views;
using UnityEngine;

namespace Brotato_Clone.Controllers
{
    /// <summary>
    ///
    /// </summary>
    public class WaveController : MonoBehaviour
    {
        [SerializeField]
        private WaveView _waveView;

        private float _countdownTimer;

        private bool _waveStarted = false;

        public void Initialize()
        {
            EventManager.Subscribe(GameEvent.GameStart, OnGameStart);
        }

        public void OnGameStart()
        {
            Wave wave = WaveData.Waves[PlayerPrefsManager.GetStat("Wave")];

            _waveView.SetWaveCount(wave.Count);

            _countdownTimer = wave.Duration;
            _waveStarted = true;

            EventManager.TriggerEvent(WaveEvent.WaveStart, wave);
        }

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

        private void WaveEnd()
        {
            _waveView.SetTimer(0);

            EventManager.TriggerEvent(WaveEvent.WaveStart);

            _waveStarted = false;
        }
    }
}