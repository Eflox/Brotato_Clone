/*
 * PlayerCameraController.cs
 * Script Author: Charles d'Ansembourg
 * Creation Date: 29/05/2024
 * Contact: c.dansembourg@icloud.com
 */

using UnityEngine;

namespace Brotato_Clone.Controllers
{
    public class PlayerCameraController : MonoBehaviour
    {
        [SerializeField]
        private Vector2 _boundaries = new Vector2(2.6f, 3.42f);

        private Transform _playerTransform;
        private bool _canFollow = false;

        private void Update()
        {
            if (!_canFollow)
                return;

            Vector3 targetPosition = new Vector3(_playerTransform.position.x, _playerTransform.position.y, Camera.main.transform.position.z);
            float clampedX = Mathf.Clamp(targetPosition.x, -_boundaries.x, _boundaries.x);
            float clampedY = Mathf.Clamp(targetPosition.y, -_boundaries.y, _boundaries.y + 1.5f);
            Camera.main.transform.position = new Vector3(clampedX, clampedY, targetPosition.z);
        }

        public void StartFollow(Transform playerTransform)
        {
            _playerTransform = playerTransform;
            _canFollow = true;
        }

        public void StopFollow()
        {
            _canFollow = false;
        }
    }
}