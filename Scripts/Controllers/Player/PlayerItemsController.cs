/*
 * PlayerItemsController.cs
 * Script Author: Charles d'Ansembourg
 * Creation Date: 11/06/2024
 * Contact: c.dansembourg@icloud.com
 */

using Brotato_Clone.Models;
using Brotato_Clone.Services;
using System;
using System.Collections.Generic;
using System.Reflection;
using UnityEngine;

namespace Brotato_Clone
{
    public class PlayerItemsController : MonoBehaviour
    {
        [SerializeField]
        private List<NItem> _visibleItems = new List<NItem>();

        [SerializeField]
        private List<NItem> _allItems = new List<NItem>();

        [SerializeField]
        private List<NItem> _items = new List<NItem>();

        [SerializeField]
        private List<Upgrade> _upgrades = new List<Upgrade>();

        [SerializeField]
        private List<Weapon> _weapons = new List<Weapon>();

        private NItem _character;

        public void AddItem(NItem item)
        {
            PlayerPrefsManager.SaveItem(item);
            LoadItems();
        }

        public List<NItem> GetItems()
        {
            return _allItems;
        }

        public List<Weapon> GetWeapons()
        {
            return _weapons;
        }

        public List<Upgrade> GetUpgrades()
        {
            return _upgrades;
        }

        public NItem GetCharacter()
        {
            return _character;
        }

        public List<NItem> GetVisibleItems()
        {
            return _visibleItems;
        }

        public void LoadItems()
        {
            _character = SaveManager.GetCharacter();
            _weapons = SaveManager.GetWeapons();
            _items = SaveManager.GetItems();
            _upgrades = SaveManager.GetUpgrades();

            _allItems = new List<NItem>();
            _allItems.AddRange(_weapons);
            _allItems.AddRange(_items);
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
                Debug.LogWarning("The item has no attribute.");
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
    }
}