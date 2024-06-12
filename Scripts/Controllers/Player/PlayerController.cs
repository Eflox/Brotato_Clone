/*
 * PlayerController.cs
 * Script Author: Charles d'Ansembourg
 * Creation Date: 28/05/2024
 * Contact: c.dansembourg@icloud.com
 */

using Brotato_Clone.Models;
using Brotato_Clone.Player.Views;
using UnityEngine;

namespace Brotato_Clone.Controllers
{
    public class PlayerController : MonoBehaviour
    {
        [SerializeField]
        private GameObject _playerObject;

        private PlayerView _playerView;

        private PlayerCameraController _playerCameraController;
        private PlayerAllWeaponsController _playerAllWeaponsController;
        private PlayerItemsController _playerItemsController;
        private PlayerLifecycleController _playerLifecycleController;
        private PlayerStatsController _playerStatsController;
        private PlayerPickupController _playerPickupController;
        private PlayerMovementController _playerMovementController;
        private PlayerHealthController _playerHealthController;

        public void Initialize()
        {
            _playerView = GetComponent<PlayerView>();

            _playerCameraController = GetComponent<PlayerCameraController>();
            _playerAllWeaponsController = GetComponent<PlayerAllWeaponsController>();
            _playerItemsController = GetComponent<PlayerItemsController>();
            _playerLifecycleController = GetComponent<PlayerLifecycleController>();
            _playerStatsController = GetComponent<PlayerStatsController>();
            _playerPickupController = GetComponent<PlayerPickupController>();
            _playerMovementController = GetComponent<PlayerMovementController>();
            _playerHealthController = GetComponent<PlayerHealthController>();

            _playerView.Initialize();

            EventManager.Subscribe(GameEvent.GameStart, OnGameStart);
            EventManager.Subscribe<Wave>(WaveEvent.WaveStart, OnWaveStart);
            EventManager.Subscribe(WaveEvent.WaveEnd, OnWaveEnd);
            EventManager.Subscribe(PlayerEvent.PlayerDead, OnPlayerDead);
            EventManager.Subscribe<PlayerStats>(PlayerEvent.PlayerStatsChanged, OnStatsChanged);
            EventManager.Subscribe<NItem>(PlayerEvent.PlayerSelectItem, OnSelectedItem);
        }

        public void OnGameStart()
        {
            _playerItemsController.LoadItems();
            _playerStatsController.UpdateStats(_playerItemsController.GetItems());

            _playerView.LoadView(_playerItemsController.GetCharacter(), _playerItemsController.GetVisibleItems());
        }

        public void OnWaveStart(Wave wave)
        {
            var stats = _playerStatsController.GetStats();

            _playerStatsController.StartWaveStats();
            _playerCameraController.StartFollow(_playerObject.transform);
            _playerMovementController.StartMovement(stats.Speed[StatType.TotalVisible], _playerObject.transform);
            _playerHealthController.SetHealth(stats.MaxHP[StatType.TotalVisible]);
            _playerPickupController.StartPickupSearch(stats.PickupRange, _playerObject);
            _playerAllWeaponsController.LoadWeapons(_playerItemsController.GetWeapons(), _playerObject.transform);
        }

        public void OnPlayerDead()
        {
            _playerCameraController.StopFollow();
            _playerMovementController.StopMovement();
            _playerPickupController.StopSearch();
            _playerLifecycleController.KillPlayer();
        }

        public void OnWaveEnd()
        {
            _playerCameraController.StopFollow();
            _playerMovementController.StopMovement();
            _playerPickupController.StopSearch();
        }

        public void OnStatsChanged(PlayerStats stats)
        {
            _playerPickupController.UpdateRange(stats.PickupRange);
            _playerMovementController.UpdateSpeed(stats.Speed[StatType.TotalVisible]);
            _playerHealthController.UpdateMaxHP(stats.MaxHP[StatType.TotalVisible]);
        }

        public void OnSelectedItem(NItem item)
        {
            Debug.Log(item.Name);
            _playerItemsController.AddItem(item);
            _playerStatsController.UpdateStats(_playerItemsController.GetItems());
        }

        public GameObject GetPlayerObject()
        {
            return _playerObject;
        }
    }
}