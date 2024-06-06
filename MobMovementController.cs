/*
 * MobMovementController.cs
 * Script Author: Charles d'Ansembourg
 * Creation Date: 06/06/2024
 * Contact: c.dansembourg@icloud.com
 */

using Brotato_Clone.Views;
using DG.Tweening;
using UnityEngine;

namespace Brotato_Clone
{
    public class MobMovementController : MonoBehaviour
    {
        private bool _initialized = false;
        private Transform _player;

        [SerializeField]
        private MobView _mobView;

        [SerializeField]
        private Rigidbody2D _rb;

        [SerializeField]
        private float baseSpeed = 10f;

        private Tween bounceTween;

        private float _animationWidthChange = 0.1f;
        private float _animationHeightChange = 0.2f;
        private float _animationMovingSpeed = 3.0f;
        private float _animationIdleSpeed = 0.3f;

        private float _lastDirection = 1f;

        public void Initialize(Transform player, int speed)
        {
            baseSpeed = speed;
            _player = player;
            SetupBounceAnimation();
            _initialized = true;
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

            Vector2 direction = (_player.position - transform.position).normalized;
            bool isCurrentlyMoving = direction != Vector2.zero;

            if (isCurrentlyMoving && bounceTween.timeScale != 5f)
                bounceTween.timeScale = _animationMovingSpeed;
            else if (!isCurrentlyMoving && bounceTween.timeScale != 1f)
                bounceTween.timeScale = _animationIdleSpeed;

            _rb.velocity = direction * (baseSpeed * 7) * Time.deltaTime;

            if ((direction.x > 0 && _lastDirection <= 0) || (direction.x < 0 && _lastDirection >= 0))
            {
                _mobView.Flip();
                _lastDirection = direction.x;
            }
        }

        private void OnDestroy()
        {
            bounceTween.timeScale = _animationIdleSpeed;
        }

        private void OnCollisionEnter2D(Collision2D collision)
        {
            if (collision.gameObject.layer == LayerMask.NameToLayer("Enemy"))
            {
                // Ignore collision with other enemies
                Physics2D.IgnoreCollision(collision.collider, _rb.GetComponent<Collider2D>());
            }
        }
    }
}