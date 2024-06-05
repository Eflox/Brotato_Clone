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

        [SerializeField]
        private List<NItem> _items = new List<NItem>();

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
        }

        private void InitializeItems()
        {
            _items = _playerPrefsService.GetItems();

            List<NItem> allItems = new List<NItem>(_items);

            foreach (var item in _items)
            {
                NItem[] childItems = _getChildItemsService.GetChildItems(item);
                if (childItems != null)
                    allItems.AddRange(childItems);
            }

            foreach (var item in allItems)
                _applyItemService.ApplyItem(item, Stats);

            _items = allItems;
        }
    }
}