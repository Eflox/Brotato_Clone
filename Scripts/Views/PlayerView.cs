/*
 * PlayerView.cs
 * Script Author: Charles d'Ansembourg
 * Creation Date: 05/06/2024
 * Contact: c.dansembourg@icloud.com
 */

using DG.Tweening;
using System.Collections;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

namespace Brotato_Clone.Views
{
    public class PlayerView : MonoBehaviour
    {
        [SerializeField]
        private Transform _playerGraphics;

        [SerializeField]
        private SpriteRenderer _spriteRenderer;

        [SerializeField]
        private TMP_Text _healthText;

        [SerializeField]
        private Transform _healthBar;

        [SerializeField]
        private TMP_Text _levelText;

        [SerializeField]
        private Transform _levelBar;

        [SerializeField]
        private TMP_Text _materialsText;

        [SerializeField]
        private TMP_Text _bagMaterialsText;

        [SerializeField]
        private Image _bagSprite;

        [SerializeField]
        private Animator _animator;

        [SerializeField]
        private GameObject _dustParticlePrefab;

        private Tween _tweener;

        public float AnimationWidthChange = 0.1f;
        public float AnimationHeightChange = 0.2f;
        public float AnimationMovingSpeed = 3.0f;
        public float AnimationIdleSpeed = 0.3f;

        private bool _spawnParticles = false;
        private float dustSpawnInterval = 0.1f;
        private Coroutine _dustSpawnCoroutine;

        private bool _facingRight = true;

        public void SetupBounceAnimation()
        {
            _playerGraphics.localScale = new Vector3(1 - AnimationWidthChange, 1 + AnimationHeightChange, 1f);
            _tweener = _playerGraphics.DOScale(new Vector3(1 + AnimationWidthChange, 1 - AnimationHeightChange, 1f), 0.5f).SetLoops(-1, LoopType.Yoyo);
        }

        public void SetPlayerMoving()
        {
            _tweener.timeScale = AnimationMovingSpeed;
            _animator.SetInteger("MoveState", _facingRight ? 1 : 2);

            _spawnParticles = true;
            _dustSpawnCoroutine = StartCoroutine(SpawnDustParticles());
        }

        public void SetPlayerIdle()
        {
            _tweener.timeScale = AnimationIdleSpeed;
            _animator.SetInteger("MoveState", 0);

            _spawnParticles = false;

            if (_dustSpawnCoroutine != null)
                StopCoroutine(_dustSpawnCoroutine);
        }

        private IEnumerator SpawnDustParticles()
        {
            while (_spawnParticles)
            {
                Instantiate(_dustParticlePrefab, _playerGraphics.position - new Vector3(0, 0.35f), Quaternion.identity);
                yield return new WaitForSeconds(dustSpawnInterval);
            }
        }

        public void SetCharacter(Sprite characterSprite)
        {
            _spriteRenderer.sprite = characterSprite;
        }

        public void FlipPlayer()
        {
            _facingRight = !_facingRight;
            _spriteRenderer.flipX = !_spriteRenderer.flipX;
            _animator.SetInteger("MoveState", _facingRight ? 1 : 2);
        }

        public void SetHealth(int currentHealth, int maxHealth)
        {
            _healthText.text = $"{currentHealth} / {maxHealth}";

            float healthPercentage = (float)currentHealth / maxHealth;
            _healthBar.localScale = new Vector3(healthPercentage, _healthBar.localScale.y, _healthBar.localScale.z);
        }

        public void SetLevel(int level, int xp, int nextLevelXp)
        {
            _levelText.text = $"LV.{level}";

            float levelPrecentage = (float)xp / nextLevelXp;
            _levelBar.localScale = new Vector3(levelPrecentage, _levelBar.localScale.y, _levelBar.localScale.z);
        }

        public void SetMaterials(int materials)
        {
            _materialsText.text = $"{materials}";
        }

        public void SetBagMaterials(int bagMaterials)
        {
            if (bagMaterials != 0)
            {
                _bagSprite.enabled = true;
                _bagMaterialsText.text = $"{bagMaterials}";
            }
            else
            {
                _bagMaterialsText.text = "";
                _bagSprite.enabled = false;
            }
        }

        public void OnDestroy()
        {
            if (_tweener != null && _tweener.IsActive())
                _tweener.Kill();
        }
    }
}