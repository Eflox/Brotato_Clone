/*
 * WeaponView.cs
 * Script Author: Charles d'Ansembourg
 * Creation Date: 06/06/2024
 * Contact: c.dansembourg@icloud.com
 */

using Brotato_Clone.Models;
using UnityEngine;

namespace Brotato_Clone.Views
{
    /// <summary>
    /// View controls weapon visuals.
    /// </summary>
    public class WeaponView : MonoBehaviour
    {
        [SerializeField]
        private SpriteRenderer _spriteRenderer;

        [SerializeField]
        private GameObject _hitPrefab;

        [SerializeField]
        private AudioSource _audioSource;

        private bool _playerFacingRight;
        private bool _canFlip = true;

        #region Public Methods

        /// <summary>
        /// Initializes the weapon.
        /// </summary>
        public void Initialize(Weapon weapon)
        {
            _audioSource.clip = weapon.ImpactSound;

            SetSprite(weapon.Sprite);

            EventManager.Subscribe<bool>(PlayerEvent.PlayerFlipPlayer, OnFlipPlayer);
            EventManager.Subscribe<bool>(PlayerEvent.PlayerFlipPlayer, OnFlipPlayer);
        }

        /// <summary>
        /// Status of the target.
        /// </summary>
        public void TargetStatus(bool hasTarget)
        {
            _canFlip = !hasTarget;

            if (hasTarget)
            {
                _spriteRenderer.gameObject.transform.localPosition = new Vector3(0.3f, 0);
                _spriteRenderer.flipX = false;
            }
            else
            {
                OnFlipPlayer(_playerFacingRight);
            }
        }

        /// <summary>
        /// Get called when attack hits.
        /// </summary>
        public void OnHit(Vector2 position)
        {
            Instantiate(_hitPrefab, position, Quaternion.identity);
            PlayRandomizedSound();
        }

        #endregion Public Methods

        #region Private Methods

        private void OnFlipPlayer(bool right)
        {
            _playerFacingRight = right;

            if (!_canFlip)
                return;

            _spriteRenderer.flipX = !right;
            _spriteRenderer.gameObject.transform.localPosition = new Vector3(right ? 0.3f : -0.3f, 0);
        }

        private void SetSprite(Sprite weaponSprite)
        {
            _spriteRenderer.sprite = weaponSprite;
            _spriteRenderer.gameObject.transform.localPosition = new Vector3(0.3f, 0);
        }

        private void PlayRandomizedSound()
        {
            _audioSource.pitch = Random.Range(0.9f, 1.1f);
            //_audioSource.volume = Random.Range(0.8f, 1.0f);
            _audioSource.Play();
        }

        private void OnDisable()
        {
            EventManager.Unsubscribe<bool>(PlayerEvent.PlayerFlipPlayer, OnFlipPlayer);
            EventManager.Unsubscribe<bool>(PlayerEvent.PlayerFlipPlayer, OnFlipPlayer);
        }

        #endregion Private Methods
    }
}