/*
 * PlayerMovementController.cs
 * Script Author: Charles d'Ansembourg
 * Creation Date: 05/06/2024
 * Contact: c.dansembourg@icloud.com
 */

using Brotato_Clone.Player.Views;
using UnityEngine;

namespace Brotato_Clone.Controllers
{
    public class PlayerMovementController : MonoBehaviour
    {
        [SerializeField]
        private PlayerView _playerView;

        private Transform _playerTransform;
        private int _playerSpeed;

        private const float BaseHiddenSpeed = 5f;
        private const float PercentageBaseSpeed = 100f;

        private bool _canMove = false;
        private bool _isMoving = false;
        private bool _facingRight = true;

        public Vector2 _bounds = new Vector2(10f, 10f);

        private Vector3 _movement = Vector3.zero;

        public void StartMovement(int playerSpeed, Transform playerTransform)
        {
            _playerSpeed = playerSpeed;
            _playerTransform = playerTransform;
            _canMove = true;
        }

        public void UpdateSpeed(int playerSpeed)
        {
            _playerSpeed = playerSpeed;
        }

        public void StopMovement()
        {
            _canMove = false;
        }

        private void Update()
        {
            if (!_canMove)
                return;

            _movement = Vector3.zero;

            if (Input.GetKey(KeyCode.W))
                _movement.y += 1;
            if (Input.GetKey(KeyCode.S))
                _movement.y -= 1;
            if (Input.GetKey(KeyCode.A))
                _movement.x -= 1;
            if (Input.GetKey(KeyCode.D))
                _movement.x += 1;

            _movement.Normalize();

            bool isCurrentlyMoving = _movement != Vector3.zero;
            float percentageIncrease = _playerSpeed / PercentageBaseSpeed;
            float newSpeed = BaseHiddenSpeed * (1 + percentageIncrease);

            Vector3 newPosition = _playerTransform.position + _movement * newSpeed * Time.deltaTime;

            newPosition.x = Mathf.Clamp(newPosition.x, -_bounds.x, _bounds.x);
            newPosition.y = Mathf.Clamp(newPosition.y, -_bounds.y, _bounds.y);

            _playerTransform.position = newPosition;

            CheckDirection();

            if (isCurrentlyMoving && !_isMoving)
            {
                EventManager.TriggerEvent(PlayerEvent.PlayerMoving);
                _isMoving = true;
            }
            else if (!isCurrentlyMoving && _isMoving)
            {
                EventManager.TriggerEvent(PlayerEvent.PlayerIdle);
                _isMoving = false;
            }
        }

        private void CheckDirection()
        {
            bool flipDirection = false;

            if (_movement.x > 0 && !_facingRight)
            {
                _facingRight = true;
                flipDirection = true;
            }
            else if (_movement.x < 0 && _facingRight)
            {
                _facingRight = false;
                flipDirection = true;
            }

            if (flipDirection)
            {
                _playerView.FlipPlayer();
                EventManager.TriggerEvent(PlayerEvent.PlayerFlipPlayer, _facingRight);
            }
        }
    }
}