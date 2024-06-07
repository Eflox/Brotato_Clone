/*
 * WeaponView.cs
 * Script Author: Charles d'Ansembourg
 * Creation Date: 06/06/2024
 * Contact: c.dansembourg@icloud.com
 */

using UnityEngine;

namespace Brotato_Clone.Views
{
    public class WeaponView : MonoBehaviour
    {
        [SerializeField]
        private SpriteRenderer _spriteRenderer;

        public void SetSprite(Sprite weaponSprite)
        {
            _spriteRenderer.sprite = weaponSprite;
        }

        public void ResetFlip()
        {
            _spriteRenderer.flipX = false;
        }

        public void Flip(bool right)
        {
            _spriteRenderer.flipX = !right;
        }
    }
}