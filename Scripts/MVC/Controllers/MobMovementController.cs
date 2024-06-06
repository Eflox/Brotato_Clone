/*
 * MobMovementController.cs
 * Script Author: Charles d'Ansembourg
 * Creation Date: 06/06/2024
 * Contact: c.dansembourg@icloud.com
 */

using Brotato_Clone.Views;
using DG.Tweening;
using UnityEngine;

namespace Brotato_Clone.Controllers
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
        private CircleCollider2D _collider;

        [SerializeField]
        private float baseSpeed = 10f;

        private Tween bounceTween;

        private float _animationWidthChange = 0.1f;
        private float _animationHeightChange = 0.2f;
        private float _animationMovingSpeed = 1.0f;
        private float _animationIdleSpeed = 0.3f;

        private float _lastDirection = 1f;

        public void Initialize(Transform player, int speed)
        {
            baseSpeed = speed;
            _player = player;

            _animationMovingSpeed += Random.Range(-0.1f, 0.1f);

            SetupBounceAnimation();

            _collider.enabled = true;

            _initialized = true;
        }

        private void SetupBounceAnimation()
        {
            transform.localScale = new Vector3(1 - _animationWidthChange, 1 + _animationHeightChange, 1f);
            bounceTween = transform.DOScale(new Vector3(1 + _animationWidthChange, 1 - _animationHeightChange, 1f), 0.5f).SetLoops(-1, LoopType.Yoyo);
        }

        private void FixedUpdate()
        {
            if (!_initialized)
                return;

            Vector2 direction = (_player.position - transform.position).normalized;
            float distanceToPlayer = Vector2.Distance(_player.position, transform.position);
            float stoppingDistance = 0.2f;

            bool isCurrentlyMoving = direction != Vector2.zero && distanceToPlayer > stoppingDistance;

            if (isCurrentlyMoving && bounceTween.timeScale != 5f)
                bounceTween.timeScale = _animationMovingSpeed;

            if (distanceToPlayer > stoppingDistance)
                _rb.velocity = direction * (baseSpeed / 2) * Time.fixedDeltaTime;
            else
                _rb.velocity = Vector2.zero;

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
                Physics2D.IgnoreCollision(collision.collider, _rb.GetComponent<Collider2D>());
            }
        }
    }
}