/*
 * ApplyItemService.cs
 * Script Author: Charles d'Ansembourg
 * Creation Date: 28/05/2024
 * Contact: c.dansembourg@icloud.com
 */

using Brotato_Clone.Interfaces;
using Brotato_Clone.Models;
using System;
using System.Collections.Generic;
using System.Reflection;
using UnityEngine;

namespace Brotato_Clone.Services
{
    public class ApplyItemService
    {
        public void ApplyItem(NItem item, PlayerStats stats)
        {
            if (item.Attribute == null)
            {
                Debug.LogWarning("Tried to equip an item with no attribute.");
                return;
            }

            ApplyItemStats(item.Attribute, stats);
        }

        private void ApplyItemStats(IAttribute attribute, PlayerStats stats)
        {
            var attributeType = attribute.GetType();
            var statsType = typeof(PlayerStats);

            foreach (var attributeField in attributeType.GetFields(BindingFlags.Public | BindingFlags.Instance))
            {
                var statAttribute = attributeField.GetCustomAttribute<StatAttribute>();

                if (statAttribute != null)
                    ApplyStat(attribute, attributeField, statAttribute, statsType, stats);
            }
        }

        private void ApplyStat(IAttribute attribute, FieldInfo attributeField, StatAttribute statAttribute, Type statsType, PlayerStats stats)
        {
            string statFieldName = attributeField.Name.Replace("Multiplier", "");
            var statField = statsType.GetField(statFieldName);
            if (statField != null)
            {
                if (statField.FieldType == typeof(Dictionary<StatType, int>))
                {
                    var statDict = (Dictionary<StatType, int>)statField.GetValue(stats);
                    int valueToApply = (int)attributeField.GetValue(attribute);
                    var statType = statAttribute.IsMultiplier ? StatType.Multiplier : StatType.Base;

                    if (statAttribute.Operation == StatOperation.Add)
                        statDict[statType] += valueToApply;
                    else if (statAttribute.Operation == StatOperation.Set)
                        statDict[statType] = valueToApply;
                }
                else if (statField.FieldType == typeof(int))
                {
                    int valueToApply = (int)attributeField.GetValue(attribute);

                    if (statAttribute.Operation == StatOperation.Add)
                    {
                        int currentValue = (int)statField.GetValue(stats);
                        statField.SetValue(stats, currentValue + valueToApply);
                    }
                    else if (statAttribute.Operation == StatOperation.Set)
                        statField.SetValue(stats, valueToApply);
                }
            }
        }
    }
}