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

            _playerStatsView.Initialize();
            _animationsView.Initialize();
            _playerCameraView.Initialize();
            _playerUIStatusView.Initialize();
            _playerGraphicsView.Initialize();
        }

        /// <summary>
        /// Loads the player view with character and visible items.
        /// </summary>
        public void LoadView(Item character, List<Item> visibleItems, List<Item> items, List<Weapon> weapons)
        {
            _animationsView.SetupAnimations();
            _playerGraphicsView.LoadPlayer(character, visibleItems);
            _playerItemsView.LoadItems(character, items, weapons);
        }

        #endregion Public Methods
    }
}