/*
 * PlayerMovementController.cs
 * Script Author: Charles d'Ansembourg
 * Creation Date: 05/06/2024
 * Contact: c.dansembourg@icloud.com
 */

using Brotato_Clone.Views;
using DG.Tweening;
using UnityEngine;

namespace Brotato_Clone.Controllers
{
    public class PlayerMovementController : MonoBehaviour
    {
        [SerializeField]
        private PlayerController _playerController;

        [SerializeField]
        private PlayerView _playerView;

        private float baseHiddenSpeed = 5f;
        private float percentageBaseSpeed = 100f;

        private bool _initialized = false;
        private float _lastDirection = 1f;

        public Vector2 _bounds = new Vector2(10f, 10f);
        private Tween bounceTween;

        private float _animationWidthChange = 0.1f;
        private float _animationHeightChange = 0.2f;
        private float _animationMovingSpeed = 3.0f;
        private float _animationIdleSpeed = 0.3f;

        public void Initialize()
        {
            gameObject.transform.position = Vector3.zero;
            _initialized = true;

            SetupBounceAnimation();
        }

        private void SetupBounceAnimation()
        {
            transform.localScale = new Vector3(1 - _animationWidthChange, 1 + _animationHeightChange, 1f);
            bounceTween = transform.DOScale(new Vector3(1 + _animationWidthChange, 1 - _animationHeightChange, 1f), 0.5f).SetLoops(-1, LoopType.Yoyo);
        }

        private void Update()
        {
            if (!_initialized)
                return;

            Vector3 movement = Vector3.zero;

            if (Input.GetKey(KeyCode.W))
                movement.y += 1;
            if (Input.GetKey(KeyCode.S))
                movement.y -= 1;
            if (Input.GetKey(KeyCode.A))
                movement.x -= 1;
            if (Input.GetKey(KeyCode.D))
                movement.x += 1;

            movement.Normalize();

            bool isCurrentlyMoving = movement != Vector3.zero;

            if (isCurrentlyMoving && bounceTween.timeScale != 5f)
                bounceTween.timeScale = _animationMovingSpeed;
            else if (!isCurrentlyMoving && bounceTween.timeScale != 1f)
                bounceTween.timeScale = _animationIdleSpeed;

            float percentageIncrease = _playerController.Stats.Speed[Models.StatType.TotalVisible] / percentageBaseSpeed;
            float newSpeed = baseHiddenSpeed * (1 + percentageIncrease);

            Vector3 newPosition = transform.position + movement * newSpeed * Time.deltaTime;

            newPosition.x = Mathf.Clamp(newPosition.x, -_bounds.x, _bounds.x);
            newPosition.y = Mathf.Clamp(newPosition.y, -_bounds.y, _bounds.y);

            transform.position = newPosition;

            if ((movement.x > 0 && _lastDirection <= 0) || (movement.x < 0 && _lastDirection >= 0))
            {
                _playerView.FlipPlayer();
                _lastDirection = movement.x;
            }
        }
    }
}