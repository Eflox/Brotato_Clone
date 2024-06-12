/*
 * MobsController.cs
 * Script Author: Charles d'Ansembourg
 * Creation Date: 05/06/2024
 * Contact: c.dansembourg@icloud.com
 */

using Brotato_Clone.Models;
using DamageNumbersPro;
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
        private Vector2 _boundaries;

        [SerializeField]
        private DamageNumber _damageNumber;

        private Transform _targetTransform;

        public void Initialize(Transform targetTransform)
        {
            _targetTransform = targetTransform;

            EventManager.Subscribe<Wave>(WaveEvent.WaveStart, OnWaveStart);
            EventManager.Subscribe(WaveEvent.WaveEnd, OnWaveEnd);
        }

        private void OnWaveStart(Wave wave)
        {
            _currentWave = wave;

            StartCoroutine(SpawnMobsRoutine());
        }

        private void OnWaveEnd()
        {
            foreach (var mob in GameObject.FindGameObjectsWithTag("Mob"))
                mob.GetComponent<MobController>().Die(Vector2.zero, false);
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
            mobController.Initialize(MobsData.Mobs["BabyAlien"], _targetTransform, _damageNumber, this);
        }

        private Vector3 GetRandomSpawnPosition()
        {
            float y = Random.Range(-_boundaries.y, _boundaries.y);
            float x = Random.Range(-_boundaries.x, _boundaries.x);
            return new Vector3(x, y, 0);
        }
    }
}