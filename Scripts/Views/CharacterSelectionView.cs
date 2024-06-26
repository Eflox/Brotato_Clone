/*
 * CharacterSelectionView.cs
 * Script Author: Charles d'Ansembourg
 * Creation Date: 05/06/2024
 * Contact: c.dansembourg@icloud.com
 */

using Brotato_Clone.Controllers;
using Brotato_Clone.Models;
using UnityEngine;

namespace Brotato_Clone.Views
{
    /// <summary>
    /// Manages the character selection UI.
    /// </summary>
    public class CharacterSelectionView : MonoBehaviour
    {
        [SerializeField]
        private Transform _characterButtonsContainer;

        [SerializeField]
        private GameObject _characterButtonPrefab;

        /// <summary>
        /// Initializes the character selection view with a list of characters.
        /// Creates a button for each character and sets it up with the provided controller.
        /// </summary>
        public void InitializeCharacters(Character[] characters, CharacterSelectionController controller)
        {
            foreach (var character in characters)
            {
                var characterButton = Instantiate(_characterButtonPrefab, _characterButtonsContainer);
                var buttonView = characterButton.GetComponent<CharacterButtonView>();

                buttonView.SetCharacter(character, controller);
            }
        }
    }
}