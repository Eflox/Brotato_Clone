/*
 * Script Author: Charles d'Ansembourg
 * Creation Date: 29/05/2024
 * Contact: c.dansembourg@icloud.com
 */

using Brotato_Clone;
using Brotato_Clone.Models;
using System.Collections.Generic;
using System.Reflection;
using UnityEditor;

[CustomEditor(typeof(PlayerStatsController))]
public class PlayerStatsControllerEditor : Editor
{
    public override void OnInspectorGUI()
    {
        PlayerStatsController controller = target as PlayerStatsController;

        if (controller == null)
        {
            EditorGUILayout.HelpBox("Player reference is not set.", MessageType.Warning);
            return;
        }

        DrawDefaultInspector();

        var stats = controller.GetStats();
        if (stats == null)
        {
            EditorGUILayout.HelpBox("Player stats are not set.", MessageType.Warning);
            return;
        }

        var fields = typeof(PlayerStats).GetFields(BindingFlags.Public | BindingFlags.Instance);
        foreach (var field in fields)
        {
            var attribute = field.GetCustomAttribute<InspectableDictionaryAttribute>();
            if (attribute != null)
            {
                var dictionary = field.GetValue(stats) as IDictionary<StatType, int>;
                if (dictionary != null)
                {
                    EditorGUILayout.Space();
                    EditorGUILayout.LabelField(field.Name, EditorStyles.boldLabel);
                    foreach (var key in dictionary.Keys)
                    {
                        var value = dictionary[key];
                        int newValue = EditorGUILayout.IntField(key.ToString(), value);
                        if (newValue != value)
                        {
                            dictionary[key] = newValue;
                            EditorUtility.SetDirty(controller);
                        }
                    }
                }
                else
                {
                    EditorGUILayout.HelpBox($"Field {field.Name} is not a valid dictionary.", MessageType.Error);
                }
            }
        }
    }
}