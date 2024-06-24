/*
 * InspectableDictionaryDrawer.cs
 * Script Author: Charles d'Ansembourg
 * Creation Date: 11/06/2024
 * Contact: c.dansembourg@icloud.com
 */

using Brotato_Clone.Models;
using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

[CustomPropertyDrawer(typeof(PlayerStats))]
public class PlayerStatsDrawer : PropertyDrawer
{
    public override void OnGUI(Rect position, SerializedProperty property, GUIContent label)
    {
        EditorGUI.BeginProperty(position, label, property);
        EditorGUI.indentLevel++;

        var iterator = property.Copy();
        var endProperty = property.GetEndProperty();

        while (iterator.NextVisible(true) && !SerializedProperty.EqualContents(iterator, endProperty))
        {
            if (iterator.propertyType == SerializedPropertyType.Generic && IsInspectableDictionary(iterator))
            {
                DrawInspectableDictionary(iterator);
            }
            else
            {
                EditorGUILayout.PropertyField(iterator, true);
            }
        }

        EditorGUI.indentLevel--;
        EditorGUI.EndProperty();
    }

    private bool IsInspectableDictionary(SerializedProperty property)
    {
        var targetObject = property.serializedObject.targetObject;
        var targetType = targetObject.GetType();
        var field = targetType.GetField(property.name, System.Reflection.BindingFlags.NonPublic | System.Reflection.BindingFlags.Public | System.Reflection.BindingFlags.Instance);
        return field != null && field.GetCustomAttributes(typeof(InspectableDictionaryAttribute), false).Length > 0;
    }

    private void DrawInspectableDictionary(SerializedProperty property)
    {
        IDictionary dictionary = GetDictionary(property);
        if (dictionary != null)
        {
            EditorGUILayout.LabelField(property.displayName, EditorStyles.boldLabel);
            EditorGUI.indentLevel++;

            var keys = new List<object>();
            foreach (var key in dictionary.Keys)
            {
                keys.Add(key);
            }

            foreach (var key in keys)
            {
                EditorGUILayout.BeginHorizontal();
                EditorGUILayout.LabelField(key.ToString(), GUILayout.Width(100));
                int newValue = EditorGUILayout.IntField((int)dictionary[key]);
                dictionary[key] = newValue;
                EditorGUILayout.EndHorizontal();
            }
            EditorGUI.indentLevel--;
        }
    }

    private IDictionary GetDictionary(SerializedProperty property)
    {
        object targetObject = property.serializedObject.targetObject;
        System.Type targetType = targetObject.GetType();
        System.Reflection.FieldInfo field = targetType.GetField(property.name, System.Reflection.BindingFlags.NonPublic | System.Reflection.BindingFlags.Public | System.Reflection.BindingFlags.Instance);
        return field.GetValue(targetObject) as IDictionary;
    }
}