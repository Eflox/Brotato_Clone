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
    /// <summary>
    /// Controls access to the player controllers.
    /// </summary>
    public class PlayerController : MonoBehaviour
    {
        #region Fields

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
        private PlayerLevelUpMenuController _playerLevelUpMenuController;

        #endregion Fields

        #region Public Methods

        /// <summary>
        /// Initializes the player controller and its components.
        /// </summary>
        public void Initialize()
        {
            _playerView = GetComponent<PlayerView>();

            _playerCameraController = GetComponent<PlayerCameraController>();
            _playerLifecycleController = GetComponent<PlayerLifecycleController>();
            _playerItemsController = GetComponent<PlayerItemsController>();
            _playerStatsController = GetComponent<PlayerStatsController>();
            _playerPickupController = GetComponent<PlayerPickupController>();
            _playerMovementController = GetComponent<PlayerMovementController>();
            _playerHealthController = GetComponent<PlayerHealthController>();
            _playerAllWeaponsController = GetComponent<PlayerAllWeaponsController>();
            _playerLevelUpMenuController = GetComponent<PlayerLevelUpMenuController>();

            _playerLevelUpMenuController.Initialize();
            _playerMovementController.Initialize();
            _playerView.Initialize();

            _playerItemsController.SaveDefault();

            EventManager.Subscribe(GameEvent.GameStart, OnGameStart);
            EventManager.Subscribe<Wave>(WaveEvent.WaveStart, OnWaveStart);
            EventManager.Subscribe(WaveEvent.WaveEnd, OnWaveEnd);
            EventManager.Subscribe(PlayerEvent.PlayerDead, OnPlayerDead);
            EventManager.Subscribe<PlayerStats>(PlayerEvent.PlayerStatsChanged, OnStatsChanged);
            EventManager.Subscribe<NItem>(PlayerEvent.PlayerSelectItem, OnSelectedItem);
            EventManager.Subscribe(PlayerEvent.PlayerPickupDrop, OnPickupDrop);

            Debug.Log("Player Initialize");
        }

        /// <summary>
        /// Gets the player object.
        /// </summary>
        public GameObject GetPlayerObject()
        {
            return _playerObject;
        }

        #endregion Public Methods

        #region Private Methods

        private void Update()
        {
            if (Input.GetKeyDown(KeyCode.Alpha1))
            {
                EventManager.TriggerEvent(PlayerEvent.PlayerTakeDamage);
            }
            if (Input.GetKeyDown(KeyCode.Alpha2))
            {
                EventManager.TriggerEvent(PlayerEvent.PlayerDealDamage);
            }
        }

        private void OnDisable()
        {
            EventManager.Unsubscribe(GameEvent.GameStart, OnGameStart);
            EventManager.Unsubscribe<Wave>(WaveEvent.WaveStart, OnWaveStart);
            EventManager.Unsubscribe(WaveEvent.WaveEnd, OnWaveEnd);
            EventManager.Unsubscribe(PlayerEvent.PlayerDead, OnPlayerDead);
            EventManager.Unsubscribe<PlayerStats>(PlayerEvent.PlayerStatsChanged, OnStatsChanged);
            EventManager.Unsubscribe<NItem>(PlayerEvent.PlayerSelectItem, OnSelectedItem);
            EventManager.Unsubscribe(PlayerEvent.PlayerPickupDrop, OnPickupDrop);
        }

        private void OnGameStart()
        {
            Debug.Log("On Game Start");
            _playerItemsController.LoadItems();
            _playerStatsController.UpdateStats(_playerItemsController.GetItems());

            _playerView.LoadView(_playerItemsController.GetCharacter(), _playerItemsController.GetVisibleItems());
        }

        private void OnWaveStart(Wave wave)
        {
            Debug.Log("On Wave Start");

            var stats = _playerStatsController.GetStats();

            _playerStatsController.StartWaveStats();
            _playerCameraController.StartFollow(_playerObject.transform);
            _playerMovementController.StartMovement(stats.Speed[StatType.TotalVisible], _playerObject.transform);
            _playerHealthController.SetHealth(stats.MaxHP[StatType.TotalVisible]);
            _playerPickupController.StartPickupSearch(_playerObject);
            _playerAllWeaponsController.LoadWeapons(_playerItemsController.GetWeapons(), _playerObject.transform);
        }

        private void OnPlayerDead()
        {
            Debug.Log("On Player Dead");
            _playerCameraController.StopFollow();
            _playerMovementController.StopMovement();
            _playerPickupController.StopSearch();
            _playerLifecycleController.KillPlayer();
        }

        private void OnWaveEnd()
        {
            Debug.Log("On Wave End");
            _playerCameraController.StopFollow();
            _playerMovementController.StopMovement();
            _playerPickupController.StopSearch();
            _playerLevelUpMenuController.ShowMenu(_playerStatsController.GetStats().LevelsGainedDuringWave);
        }

        private void OnStatsChanged(PlayerStats stats)
        {
            Debug.Log("On Stats Changed");
            _playerPickupController.UpdateRange(stats.PickupRange);
            _playerMovementController.UpdateSpeed(stats.Speed[StatType.TotalVisible]);
            _playerHealthController.UpdateMaxHP(stats.MaxHP[StatType.TotalVisible]);
        }

        private void OnSelectedItem(NItem item)
        {
            _playerItemsController.AddItem(item);
            _playerStatsController.UpdateStats(_playerItemsController.GetItems());
        }

        private void OnPickupDrop()
        {
            _playerStatsController.UpdateMaterials(1);
        }

        #endregion Private Methods
    }
}