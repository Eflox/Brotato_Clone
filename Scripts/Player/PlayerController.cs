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
            if (test is IItem item)
            {
                EquipItem(item);
            }
        }
    }

    public void EquipItem(IItem item)
    {
        Player.Items.Add(item);

        var statsType = typeof(PlayerStats);
        var itemType = item.GetType();

        foreach (var itemField in itemType.GetFields(BindingFlags.Public | BindingFlags.Instance))
        {
            var isEffectField = itemField.GetCustomAttribute<EffectAttribute>() != null;
            if (isEffectField)
            {
                var statField = statsType.GetField(itemField.Name);
                if (statField != null && statField.FieldType == itemField.FieldType)
                {
                    int valueToAdd = (int)itemField.GetValue(item);
                    int currentStatValue = (int)statField.GetValue(Player.Stats);
                    statField.SetValue(Player.Stats, currentStatValue + valueToAdd);
                }
            }
        }
    }
}