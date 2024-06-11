/*
 * PlayerController.cs
 * Script Author: Charles d'Ansembourg
 * Creation Date: 28/05/2024
 * Contact: c.dansembourg@icloud.com
 */

using Brotato_Clone.Models;
using Brotato_Clone.Player.Views;
using Brotato_Clone.Services;
using System.Collections.Generic;
using UnityEngine;

namespace Brotato_Clone.Controllers
{
    public class PlayerController : MonoBehaviour
    {
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
            EventManager.Subscribe(GameEvent.GameStart, OnStartGame);
            EventManager.Subscribe(WaveEvent.WaveStart, OnStartWave);
            EventManager.Subscribe(PlayerEvent.PlayerDead, OnPlayerDead);
            EventManager.Subscribe<NItem>(PlayerEvent.PlayerAddItem, OnAddItem);
        }

        public void OnStartGame()
        {
            _playerLifecycleController.LoadPlayer();
            _playerItemsController.LoadItems();
            _playerStatsController.UpdateStats();

            _playerView.LoadPlayer();
        }

        public void OnStartWave()
        {
            _playerCameraController.StartFollow();
            _playerMovementController.StartMovement();
            _playerHealthController.InitializeHealth();
        }

        public void OnPlayerDead()
        {
            _playerCameraController.StopFollow();
            _playerMovementController.StopMovement();
        }

        public void OnAddItem(NItem item)
        {
            Debug.Log($"Recieved: {item.Name}");

            _playerItemsController.AddItem(item);
            _playerStatsController.UpdateStats();
        }

        //--------------------------------------------------------------------------------------
        //--------------------------------------------------------------------------------------
        //--------------------------------------------------------------------------------------

        public PlayerStats Stats = new PlayerStats();

        public NItem Character = new NItem();
        public List<NItem> Items = new List<NItem>();
        public List<Upgrade> Upgrades = new List<Upgrade>();

        public GameObject PlayerObject;

        [SerializeField]
        private LevelUpMenuController _levelUpMenuController;

        [SerializeField]
        private PlayerMovementController _movementController;

        [SerializeField]
        private PlayerLifecycleController _visualsController;

        [SerializeField]
        private PlayerCameraController _cameraController;

        [SerializeField]
        private WaveController _waveController;

        [SerializeField]
        private PickupController _pickupController;

        [SerializeField]
        private PlayerView _playerViewOld;

        private ApplyItemService _applyItemService;
        private GetChildItemsService _getChildItemsService;
        private PlayerPrefsService _playerPrefsService;
        private StatsUpdaterService _statsUpdaterService;

        private void InitializeOld()
        {
            _applyItemService = new ApplyItemService();
            _getChildItemsService = new GetChildItemsService();
            _playerPrefsService = new PlayerPrefsService();
            _statsUpdaterService = new StatsUpdaterService();

            InitializeItems();
            InitializeStats();

            _pickupController.Initialize(this);
            _visualsController.Initialize();

            _movementController.Initialize();
            _waveController.Initialize(WaveData.Waves[Stats.CurrentWave]);
            _cameraController.Initialize(PlayerObject.transform);

            UpdateView();
        }

        private void InitializeItems()
        {
            Items = _playerPrefsService.GetItems();

            List<NItem> allItems = new List<NItem>(Items);

            foreach (var item in Items)
            {
                NItem[] childItems = _getChildItemsService.GetChildItems(item);
                if (childItems != null)
                    allItems.AddRange(childItems);
            }

            foreach (var item in allItems)
                _applyItemService.ApplyItem(item, Stats);

            Items = allItems;

            Character = Items[0];
        }

        private void InitializeStats()
        {
            _statsUpdaterService.UpdateVisibleStats(Stats);

            Stats.CurrentHP = Stats.MaxHP[StatType.TotalVisible];
            Stats.CurrentWave = _playerPrefsService.GetStat("Wave");
            Stats.CurrentLvl = _playerPrefsService.GetStat("Level");
            Stats.CurrentXp = _playerPrefsService.GetStat("Xp"); ;
            Stats.CurrentMaterials = _playerPrefsService.GetStat("Materials"); ;
            Stats.CurrentMaterials = _playerPrefsService.GetStat("Materials"); ;
            Stats.CurrentBagMaterials = _playerPrefsService.GetStat("BagMaterials"); ;
        }

        private void UpdateView()
        {
            _playerViewOld.SetHealth(Stats.CurrentHP, Stats.MaxHP[StatType.TotalVisible]);
            _playerViewOld.SetLevel(Stats.CurrentLvl, Stats.CurrentXp, LevelData.LevelsXP[Stats.CurrentLvl]);
            _playerViewOld.SetMaterials(Stats.CurrentMaterials);
            _playerViewOld.SetBagMaterials(Stats.CurrentBagMaterials);
        }

        private void Update()
        {
            if (Input.GetKeyDown(KeyCode.Space))
            {
                Stats.CurrentHP--;
                Stats.CurrentXp++;
                Stats.CurrentMaterials++;
                UpdateView();
            }
        }

        public void AddMaterial(int value)
        {
            Stats.CurrentMaterials += value;
            Stats.CurrentXp += value;

            if (Stats.CurrentXp >= LevelData.LevelsXP[Stats.CurrentLvl])
            {
                Stats.CurrentLvl++;
                Stats.LevelsGainedDuringWave++;
                Stats.CurrentXp = 0;
            }

            UpdateView();
        }

        public void WaveEnd()
        {
            if (Stats.LevelsGainedDuringWave > 0)
                _levelUpMenuController.OpenLevelUpMenu(Stats.LevelsGainedDuringWave);
        }

        public void AddUpgrade(Upgrade upgrade)
        {
            Debug.Log($"Added upgrade: {upgrade.Name}");
        }
    }
}