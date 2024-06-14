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
    /// <summary>
    /// Controls the player's movement and handles input for movement directions.
    /// </summary>
    public class PlayerMovementController : MonoBehaviour
    {
        #region Fields

        [SerializeField]
        private PlayerView _playerView;

        private Transform _playerTransform;
        private int _playerSpeed;

        private const float BaseHiddenSpeed = 5f;
        private const float PercentageBaseSpeed = 100f;

        private bool _canMove = true;
        private bool _isMoving = false;
        private bool _facingRight = true;

        private Vector2 _bounds = new Vector2(13f, 8.5f);
        private Vector3 _movement = Vector3.zero;

        #endregion Fields

        #region Public Methods

        /// <summary>
        /// Subscribes to needed events.
        /// </summary>
        public void Initialize()
        {
            EventManager.Subscribe<bool>(GameEvent.GamePaused, OnGamePause);
        }

        /// <summary>
        /// Starts the player movement with the specified speed and transform.
        /// </summary>
        public void StartMovement(int playerSpeed, Transform playerTransform)
        {
            _playerSpeed = playerSpeed;
            _playerTransform = playerTransform;
            _canMove = true;
        }

        /// <summary>
        /// Updates the player's movement speed.
        /// </summary>
        public void UpdateSpeed(int playerSpeed)
        {
            _playerSpeed = playerSpeed;
        }

        /// <summary>
        /// Stops the player movement.
        /// </summary>
        public void StopMovement()
        {
            _canMove = false;
        }

        #endregion Public Methods

        #region Private Methods

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
                EventManager.TriggerEvent(PlayerEvent.PlayerMoveChange, true);
                _isMoving = true;
            }
            else if (!isCurrentlyMoving && _isMoving)
            {
                EventManager.TriggerEvent(PlayerEvent.PlayerMoveChange, false);
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
                EventManager.TriggerEvent(PlayerEvent.PlayerFlipPlayer, _facingRight);
        }

        private void OnGamePause(bool paused)
        {
            _canMove = !paused;
        }

        #endregion Private Methods
    }
}