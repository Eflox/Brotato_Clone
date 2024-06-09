/*
 * MobsController.cs
 * Script Author: Charles d'Ansembourg
 * Creation Date: 05/06/2024
 * Contact: c.dansembourg@icloud.com
 */

using Brotato_Clone.Models;
using DamageNumbersPro;
using System.Collections;
using System.Collections.Generic;
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

        [SerializeField]
        private Vector2 _boundaries;

        [SerializeField]
        private List<MobController> _mobControllers = new List<MobController>();

        [SerializeField]
        private DamageNumber _damageNumber;

        public void Initialize(Wave wave)
        {
            _currentWave = wave;

            StartWave();
        }

        public void EndWave()
        {
            foreach (var mobController in _mobControllers)
            {
                mobController.Die(Vector2.zero);
            }
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
            MobController mobController = Instantiate(_mobPrefab, spawnPosition, Quaternion.identity).GetComponent<MobController>();
            mobController.Initialize(MobsData.Mobs["BabyAlien"], _playerController.PlayerObject.transform, _damageNumber);
            _mobControllers.Add(mobController);
        }

        private Vector3 GetRandomSpawnPosition()
        {
            float y = Random.Range(-_boundaries.y, _boundaries.y);
            float x = Random.Range(-_boundaries.x, _boundaries.x);
            return new Vector3(x, y, 0);
        }
    }
}