/*
 * WaveController.cs
 * Script Author: Charles d'Ansembourg
 * Creation Date: 05/06/2024
 * Contact: c.dansembourg@icloud.com
 */

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
        private WaveView _waveView;

        private float _countdownTime = 30f;

        private void Update()
        {
            if (_countdownTime > 0)
            {
                _countdownTime -= Time.deltaTime;
                int timeLeft = Mathf.CeilToInt(_countdownTime);
                _waveView.SetTimer(timeLeft);
            }
            else
                WaveEnd();
        }

        private void WaveEnd()
        {
            _waveView.SetTimer(0);
            Destroy(_playerMovementController);
        }
    }
}