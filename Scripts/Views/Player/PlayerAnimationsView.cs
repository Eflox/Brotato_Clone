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
    public class PlayerAnimationsView : MonoBehaviour
    {
        [SerializeField]
        private Transform _playerTransform;

        [SerializeField]
        private Animator _animator;

        private float AnimationWidthChange = 0.1f;
        private float AnimationHeightChange = 0.2f;
        private float AnimationMovingSpeed = 3.0f;
        private float AnimationIdleSpeed = 0.3f;
        private Tween _tweener;
        private bool _facingRight = true;

        public void Initialize()
        {
            EventManager.Subscribe<bool>(PlayerEvent.PlayerFlipPlayer, OnFlipPlayer);
            EventManager.Subscribe<bool>(PlayerEvent.PlayerMoveChange, OnPlayerMoveChange);
        }

        public void SetupAnimations()
        {
            _playerTransform.localScale = new Vector3(1 - AnimationWidthChange, 1 + AnimationHeightChange, 1f);
            _tweener = _playerTransform.DOScale(new Vector3(1 + AnimationWidthChange, 1 - AnimationHeightChange, 1f), 0.5f).SetLoops(-1, LoopType.Yoyo);
        }

        private void OnFlipPlayer(bool facingRight)
        {
            _facingRight = facingRight;
        }

        private void OnPlayerMoveChange(bool isMoving)
        {
            if (isMoving)
            {
                _tweener.timeScale = AnimationMovingSpeed;
                _animator.SetInteger("MoveState", _facingRight ? 1 : 2);
            }
            else
            {
                _tweener.timeScale = AnimationIdleSpeed;
                _animator.SetInteger("MoveState", 0);
            }
        }
    }
}