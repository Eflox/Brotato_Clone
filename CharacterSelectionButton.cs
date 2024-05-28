/*
 * Script Author: Charles d'Ansembourg
 * Creation Date: #CREATIONDATE#
 * Contact: c.dansembourg@icloud.com
 */

using UnityEngine;
using UnityEngine.UI;

public class CharacterSelectionButton : MonoBehaviour
{
    public ScriptableObject Character;
    [SerializeField] private Image _characterIcon;

    private void Start()
    {
        if (Character is ItemBase item)
            _characterIcon.sprite = item.Icon;
    }
}