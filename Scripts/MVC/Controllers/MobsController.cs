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

        [SerializeField]
        private GameObject _mobPrefab;

        [SerializeField]
        private PlayerController _playerController;

        public void Initialize(Wave wave)
        {
            _currentWave = wave;
            _initialized = true;
        }

        private void Update()
        {
            if (!_initialized)
                return;

            if (Input.GetKeyDown(KeyCode.Space))
                SpawnMob();
        }

        private void SpawnMob()
        {
            MobController mob = Instantiate(_mobPrefab, new Vector3(5, 5, 0), Quaternion.identity).GetComponent<MobController>();

            mob.Initialize(MobsData.Mobs["BabyAlien"], _playerController.PlayerObject.transform);
        }
    }
}