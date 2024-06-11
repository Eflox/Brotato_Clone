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

        [SerializeField]
        private Camera _camera;

        private Transform _player;
        private bool _initialized = false;

        public void Initialize(Transform playerObject)
        {
            _player = playerObject;
            _initialized = true;
        }

        private void Update()
        {
            if (!_initialized)
                return;

            Vector3 targetPosition = new Vector3(_player.position.x, _player.position.y, _camera.transform.position.z);
            float clampedX = Mathf.Clamp(targetPosition.x, -_boundaries.x, _boundaries.x);
            float clampedY = Mathf.Clamp(targetPosition.y, -_boundaries.y, _boundaries.y + 1.5f);
            _camera.transform.position = new Vector3(clampedX, clampedY, targetPosition.z);
        }

        public void StartFollow()
        {
        }

        public void StopFollow()
        {
        }
    }
}