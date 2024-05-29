/*
 * Script Author: Charles d'Ansembourg
 * Creation Date: 28/05/2024
 * Contact: c.dansembourg@icloud.com
 */

using System;
using System.Collections.Generic;
using System.Reflection;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public Player Player;

    private List<float> _weaponTimers = new List<float>();

    private void Start()
    {
        DontDestroyOnLoad(this.gameObject);
    }

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            StatsUpdater.UpdateVisibleStats(Player.Stats);
        }
        if (Input.GetKeyDown(KeyCode.W))
        {
            foreach (var weapon in Player.Weapons)
            {
                Debug.Log(weapon.CalculateHit(Player.Stats));
            }
        }
        if (Input.GetKeyDown(KeyCode.Return))
        {
            Debug.Log(Player.Items);
            Debug.Log(Player.Weapons);
            Debug.Log(Player.Items.Count);
            Debug.Log(Player.Weapons.Count);
        }
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
            Player.Weapons.Add(weapon);
        }
        else
        {
            Player.Items.Add(equippableItem);
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
                var statDict = (Dictionary<StatType, int>)statField.GetValue(Player.Stats);
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