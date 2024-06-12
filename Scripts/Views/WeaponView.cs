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
    public class WeaponView : MonoBehaviour
    {
        [SerializeField]
        private SpriteRenderer _spriteRenderer;

        [SerializeField]
        private GameObject _hitPrefab;

        [SerializeField]
        private AudioSource _audioSource;

        private bool _playerFacingRight;

        public void Initialize(Weapon weapon)
        {
            _audioSource.clip = weapon.ImpactSound;

            SetSprite(weapon.Sprite);

            EventManager.Subscribe<bool>(PlayerEvent.PlayerFlipPlayer, OnFlipPlayer);
            EventManager.Subscribe<bool>(PlayerEvent.PlayerFlipPlayer, OnFlipPlayer);
        }

        private void OnFlipPlayer(bool right)
        {
            _playerFacingRight = right;

            _spriteRenderer.flipX = !right;
            _spriteRenderer.gameObject.transform.localPosition = new Vector3(right ? 0.3f : -0.3f, 0);
        }

        private void SetSprite(Sprite weaponSprite)
        {
            _spriteRenderer.sprite = weaponSprite;
            _spriteRenderer.gameObject.transform.localPosition = new Vector3(0.3f, 0);
        }

        public void ResetFlip()
        {
            _spriteRenderer.gameObject.transform.localPosition = new Vector3(0.3f, 0);
            _spriteRenderer.flipX = false;
        }

        public void OnHit(Vector2 position)
        {
            Instantiate(_hitPrefab, position, Quaternion.identity);
            PlayRandomizedSound();
        }

        private void PlayRandomizedSound()
        {
            _audioSource.pitch = Random.Range(0.9f, 1.1f);
            //_audioSource.volume = Random.Range(0.8f, 1.0f);
            _audioSource.Play();
        }
    }
}