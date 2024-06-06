/*
 * MobView.cs
 * Script Author: Charles d'Ansembourg
 * Creation Date: 06/06/2024
 * Contact: c.dansembourg@icloud.com
 */

using System.Collections;
using UnityEngine;

namespace Brotato_Clone.Views
{
    public class MobView : MonoBehaviour
    {
        [SerializeField]
        private SpriteRenderer _spriteRenderer;

        private Material _flashMaterial;
        private Material _originalMaterial;

        private void Awake()
        {
            _originalMaterial = _spriteRenderer.material;

            _flashMaterial = new Material(Shader.Find("GUI/Text Shader"));
            _flashMaterial.color = Color.white;
        }

        public void SetSprite(Sprite sprite)
        {
            _spriteRenderer.sprite = sprite;
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
    }
}