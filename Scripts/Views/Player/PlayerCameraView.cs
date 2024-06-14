/*
 * PlayerCameraView.cs
 * Script Author: Charles d'Ansembourg
 * Creation Date: 11/06/2024
 * Contact: c.dansembourg@icloud.com
 */

using System.Collections;
using UnityEngine;

namespace Brotato_Clone.Player.Views
{
    /// <summary>
    /// Manages the player camera effects.
    /// </summary>
    public class PlayerCameraView : MonoBehaviour
    {
        #region Fields

        [SerializeField]
        private Camera _camera;

        private Vector3 _originalPosition;
        private Coroutine _shakeCoroutine;

        #endregion Fields

        #region Public Methods

        /// <summary>
        /// Initializes the player camera view by subscribing to relevant events.
        /// </summary>
        public void Initialize()
        {
            EventManager.Subscribe(PlayerEvent.PlayerTakeDamage, OnDealOrTakeDamage);
            EventManager.Subscribe(PlayerEvent.PlayerDealDamage, OnDealOrTakeDamage);
        }

        #endregion Public Methods

        #region Private Methods

        private void OnDealOrTakeDamage()
        {
            if (_shakeCoroutine != null)
                StopCoroutine(_shakeCoroutine);

            _originalPosition = _camera.transform.localPosition;
            _shakeCoroutine = StartCoroutine(ShakeCamera(0.06f, 0.1f));
        }

        private IEnumerator ShakeCamera(float duration, float magnitude)
        {
            float elapsed = 0.0f;

            while (elapsed < duration)
            {
                float offsetX = Random.Range(-1f, 1f) * magnitude;
                float offsetY = Random.Range(-1f, 1f) * magnitude;

                _camera.transform.localPosition = new Vector3(_originalPosition.x + offsetX, _originalPosition.y + offsetY, _originalPosition.z);

                elapsed += Time.deltaTime;

                yield return null;
            }

            _camera.transform.localPosition = _originalPosition;
            _shakeCoroutine = null;
        }

        #endregion Private Methods
    }
}