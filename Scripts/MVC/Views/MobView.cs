/*
 * MobView.cs
 * Script Author: Charles d'Ansembourg
 * Creation Date: 06/06/2024
 * Contact: c.dansembourg@icloud.com
 */

using Brotato_Clone.Controllers;
using DG.Tweening;
using System.Collections;
using UnityEngine;

namespace Brotato_Clone.Views
{
    public class MobView : MonoBehaviour
    {
        [SerializeField]
        private MobController _mobController;

        [SerializeField]
        private SpriteRenderer _spriteRenderer;

        private Material _flashMaterial;
        private Material _originalMaterial;

        private Coroutine _flashCoroutine;

        private void Awake()
        {
            _originalMaterial = _spriteRenderer.material;

            _flashMaterial = new Material(Shader.Find("GUI/Text Shader"));
            _flashMaterial.color = Color.white;
        }

        public void SetSpawnSprite(Sprite spawnSprite)
        {
            transform.rotation = Quaternion.Euler(0, 0, Random.Range(0, 360));
            _spriteRenderer.sprite = spawnSprite;
            _flashCoroutine = StartCoroutine(FlashOpacity());
        }

        public void SetSprite(Sprite sprite)
        {
            StopCoroutine(_flashCoroutine);
            _flashCoroutine = null;

            transform.rotation = Quaternion.Euler(0, 0, 0);

            _spriteRenderer.sprite = sprite;
            _spriteRenderer.material = _originalMaterial;
            _spriteRenderer.color = new Color(_spriteRenderer.color.r, _spriteRenderer.color.g, _spriteRenderer.color.b, 1f);
        }

        public void Flip()
        {
            _spriteRenderer.flipX = !_spriteRenderer.flipX;
        }

        public void GetHit()
        {
            StartCoroutine(FlashWhite());
        }

        private IEnumerator FlashWhite()
        {
            _spriteRenderer.material = _flashMaterial;
            yield return new WaitForSeconds(0.1f);
            _spriteRenderer.material = _originalMaterial;
        }

        private IEnumerator FlashOpacity()
        {
            float fadeDuration = 0.05f;

            while (true)
            {
                for (float t = 0; t < fadeDuration; t += Time.deltaTime)
                {
                    float normalizedTime = t / fadeDuration;
                    _spriteRenderer.color = new Color(_spriteRenderer.color.r, _spriteRenderer.color.g, _spriteRenderer.color.b, Mathf.Lerp(1f, 0f, normalizedTime));
                    yield return null;
                }
                _spriteRenderer.color = new Color(_spriteRenderer.color.r, _spriteRenderer.color.g, _spriteRenderer.color.b, 0f);

                yield return new WaitForSeconds(0.03f);

                for (float t = 0; t < fadeDuration; t += Time.deltaTime)
                {
                    float normalizedTime = t / fadeDuration;
                    _spriteRenderer.color = new Color(_spriteRenderer.color.r, _spriteRenderer.color.g, _spriteRenderer.color.b, Mathf.Lerp(0f, 1f, normalizedTime));
                    yield return null;
                }
                _spriteRenderer.color = new Color(_spriteRenderer.color.r, _spriteRenderer.color.g, _spriteRenderer.color.b, 1f);

                yield return new WaitForSeconds(0.2f);
            }
        }

        public void Die(Vector2 direction)
        {
            Vector3 moveDirection = new Vector3(direction.x, direction.y, 0);
            float moveDistance = 3f;
            Vector3 targetPosition = transform.position + moveDirection * moveDistance;

            Sequence dieSequence = DOTween.Sequence();
            dieSequence.Append(transform.DORotate(new Vector3(0, 0, 360), 0.8f, RotateMode.FastBeyond360))
                       .Join(transform.DOScale(Vector3.zero, 0.8f))
                       .Join(transform.DOMove(targetPosition, 0.8f))
                       .OnComplete(() => _mobController.Dead());
        }
    }
}