/*
 * PlayerView.cs
 * Script Author: Charles d'Ansembourg
 * Creation Date: 05/06/2024
 * Contact: c.dansembourg@icloud.com
 */

using Brotato_Clone.Models;
using System.Collections.Generic;
using UnityEngine;

namespace Brotato_Clone.Player.Views
{
    /// <summary>
    /// Manages the player's visual components, including animations, camera, graphics, particles, UI status, stats, items, and sounds.
    /// </summary>
    public class PlayerView : MonoBehaviour
    {
        #region Fields

        private PlayerParticlesView _playerParticlesView;
        private PlayerAnimationsView _animationsView;
        private PlayerCameraView _playerCameraView;
        private PlayerGraphicsView _playerGraphicsView;
        private PlayerUIStatusView _playerUIStatusView;
        private PlayerStatsView _playerStatsView;
        private PlayerItemsView _playerItemsView;
        private PlayerSoundsView _playerSoundsView;
        private PlayerDamageNumbersView _playerDamageNumbersView;

        #endregion Fields

        #region Public Methods

        /// <summary>
        /// Initializes all player view components.
        /// </summary>
        public void Initialize()
        {
            _animationsView = GetComponent<PlayerAnimationsView>();
            _playerCameraView = GetComponent<PlayerCameraView>();
            _playerGraphicsView = GetComponent<PlayerGraphicsView>();
            _playerItemsView = GetComponent<PlayerItemsView>();
            _playerParticlesView = GetComponent<PlayerParticlesView>();
            _playerSoundsView = GetComponent<PlayerSoundsView>();
            _playerStatsView = GetComponent<PlayerStatsView>();
            _playerUIStatusView = GetComponent<PlayerUIStatusView>();
            _playerDamageNumbersView = GetComponent<PlayerDamageNumbersView>();

            _playerStatsView.Initialize();
            _animationsView.Initialize();
            _playerCameraView.Initialize();
            _playerUIStatusView.Initialize();
            _playerGraphicsView.Initialize();
            _playerDamageNumbersView.Initialize();
        }

        /// <summary>
        /// Loads the player view with character and visible items.
        /// </summary>
        public void LoadView(List<Item> visibleItems, Item character)
        {
            _animationsView.SetupAnimations();
            _playerGraphicsView.LoadPlayer(character, visibleItems);
        }

        public void LoadInventory(Item character, List<Item> items, List<Weapon> weapons)
        {
            _playerItemsView.LoadItems(character, items, weapons);
        }

        #endregion Public Methods
    }
}