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
    /// <summary>
    /// Manages the player's graphics, including loading the player sprite and flipping the sprite direction.
    /// </summary>
    public class PlayerGraphicsView : MonoBehaviour
    {
        #region Fields

        [SerializeField]
        private SpriteRenderer _spriteRenderer;

        #endregion Fields

        #region Public Methods

        public void Initialize()
        {
            EventManager.Subscribe<bool>(PlayerEvent.PlayerFlipPlayer, OnFlipPlayer);
        }

        /// <summary>
        /// Loads the player sprite based on the character and wearable items.
        /// </summary>
        public void LoadPlayer(Item character, List<Item> wearableItems)
        {
            _spriteRenderer.sprite = Resources.Load<Sprite>(character.SpritePath);
        }

        /// <summary>
        /// Flips the player sprite based on the direction.
        /// </summary>
        public void OnFlipPlayer(bool right)
        {
            _spriteRenderer.flipX = !right;

            foreach (SpriteRenderer child in _spriteRenderer.gameObject.GetComponentsInChildren<SpriteRenderer>())
            {
                child.flipX = !right;
            }
        }

        #endregion Public Methods

        #region Private Methods

        private void OnDisable()
        {
            EventManager.Unsubscribe<bool>(PlayerEvent.PlayerFlipPlayer, OnFlipPlayer);
        }

        #endregion Private Methods
    }
}