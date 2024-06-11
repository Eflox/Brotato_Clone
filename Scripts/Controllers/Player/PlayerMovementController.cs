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
        private PlayerController _playerController;

        [SerializeField]
        private PlayerAllWeaponsController _weaponsController;

        [SerializeField]
        private PlayerView _playerView;

        private float baseHiddenSpeed = 5f;
        private float percentageBaseSpeed = 100f;

        private bool _initialized = false;

        public Vector2 _bounds = new Vector2(10f, 10f);

        private bool _isMoving = false;

        private bool _facingRight = true;

        private Vector3 _movement = Vector3.zero;

        public void StartMovement()
        {
        }

        public void StopMovement()
        {
        }

        public void Initialize()
        {
            _playerController.PlayerObject.transform.position = Vector3.zero;

            _playerView.SetupBounceAnimation();
            _initialized = true;
        }

        private void Update()
        {
            if (!_initialized)
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

            //if (isCurrentlyMoving)
            //    _playerView.SetPlayerMoving(_facingRight);
            //else
            //    _playerView.SetPlayerIdle();

            float percentageIncrease = _playerController.Stats.Speed[Models.StatType.TotalVisible] / percentageBaseSpeed;
            float newSpeed = baseHiddenSpeed * (1 + percentageIncrease);

            Vector3 newPosition = _playerController.PlayerObject.transform.position + _movement * newSpeed * Time.deltaTime;

            newPosition.x = Mathf.Clamp(newPosition.x, -_bounds.x, _bounds.x);
            newPosition.y = Mathf.Clamp(newPosition.y, -_bounds.y, _bounds.y);

            _playerController.PlayerObject.transform.position = newPosition;

            CheckDirection(false);

            if (isCurrentlyMoving && !_isMoving)
            {
                _playerView.SetPlayerMoving();
                _isMoving = true;
            }
            else if (!isCurrentlyMoving && _isMoving)
            {
                _playerView.SetPlayerIdle();
                _isMoving = false;
            }
        }

        public void CheckDirection(bool onlyWeaponsCheck)
        {
            if (_movement.x > 0 && (!_facingRight || onlyWeaponsCheck))
            {
                if (!onlyWeaponsCheck)
                {
                    _facingRight = true;
                    _playerView.FlipPlayer();
                }
                _weaponsController.FlipWeapons(_facingRight);
            }
            else if (_movement.x < 0 && (_facingRight || onlyWeaponsCheck))
            {
                if (!onlyWeaponsCheck)
                {
                    _facingRight = false;
                    _playerView.FlipPlayer();
                }
                _weaponsController.FlipWeapons(_facingRight);
            }
        }
    }
}