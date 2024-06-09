/*
 * MaterialView.cs
 * Script Author: Charles d'Ansembourg
 * Creation Date: 09/06/2024
 * Contact: c.dansembourg@icloud.com
 */

using UnityEngine;

namespace Brotato_Clone.Views
{
    public class MaterialView : MonoBehaviour
    {
        [SerializeField]
        private Sprite[] _sprites;

        [SerializeField]
        private SpriteRenderer _spriteRenderer;

        public void SetSprite()
        {
            _spriteRenderer.sprite = _sprites[Random.Range(0, _sprites.Length)];
        }
    }
}