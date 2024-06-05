/*
 * PlayerPrefsService.cs
 * Script Author: Charles d'Ansembourg
 * Creation Date: 05/06/2024
 * Contact: c.dansembourg@icloud.com
 */

using Brotato_Clone.Models;
using System;
using System.Collections.Generic;
using UnityEngine;

namespace Brotato_Clone.Services
{
    /// <summary>
    /// Service for handling player preferences related to items.
    /// </summary>
    public class PlayerPrefsService
    {
        /// <summary>
        /// Saves a new character item to player preferences.
        /// </summary>
        public void NewSave(NItem character)
        {
            string newSave = $"{character.Name}";
            PlayerPrefs.SetString("Items", newSave);
        }

        /// <summary>
        /// Adds an item to the existing saved items in player preferences.
        /// </summary>
        public void SaveItem(NItem item)
        {
            string newSave = $"{GetKeyValue()},{item.Name}";
            PlayerPrefs.SetString("Items", newSave);
        }

        /// <summary>
        /// Retrieves the list of saved items from player preferences.
        /// </summary>
        public List<NItem> GetItems()
        {
            List<NItem> items = new List<NItem>();
            string keyValue = GetKeyValue();
            string[] itemNames = keyValue.Split(new char[] { ',' }, StringSplitOptions.RemoveEmptyEntries);

            foreach (string item in itemNames)
            {
                if (ItemsData.Items.ContainsKey(item))
                {
                    items.Add(ItemsData.Items[item]);
                }
            }

            return items;
        }

        /// <summary>
        /// Retrieves the saved items string from player preferences.
        /// </summary>
        private string GetKeyValue()
        {
            return PlayerPrefs.GetString("Items");
        }
    }
}