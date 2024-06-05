/*
 * PlayerController.cs
 * Script Author: Charles d'Ansembourg
 * Creation Date: 28/05/2024
 * Contact: c.dansembourg@icloud.com
 */

using Brotato_Clone.Models;
using Brotato_Clone.Services;
using System.Collections.Generic;
using UnityEngine;

namespace Brotato_Clone.Controllers
{
    public class PlayerController : MonoBehaviour
    {
        public PlayerStats Stats = new PlayerStats();
        public List<NItem> Items = new List<NItem>();

        [SerializeField]
        private PlayerMovementController _movementController;

        [SerializeField]
        private PlayerVisualsController _visualsController;

        private ApplyItemService _applyItemService;
        private GetChildItemsService _getChildItemsService;
        private PlayerPrefsService _playerPrefsService;
        private StatsUpdaterService _statsUpdaterService;

        private void Start()
        {
            _applyItemService = new ApplyItemService();
            _getChildItemsService = new GetChildItemsService();
            _playerPrefsService = new PlayerPrefsService();
            _statsUpdaterService = new StatsUpdaterService();

            InitializeItems();
            _statsUpdaterService.UpdateVisibleStats(Stats);
            _visualsController.Initialize();
            _movementController.Initialize();
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
        }
    }
}