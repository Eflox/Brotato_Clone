/*
 * PlayerItemsView.cs
 * Script Author: Charles d'Ansembourg
 * Creation Date: 11/06/2024
 * Contact: c.dansembourg@icloud.com
 */

using Brotato_Clone.Models;
using Brotato_Clone.Views;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

namespace Brotato_Clone.Player.Views
{
    public class PlayerItemsView : MonoBehaviour
    {
        [SerializeField]
        private Transform _itemsContainer;

        [SerializeField]
        private Transform _weaponsContainer;

        [SerializeField]
        private GameObject _itemPrefab;

        [SerializeField]
        private TMP_Text _weaponsTitle;

        public void LoadItems(Item character, List<Item> items, List<Weapon> weapons)
        {
            ClearItems();

            _weaponsTitle.text = $"Weapons ({weapons.Count}/6)";

            Instantiate(_itemPrefab, _itemsContainer).GetComponent<ItemView>().Initialize(character);

            foreach (Item item in items)
                Instantiate(_itemPrefab, _itemsContainer).GetComponent<ItemView>().Initialize(item);

            foreach (Item weapon in weapons)
                Instantiate(_itemPrefab, _weaponsContainer).GetComponent<ItemView>().Initialize(weapon);
        }

        private void ClearItems()
        {
            foreach (Transform child in _itemsContainer)
                Destroy(child);

            foreach (Transform child in _weaponsContainer)
                Destroy(child);
        }
    }
}