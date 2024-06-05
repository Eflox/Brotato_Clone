/*
 * PlayerView.cs
 * Script Author: Charles d'Ansembourg
 * Creation Date: 05/06/2024
 * Contact: c.dansembourg@icloud.com
 */

using UnityEngine;

namespace Brotato_Clone.Views
{
    public class PlayerView : MonoBehaviour
    {
        [SerializeField]
        private SpriteRenderer _spriteRenderer;

        public void SetCharacter(Sprite characterSprite)
        {
            _spriteRenderer.sortingOrder = 10;
            _spriteRenderer.sprite = characterSprite;
        }

        public void FlipPlayer()
        {
            _spriteRenderer.flipX = !_spriteRenderer.flipX;
        }
    }
}