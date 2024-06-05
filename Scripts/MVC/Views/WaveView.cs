/*
 * WaveView.cs
 * Script Author: Charles d'Ansembourg
 * Creation Date: 05/06/2024
 * Contact: c.dansembourg@icloud.com
 */

using TMPro;
using UnityEngine;

namespace Brotato_Clone.Views
{
    /// <summary>
    ///
    /// </summary>
    public class WaveView : MonoBehaviour
    {
        [SerializeField]
        private TMP_Text _waveCountText;

        [SerializeField]
        private TMP_Text _waveDurationTimer;

        public void SetWaveCount(int wave)
        {
            _waveCountText.text = $"Wave {wave}";
        }

        public void SetTimer(int time)
        {
            _waveDurationTimer.text = $"{time}";
        }
    }
}