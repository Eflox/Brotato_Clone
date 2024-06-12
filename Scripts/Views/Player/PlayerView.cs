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
    public class PlayerView : MonoBehaviour
    {
        private PlayerAnimationsView _animationsView;
        private PlayerCameraView _playerCameraView;
        private PlayerGraphicsView _playerGraphicsView;
        private PlayerParticlesView _playerParticlesView;
        private PlayerUIStatusView _playerUIStatusView;

        //Not setup yet

        private PlayerStatsView _playerStatsView;
        private PlayerCombatView _playerCombatView;
        private PlayerItemsView _playerItemsView;
        private PlayerSoundsView _playerSoundsView;

        public void Initialize()
        {
            _animationsView = GetComponent<PlayerAnimationsView>();
            _playerCameraView = GetComponent<PlayerCameraView>();
            _playerCombatView = GetComponent<PlayerCombatView>();
            _playerGraphicsView = GetComponent<PlayerGraphicsView>();
            _playerItemsView = GetComponent<PlayerItemsView>();
            _playerParticlesView = GetComponent<PlayerParticlesView>();
            _playerSoundsView = GetComponent<PlayerSoundsView>();
            _playerStatsView = GetComponent<PlayerStatsView>();
            _playerUIStatusView = GetComponent<PlayerUIStatusView>();

            _playerGraphicsView.Initialize();
            _animationsView.Initialize();
            _playerCameraView.Initialize();
            _playerUIStatusView.Initialize();
        }

        public void LoadView(NItem character, List<NItem> visibleItems)
        {
            _animationsView.SetupAnimations();
            _playerGraphicsView.LoadPlayer(character, visibleItems);
        }
    }
}