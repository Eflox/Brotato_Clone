/*
 * Script Author: Charles d'Ansembourg
 * Creation Date: 28/05/2024
 * Contact: c.dansembourg@icloud.com
 */

using System.Collections.Generic;
using System.Reflection;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public Player Player;
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
    }

    public void EquipItem(ScriptableObject item)
    {
        if (item is IItem equippableItem)
        {
            Player.Items.Add(equippableItem);

            var statsType = typeof(PlayerStats);
            var itemType = equippableItem.GetType();

            // Iterate over each field in the item type
            foreach (var itemField in itemType.GetFields(BindingFlags.Public | BindingFlags.Instance))
            {
                var statAttribute = itemField.GetCustomAttribute<StatAttribute>();
                if (statAttribute != null)
                {
                    string statFieldName = itemField.Name.Replace("Multiplier", "");
                    var statField = statsType.GetField(statFieldName);
                    if (statField != null && statField.FieldType == typeof(Dictionary<StatType, int>))
                    {
                        var statDict = (Dictionary<StatType, int>)statField.GetValue(Player.Stats);
                        if (statDict != null)
                        {
                            int valueToAdd = (int)itemField.GetValue(equippableItem);
                            if (statAttribute.IsMultiplier)
                            {
                                statDict[StatType.Multiplier] += valueToAdd;
                            }
                            else
                            {
                                statDict[StatType.Base] += valueToAdd;
                            }
                        }
                    }
                }
            }
        }
        else
        {
            Debug.LogWarning("Tried to equip something that is not an item.");
        }
    }



}