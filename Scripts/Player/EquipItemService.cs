/*
 * Script Author: Charles d'Ansembourg
 * Creation Date: 28/05/2024
 * Contact: c.dansembourg@icloud.com
 */

using Brotato_Clone.Controllers;
using System;
using System.Collections.Generic;
using System.Reflection;
using UnityEngine;

public class EquipItemService
{
    private PlayerController _playerController;

    public EquipItemService(PlayerController playerController)
    {
        _playerController = playerController;
    }

    public void EquipItem(ScriptableObject item)
    {
        if (!(item is IItem equippableItem))
        {
            Debug.LogWarning("Tried to equip something that is not an item.");
            return;
        }

        EquipNestedItems(item);

        if (item is IWeapon weapon)
        {
            _playerController.Player.Weapons.Add(weapon);
        }
        else
        {
            _playerController.Player.Items.Add(equippableItem);
        }
        ApplyItemStats(equippableItem);
    }

    private void EquipNestedItems(ScriptableObject item)
    {
        var itemField = item.GetType().GetField("Item", BindingFlags.Public | BindingFlags.Instance);
        if (itemField != null)
        {
            var newItems = itemField.GetValue(item) as ScriptableObject[];
            if (newItems != null)
            {
                foreach (var newItem in newItems)
                {
                    if (newItem is IItem newEquippableItem && (object)newEquippableItem != item)
                    {
                        EquipItem(newItem);
                    }
                }
            }
        }
    }

    private void ApplyItemStats(IItem item)
    {
        var itemType = item.GetType();
        var statsType = typeof(PlayerStats);

        foreach (var itemField in itemType.GetFields(BindingFlags.Public | BindingFlags.Instance))
        {
            var statAttribute = itemField.GetCustomAttribute<StatAttribute>();
            if (statAttribute != null)
            {
                ApplyStat(item, itemField, statAttribute, statsType);
            }
        }
    }

    private void ApplyStat(IItem item, FieldInfo itemField, StatAttribute statAttribute, Type statsType)
    {
        string statFieldName = itemField.Name.Replace("Multiplier", "");
        var statField = statsType.GetField(statFieldName);
        if (statField != null)
        {
            if (statField.FieldType == typeof(Dictionary<StatType, int>))
            {
                var statDict = (Dictionary<StatType, int>)statField.GetValue(_playerController.Player.Stats);
                int valueToApply = (int)itemField.GetValue(item);
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
                int valueToApply = (int)itemField.GetValue(item);

                if (statAttribute.Operation == StatOperation.Add)
                {
                    int currentValue = (int)statField.GetValue(_playerController.Player.Stats);
                    statField.SetValue(_playerController.Player.Stats, currentValue + valueToApply);
                }
                else if (statAttribute.Operation == StatOperation.Set)
                {
                    statField.SetValue(_playerController.Player.Stats, valueToApply);
                }
            }
        }
    }
}