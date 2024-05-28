/*
 * Script Author: Charles d'Ansembourg
 * Creation Date: 28/05/2024
 * Contact: c.dansembourg@icloud.com
 */

using System.Reflection;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public Player Player;
    public ScriptableObject test;

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            EquipItem(test);
        }
    }

    public void EquipItem(ScriptableObject item)
    {
        if (item is IItem equippableItem)
        {
            Player.Items.Add(equippableItem);

            var statsType = typeof(PlayerStats);
            var itemType = equippableItem.GetType();

            foreach (var itemField in itemType.GetFields(BindingFlags.Public | BindingFlags.Instance))
            {
                var isEffectField = itemField.GetCustomAttribute<EffectAttribute>() != null;
                if (isEffectField)
                {
                    var statField = statsType.GetField(itemField.Name);
                    if (statField != null && statField.FieldType == itemField.FieldType)
                    {
                        int valueToAdd = (int)itemField.GetValue(equippableItem);
                        int currentStatValue = (int)statField.GetValue(Player.Stats);
                        statField.SetValue(Player.Stats, currentStatValue + valueToAdd);
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