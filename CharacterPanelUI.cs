/*
 * Script Author: Charles d'Ansembourg
 * Creation Date: #CREATIONDATE#
 * Contact: c.dansembourg@icloud.com
 */

using System.Linq;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class CharacterPanelUI : MonoBehaviour
{
    [SerializeField]
    private TMP_Text _characterDescription;

    [SerializeField]
    private Image _characterIcon;

    [SerializeField]
    private TMP_Text _characterName;

    [SerializeField]
    private TMP_Text _characterClass;

    public void SelectCharacter(CharacterSelectionButton button)
    {
        if (button.Character is ItemBase item)
        {
            _characterName.text = item.Name;
            _characterIcon.sprite = item.Icon;
            _characterDescription.text = item.Description.WithNL().WithColors();
            _characterClass.text = string.Join(", ", item.classes.Select(c => c.ToString()));
        }
    }
}