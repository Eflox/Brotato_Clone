/*
 * PlayerGraphicsView.cs
 * Script Author: Charles d'Ansembourg
 * Creation Date: 11/06/2024
 * Contact: c.dansembourg@icloud.com
 */

using Brotato_Clone.Models;
using System.Collections.Generic;
using UnityEngine;

namespace Brotato_Clone.Player.Views
{
    public class PlayerGraphicsView : MonoBehaviour
    {
        [SerializeField]
        private SpriteRenderer _spriteRenderer;

        public void Initialize()
        {
            EventManager.Subscribe<bool>(PlayerEvent.PlayerFlipPlayer, OnFlipPlayer);
        }

        public void LoadPlayer(NItem character, List<NItem> wearableItems)
        {
            _spriteRenderer.sprite = character.Icon;
        }

        public void OnFlipPlayer(bool right)
        {
            _spriteRenderer.flipX = right;
        }
    }
}