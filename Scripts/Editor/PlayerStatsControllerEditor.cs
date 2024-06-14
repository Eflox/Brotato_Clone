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
    /// <summary>
    /// Manages the particle effects for the player, such as spawning dust particles when the player moves.
    /// </summary>
    public class PlayerParticlesView : MonoBehaviour
    {
        #region Fields

        [SerializeField]
        private GameObject _dustParticlePrefab;

        [SerializeField]
        private Transform _playerTransform;

        private bool _spawnParticles = false;
        private float _dustSpawnInterval = 0.1f;
        private Coroutine _dustSpawnCoroutine;

        #endregion Fields

        #region Public Methods

        /// <summary>
        /// Initializes the player particles view by subscribing to the player movement change event.
        /// </summary>
        public void Initialize()
        {
            EventManager.Subscribe<bool>(PlayerEvent.PlayerMoveChange, OnPlayerMoveChange);
        }

        #endregion Public Methods

        #region Private Methods

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
                yield return new WaitForSeconds(_dustSpawnInterval);
            }
        }

        #endregion Private Methods
    }
}