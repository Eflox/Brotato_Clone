/*
 * PlayerController.cs
 * Script Author: Charles d'Ansembourg
 * Creation Date: 28/05/2024
 * Contact: c.dansembourg@icloud.com
 */

using Brotato_Clone.Interfaces;
using Brotato_Clone.Models;
using Brotato_Clone.Services;
using System;
using System.Collections.Generic;
using System.Reflection;
using UnityEngine;

namespace Brotato_Clone.Controllers
{
    public class PlayerController : MonoBehaviour
    {
        public Player Player;

        private void Start()
        {
            //List<NItem> items = PlayerPrefsService.GetItems();

            ApplyItem(ItemsData.Items["Brawler"]);
        }

        public void ApplyItem(NItem item)
        {
            if (item.Attribute == null)
            {
                Debug.LogWarning("Tried to equip an item with no attribute.");
                return;
            }

            EquipNestedItems(item.Attribute);

            ApplyItemStats(item.Attribute);
        }

        private void EquipNestedItems(IAttribute attribute)
        {
            var attributeField = attribute.GetType().GetField("Item", BindingFlags.Public | BindingFlags.Instance);
            if (attributeField != null)
            {
                var newItems = attributeField.GetValue(attribute) as NItem[];
                if (newItems != null)
                {
                    foreach (var newItem in newItems)
                    {
                        if (newItem.Attribute != null && (object)newItem.Attribute != attribute)
                        {
                            PlayerPrefsService.SaveItem(newItem);
                            ApplyItem(newItem);
                        }
                    }
                }
            }
        }

        private void ApplyItemStats(IAttribute attribute)
        {
            var attributeType = attribute.GetType();
            var statsType = typeof(PlayerStats);

            foreach (var attributeField in attributeType.GetFields(BindingFlags.Public | BindingFlags.Instance))
            {
                var statAttribute = attributeField.GetCustomAttribute<StatAttribute>();
                if (statAttribute != null)
                {
                    ApplyStat(attribute, attributeField, statAttribute, statsType);
                }
            }
        }

        private void ApplyStat(IAttribute attribute, FieldInfo attributeField, StatAttribute statAttribute, Type statsType)
        {
            string statFieldName = attributeField.Name.Replace("Multiplier", "");
            var statField = statsType.GetField(statFieldName);
            if (statField != null)
            {
                if (statField.FieldType == typeof(Dictionary<StatType, int>))
                {
                    var statDict = (Dictionary<StatType, int>)statField.GetValue(Player.Stats);
                    int valueToApply = (int)attributeField.GetValue(attribute);
                    var statType = statAttribute.IsMultiplier ? StatType.Multiplier : StatType.Base;

                    if (statAttribute.Operation == StatOperation.Add)
                    {
                        statDict[statType] += valueToApply;
                    }
                    else if (statAttribute.Operation == StatOperation.Set)
                    {
                        statDict[statType] = valueToApply;
                    }
                }
                else if (statField.FieldType == typeof(int))
                {
                    int valueToApply = (int)attributeField.GetValue(attribute);

                    if (statAttribute.Operation == StatOperation.Add)
                    {
                        int currentValue = (int)statField.GetValue(Player.Stats);
                        statField.SetValue(Player.Stats, currentValue + valueToApply);
                    }
                    else if (statAttribute.Operation == StatOperation.Set)
                    {
                        statField.SetValue(Player.Stats, valueToApply);
                    }
                }
            }
        }
    }
}