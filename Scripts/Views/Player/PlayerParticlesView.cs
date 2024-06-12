/*
 * PlayerParticlesView.cs
 * Script Author: Charles d'Ansembourg
 * Creation Date: 11/06/2024
 * Contact: c.dansembourg@icloud.com
 */

using System.Collections;
using UnityEngine;

namespace Brotato_Clone.Player.Views
{
    public class PlayerParticlesView : MonoBehaviour
    {
        [SerializeField]
        private GameObject _dustParticlePrefab;

        [SerializeField]
        private Transform _playerTransform;

        private bool _spawnParticles = false;
        private float dustSpawnInterval = 0.1f;
        private Coroutine _dustSpawnCoroutine;

        public void Initialize()
        {
            EventManager.Subscribe<bool>(PlayerEvent.PlayerMoveChange, OnPlayerMoveChange);
        }

        private void OnPlayerMoveChange(bool isMoving)
        {
            if (isMoving)
            {
                _spawnParticles = true;
                _dustSpawnCoroutine = StartCoroutine(SpawnDustParticles());
            }
            else
            {
                _spawnParticles = false;

                if (_dustSpawnCoroutine != null)
                    StopCoroutine(_dustSpawnCoroutine);
            }
        }

        private IEnumerator SpawnDustParticles()
        {
            while (_spawnParticles)
            {
                Instantiate(_dustParticlePrefab, _playerTransform.position - new Vector3(0, 0.35f), Quaternion.identity);
                yield return new WaitForSeconds(dustSpawnInterval);
            }
        }
    }
}