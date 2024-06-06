/*
 * MobsController.cs
 * Script Author: Charles d'Ansembourg
 * Creation Date: 05/06/2024
 * Contact: c.dansembourg@icloud.com
 */

using Brotato_Clone.Models;
using UnityEngine;

namespace Brotato_Clone.Controllers
{
    public class MobsController : MonoBehaviour
    {
        private Wave _currentWave;
        private bool _initialized = false;

        public void Initialize(Wave wave)
        {
            _currentWave = wave;
            _initialized = true;
        }

        private void Update()
        {
            if (!_initialized)
                return;
        }

        private void SpawnMob()
        {
        }
    }
}