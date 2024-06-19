/*
 * PlayerItemsController.cs
 * Script Author: Charles d'Ansembourg
 * Creation Date: 11/06/2024
 * Contact: c.dansembourg@icloud.com
 */

using Brotato_Clone.Models;
using System;
using System.Collections.Generic;
using System.Reflection;
using UnityEngine;

namespace Brotato_Clone.Controllers
{
    /// <summary>
    /// Controller for managing player items, including loading, saving, and categorizing items.
    /// </summary>
    public class PlayerItemsController : MonoBehaviour
    {
        #region Fields

        private List<NItem> _visibleItems = new List<NItem>();
        private List<NItem> _allItems = new List<NItem>();
        private List<NItem> _items = new List<NItem>();
        private List<Upgrade> _upgrades = new List<Upgrade>();
        private List<Weapon> _weapons = new List<Weapon>();
        private NItem _character;

        #endregion Fields

        #region Public Methods

        /// <summary>
        /// Save default character
        /// </summary>
        public void SaveDefault()
        {
            SaveManager.SaveCharacter(ItemsData.Items["WellRounded"]);

            List<Weapon> weapons = new List<Weapon>
            {
                WeaponsData.Weapons["Knife"],
                WeaponsData.Weapons["Fist"]
            };

            SaveManager.SaveWeapons(weapons);
        }

        /// <summary>
        /// Adds an item to the player's collection and saves it.
        /// </summary>
        public void AddItem(NItem item)
        {
            //SaveManager.SaveItems(item.);
            LoadItems();
        }

        /// <summary>
        /// Gets the list of all items.
        /// </summary>
        public List<NItem> GetItems()
        {
            return _allItems;
        }

        /// <summary>
        /// Gets the list of all weapons.
        /// </summary>
        public List<Weapon> GetWeapons()
        {
            return _weapons;
        }

        /// <summary>
        /// Gets the list of all upgrades.
        /// </summary>
        public List<Upgrade> GetUpgrades()
        {
            return _upgrades;
        }

        /// <summary>
        /// Gets the current character item.
        /// </summary>
        public NItem GetCharacter()
        {
            return _character;
        }

        /// <summary>
        /// Gets the list of visible items.
        /// </summary>
        public List<NItem> GetVisibleItems()
        {
            return _visibleItems;
        }

        /// <summary>
        /// Clears all items, including character, weapons, and upgrades.
        /// </summary>
        public void ClearItems()
        {
            ClearCharacterSave();
            ClearWeaponsSave();
            ClearItemsSave();
            ClearUpgradesSave();
        }

        /// <summary>
        /// Saves all items, including character, weapons, and upgrades.
        /// </summary>
        public void SaveItems()
        {
            SaveManager.SaveCharacter(_character);
            SaveManager.SaveWeapons(_weapons);
            SaveManager.SaveItems(_items);
            SaveManager.SaveUpgrades(_upgrades);
        }

        /// <summary>
        /// Loads all items from the save data.
        /// </summary>
        public void LoadItems()
        {
            _character = SaveManager.GetCharacter();
            _weapons = SaveManager.GetWeapons();
            _items = SaveManager.GetItems();
            _upgrades = SaveManager.GetUpgrades();

            _allItems = new List<NItem>();
            if (_weapons != null)
                _allItems.AddRange(_weapons);
            if (_items != null)
                _allItems.AddRange(_items);
            if (_upgrades != null)
                _allItems.AddRange(_upgrades);

            List<NItem> allItemsWithChildItems = new List<NItem>(_allItems);

            foreach (var item in _allItems)
            {
                NItem[] childItems = GetChildItems(item);
                if (childItems != null)
                    allItemsWithChildItems.AddRange(childItems);
            }
            _allItems = allItemsWithChildItems;

            CategoriseItems();
        }

        #endregion Public Methods

        #region Private Methods

        private void ClearCharacterSave()
        {
            _character = null;
            SaveManager.SaveCharacter(null);
        }

        private void ClearWeaponsSave()
        {
            _weapons.Clear();
            SaveManager.SaveWeapons(_weapons);
        }

        private void ClearItemsSave()
        {
            _items.Clear();
            SaveManager.SaveItems(_items);
        }

        private void ClearUpgradesSave()
        {
            _upgrades.Clear();
            SaveManager.SaveUpgrades(_upgrades);
        }

        private void CategoriseItems()
        {
            foreach (var item in _allItems)
            {
                if (item.Classes != null)
                {
                    foreach (var itemClass in item.Classes)
                    {
                        switch (itemClass)
                        {
                            case Class.Item:
                                _items.Add(item);
                                break;

                            case Class.Upgrade:
                                _upgrades.Add(item as Upgrade);
                                break;

                            case Class.Weapon:
                                _weapons.Add(item as Weapon);
                                break;

                            case Class.Character:
                                _character = item;
                                break;
                        }
                    }
                }
            }
        }

        private NItem[] GetChildItems(NItem item)
        {
            if (item.Attribute == null)
            {
                return null;
            }

            Type attributeType = item.Attribute.GetType();
            FieldInfo[] fields = attributeType.GetFields(BindingFlags.Public | BindingFlags.Instance);

            foreach (var field in fields)
            {
                var itemAttribute = field.GetCustomAttribute<ItemAttribute>();

                if (itemAttribute != null)
                {
                    var value = field.GetValue(item.Attribute) as string[];
                    if (value != null && value.Length > 0)
                    {
                        List<NItem> childItems = new List<NItem>();

                        foreach (var itemName in value)
                            if (ItemsData.Items.ContainsKey(itemName))
                                childItems.Add(ItemsData.Items[itemName]);
                            else
                                Debug.LogWarning($"Item {itemName} not found in ItemsData.");

                        return childItems.ToArray();
                    }
                }
            }

            return null;
        }

        #endregion Private Methods
    }
}