/*
 * PlayerAnimationsView.cs
 * Script Author: Charles d'Ansembourg
 * Creation Date: 11/06/2024
 * Contact: c.dansembourg@icloud.com
 */

using DG.Tweening;
using UnityEngine;

namespace Brotato_Clone.Player.Views
{
    /// <summary>
    /// Manages the player's animations, including flipping and movement animations.
    /// </summary>
    public class PlayerAnimationsView : MonoBehaviour
    {
        #region Fields

        [SerializeField]
        private Transform _playerTransform;

        [SerializeField]
        private Animator _animator;

        private const float _animationWidthChange = 0.1f;
        private const float _animationHeightChange = 0.2f;
        private const float _animationMovingSpeed = 3.0f;
        private const float _animationIdleSpeed = 0.3f;

        private Tween _tweener;
        private bool _facingRight = true;

        #endregion Fields

        #region Public Methods

        /// <summary>
        /// Initializes the player animations view by subscribing to relevant events.
        /// </summary>
        public void Initialize()
        {
            EventManager.Subscribe<bool>(PlayerEvent.PlayerFlipPlayer, OnFlipPlayer);
            EventManager.Subscribe<bool>(PlayerEvent.PlayerMoveChange, OnPlayerMoveChange);
        }

        /// <summary>
        /// Sets up the initial player animations.
        /// </summary>
        public void SetupAnimations()
        {
            _playerTransform.localScale = new Vector3(1 - _animationWidthChange, 1 + _animationHeightChange, 1f);
            _tweener = _playerTransform.DOScale(new Vector3(1 + _animationWidthChange, 1 - _animationHeightChange, 1f), 0.5f).SetLoops(-1, LoopType.Yoyo);
        }

        #endregion Public Methods

        #region Private Methods

        private void OnFlipPlayer(bool facingRight)
        {
            _facingRight = facingRight;
        }

        private void OnPlayerMoveChange(bool isMoving)
        {
            if (isMoving)
            {
                _tweener.timeScale = _animationMovingSpeed;
                _animator.SetInteger("MoveState", _facingRight ? 1 : 2);
            }
            else
            {
                _tweener.timeScale = _animationIdleSpeed;
                _animator.SetInteger("MoveState", 0);
            }
        }

        #endregion Private Methods
    }
}