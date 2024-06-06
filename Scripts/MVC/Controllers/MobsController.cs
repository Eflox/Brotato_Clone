/*
 * MobsController.cs
 * Script Author: Charles d'Ansembourg
 * Creation Date: 05/06/2024
 * Contact: c.dansembourg@icloud.com
 */

using Brotato_Clone.Models;
using System.Collections;
using UnityEngine;

namespace Brotato_Clone.Controllers
{
    public class MobsController : MonoBehaviour
    {
        private Wave _currentWave;

        [SerializeField]
        private GameObject _mobPrefab;

        [SerializeField]
        private PlayerController _playerController;

        public void Initialize(Wave wave)
        {
            _currentWave = wave;

            StartWave();
        }

        private void StartWave()
        {
            StartCoroutine(SpawnMobsRoutine());
        }

        private IEnumerator SpawnMobsRoutine()
        {
            float spawnInterval = (float)_currentWave.Duration / _currentWave.EnemyCount;
            float elapsedTime = 0f;

            for (int i = 0; i < _currentWave.EnemyCount; i++)
            {
                SpawnMob();

                float randomFactor = Random.Range(0.8f, 1.2f);
                yield return new WaitForSeconds(spawnInterval * randomFactor);

                elapsedTime += spawnInterval * randomFactor;
                if (elapsedTime >= _currentWave.Duration)
                    break;
            }
        }

        private void SpawnMob()
        {
            Vector3 spawnPosition = GetRandomSpawnPosition();
            MobController mob = Instantiate(_mobPrefab, spawnPosition, Quaternion.identity).GetComponent<MobController>();
            mob.Initialize(MobsData.Mobs["BabyAlien"], _playerController.PlayerObject.transform);
        }

        private Vector3 GetRandomSpawnPosition()
        {
            float x = Random.Range(-10f, 10f);
            float y = Random.Range(-10f, 10f);
            return new Vector3(x, y, 0);
        }
    }
}