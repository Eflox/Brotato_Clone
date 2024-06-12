/*
 * PlayerController.cs
 * Script Author: Charles d'Ansembourg
 * Creation Date: 28/05/2024
 * Contact: c.dansembourg@icloud.com
 */

using Brotato_Clone.Models;
using Brotato_Clone.Player.Views;
using System.Collections.Generic;
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

        //TEMPORARY
        private void Start()
        {
            Initialize();
        }

        public void Initialize()
        {
            //View
            _playerView = GetComponent<PlayerView>();

            //Controllers
            _playerCameraController = GetComponent<PlayerCameraController>();
            _playerAllWeaponsController = GetComponent<PlayerAllWeaponsController>();
            _playerItemsController = GetComponent<PlayerItemsController>();
            _playerLifecycleController = GetComponent<PlayerLifecycleController>();
            _playerStatsController = GetComponent<PlayerStatsController>();
            _playerPickupController = GetComponent<PlayerPickupController>();
            _playerMovementController = GetComponent<PlayerMovementController>();
            _playerHealthController = GetComponent<PlayerHealthController>();

            //Events
            EventManager.Subscribe(GameEvent.GameStart, OnGameStart);

            EventManager.Subscribe(WaveEvent.WaveStart, OnWaveStart);
            EventManager.Subscribe(WaveEvent.WaveEnd, OnWaveEnd);

            EventManager.Subscribe(PlayerEvent.PlayerDead, OnPlayerDead);

            EventManager.Subscribe<PlayerStats>(PlayerEvent.PlayerStatsChanged, OnStatsChanged);
            EventManager.Subscribe<NItem>(PlayerEvent.PlayerSelectItem, OnSelectedItem);

            Debug.Log("Player initialized");
        }

        public void OnGameStart()
        {
            _playerLifecycleController.LoadPlayer();
            _playerItemsController.LoadItems();
            _playerStatsController.UpdateStats(_playerItemsController.GetItems());

            _playerView.LoadPlayer();
        }

        public void OnWaveStart()
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
            _playerItemsController.AddItem(item);
            _playerStatsController.UpdateStats(_playerItemsController.GetItems());
        }

        public GameObject GetPlayerObject()
        {
            return _playerObject;
        }

        //--------------------------------------------------------------------------------------
        //--------------------------------------------------------------------------------------
        //--------------------------------------------------------------------------------------

        public NItem Character = new NItem();
        public List<NItem> Items = new List<NItem>();
        public List<Upgrade> Upgrades = new List<Upgrade>();

        [SerializeField]
        private LevelUpMenuController _levelUpMenuController;

        [SerializeField]
        private PlayerLifecycleController _visualsController;

        [SerializeField]
        private PlayerCameraController _cameraController;

        [SerializeField]
        private WaveController _waveController;

        [SerializeField]
        private PlayerView _playerViewOld;

        private void InitializeOld()
        {
            _visualsController.Initialize();

            //_waveController.Initialize(WaveData.Waves[Stats.CurrentWave]);
            //_cameraController.Initialize(PlayerObject.transform);

            UpdateView();
        }

        private void UpdateView()
        {
            //_playerViewOld.SetHealth(Stats.CurrentHP, Stats.MaxHP[StatType.TotalVisible]);
            //_playerViewOld.SetLevel(Stats.CurrentLvl, Stats.CurrentXp, LevelData.LevelsXP[Stats.CurrentLvl]);
            //_playerViewOld.SetMaterials(Stats.CurrentMaterials);
            //_playerViewOld.SetBagMaterials(Stats.CurrentBagMaterials);
        }

        private void Update()
        {
            if (Input.GetKeyDown(KeyCode.Space))
            {
                //Stats.CurrentHP--;
                //Stats.CurrentXp++;
                //Stats.CurrentMaterials++;
                UpdateView();
            }
        }

        public void WaveEnd()
        {
            //if (Stats.LevelsGainedDuringWave > 0)
            //    _levelUpMenuController.OpenLevelUpMenu(Stats.LevelsGainedDuringWave);
        }

        public void AddUpgrade(Upgrade upgrade)
        {
            Debug.Log($"Added upgrade: {upgrade.Name}");
        }
    }
}