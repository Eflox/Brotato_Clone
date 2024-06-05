/*
 * Script Author: Charles d'Ansembourg
 * Creation Date: 29/05/2024
 * Contact: c.dansembourg@icloud.com
 */

using Brotato_Clone.Controllers;
using Brotato_Clone.Models;
using System.Collections.Generic;
using System.Reflection;
using UnityEditor;

[CustomEditor(typeof(PlayerController))]
public class PlayerControllerEditor : Editor
{
    public override void OnInspectorGUI()
    {
        PlayerController controller = (PlayerController)target;

        DrawDefaultInspector();

        if (controller == null)
        {
            EditorGUILayout.HelpBox("Player reference is not set.", MessageType.Warning);
            return;
        }

        if (controller != null && controller.Stats != null)
        {
            var stats = controller.Stats;

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
                }
            }
        }
    }
}