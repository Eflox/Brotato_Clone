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
    ///
    /// </summary>
    public class WaveController : MonoBehaviour
    {
        [SerializeField]
        private PlayerMovementController _playerMovementController;

        [SerializeField]
        private WeaponsController _weaponsController;

        [SerializeField]
        private MobsController _mobsController;

        [SerializeField]
        private WaveView _waveView;

        private float _countdownTimer;

        private bool _initialized = false;

        public void Initialize(Wave wave)
        {
            _countdownTimer = wave.Duration;
            _waveView.SetWaveCount(wave.Count);

            _mobsController.Initialize(wave);

            _initialized = true;
        }

        private void Update()
        {
            if (!_initialized)
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
            Destroy(_playerMovementController);
            Destroy(_weaponsController);
        }
    }
}