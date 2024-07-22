/*
 * PlayerItemsController.cs
 * Script Author: Charles d'Ansembourg
 * Creation Date: 11/06/2024
 * Contact: c.dansembourg@icloud.com
 */

using Brotato_Clone.Models;
using System;
using System.Collections.Generic;
using System.Linq;
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

        [SerializeField]
        private List<Item> _visibleItems = new List<Item>();

        [SerializeField]
        private List<Item> _allItems = new List<Item>();

        [SerializeField]
        private List<Item> _items = new List<Item>();

        [SerializeField]
        private List<Upgrade> _upgrades = new List<Upgrade>();

        [SerializeField]
        private List<Weapon> _weapons = new List<Weapon>();

        [SerializeField]
        private Character _character;

        public bool Ingame = false;

        private float _timer1 = 0;
        private float _timer3 = 0;
        private float _timer5 = 0;

        #endregion Fields

        #region Public Methods

        /// <summary>
        /// Save default character
        /// </summary>
        public void SaveDefault()
        {
            SaveManager.SaveCharacter(CharactersData.Characters[PlayerPrefs.GetString("StartCharacter")]);
            SaveManager.SaveUpgrades(null);
            SaveManager.SaveItems(null);

            List<Weapon> weapons = new List<Weapon>
            {
                WeaponsData.Weapons[PlayerPrefs.GetString("StartWeapon")]
            };

            SaveManager.SaveWeapons(weapons);
        }

        public void SaveAll()
        {
            SaveManager.SaveCharacter(_character);
            SaveManager.SaveUpgrades(_upgrades);
            SaveManager.SaveItems(_items);
            SaveManager.SaveWeapons(_weapons);
        }

        /// <summary>
        /// Adds an item to the player's collection and saves it.
        /// </summary>
        public void AddItem(Item item)
        {
            var existingItem = _items.FirstOrDefault(i => i.Name == item.Name);

            if (existingItem != null)
            {
                existingItem.Count++;
                SaveManager.SaveItems(_items);
            }
            else
                SaveManager.SaveItem(item);

            LoadItems();
        }

        /// <summary>
        /// Adds an item to the player's collection and saves it.
        /// </summary>
        public void AddUpgrade(Upgrade upgrade)
        {
            SaveManager.SaveUpgrade(upgrade);
            LoadItems();
        }

        /// <summary>
        /// Gets the list of all items.
        /// </summary>
        public List<Item> GetItemsWithChildren()
        {
            return _allItems;
        }

        /// <summary>
        /// Gets the list of items.
        /// </summary>
        public List<Item> GetItems()
        {
            return _items;
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
        public Item GetCharacter()
        {
            return _character;
        }

        /// <summary>
        /// Gets the list of visible items.
        /// </summary>
        public List<Item> GetVisibleItems()
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

            _allItems = new List<Item>();
            if (_weapons != null)
                _allItems.AddRange(_weapons);
            if (_items != null)
                _allItems.AddRange(_items);
            if (_upgrades != null)
                _allItems.AddRange(_upgrades);

            _allItems.Add(_character);

            List<Item> allItemsWithChildItems = new List<Item>(_allItems);

            foreach (var item in _allItems)
            {
                Item[] childItems = GetChildItems(item);

                if (childItems != null)
                    allItemsWithChildItems.AddRange(childItems);
            }

            _allItems = allItemsWithChildItems;

            foreach (var item in _allItems)
                if (ItemsData.Attributes.ContainsKey(item.Name))
                    item.Attribute = ItemsData.Attributes[item.Name];

            //CategoriseItems();
        }

        #endregion Public Methods

        #region Private Methods

        private void Update()
        {
            if (!Ingame)
                return;

            _timer1 += Time.deltaTime;
            _timer3 += Time.deltaTime;
            _timer5 += Time.deltaTime;

            if (_timer1 >= 1.0f)
            {
                OnTimer1();
                _timer1 = 0f;
            }

            if (_timer3 >= 3.0f)
            {
                OnTimer3();
                _timer3 = 0f;
            }

            if (_timer5 >= 5.0f)
            {
                OnTimer5();
                _timer5 = 0f;
            }
        }

        private void OnTimer1()
        {
            Debug.Log("Calling timer 1");
            foreach (var item in _items)
            {
                if (ItemsData.Attributes[item.Name] is IOnTimer1 attribute)
                {
                    Debug.Log($"{item.Name} called OnTimer3");
                    attribute.OnTimer1();
                }
            }
        }

        private void OnTimer3()
        {
            foreach (var item in _items)
            {
                if (item is IOnTimer3 attribute)
                {
                    Debug.Log($"{item.Name} called OnTimer3");
                    attribute.OnTimer3();
                }
            }
        }

        private void OnTimer5()
        {
            foreach (var item in _items)
            {
                if (item is IOnTimer5 attribute)
                {
                    Debug.Log($"{item.Name} called OnTimer3");
                    attribute.OnTimer5();
                }
            }
        }

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
                                _character = item as Character;
                                break;
                        }
                    }
                }
            }
        }

        private Item[] GetChildItems(Item item)
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
                        List<Item> childItems = new List<Item>();

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