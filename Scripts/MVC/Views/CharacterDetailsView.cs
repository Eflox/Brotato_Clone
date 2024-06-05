/*
 * CharacterDetailsView.cs
 * Script Author: Charles d'Ansembourg
 * Creation Date: 05/06/2024
 * Contact: c.dansembourg@icloud.com
 */

using Brotato_Clone.Extensions;
using Brotato_Clone.Models;
using System.Linq;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

namespace Brotato_Clone.Views
{
    /// <summary>
    /// View that shows/hides the details of the character.
    /// </summary>
    public class CharacterDetailsView : MonoBehaviour
    {
        [SerializeField]
        private GameObject _container;

        [SerializeField]
        private TMP_Text _characterDescription;

        [SerializeField]
        private Image _characterIcon;

        [SerializeField]
        private TMP_Text _characterName;

        [SerializeField]
        private TMP_Text _characterClass;

        /// <summary>
        /// Shows the details view and stats secific character.
        /// </summary>
        public void ViewCharacter(NItem character)
        {
            _container.SetActive(true);
            _characterName.text = character.Name;
            _characterIcon.sprite = character.Icon;
            _characterDescription.text = character.Description.WithNL().WithColors();
            _characterClass.text = string.Join(", ", character.Classes.Select(c => c.ToString()));
        }

        /// <summary>
        /// Hides the details view.
        /// </summary>
        public void StopView()
        {
            _container.SetActive(false);
        }
    }
}