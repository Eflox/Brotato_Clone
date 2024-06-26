/*
 * CharacterSelectionController.cs
 * Script Author: Charles d'Ansembourg
 * Creation Date: 05/06/2024
 * Contact: c.dansembourg@icloud.com
 */

using Brotato_Clone.Models;
using Brotato_Clone.Views;
using UnityEngine;
using UnityEngine.SceneManagement;

namespace Brotato_Clone.Controllers
{
    /// <summary>
    /// Manages the character selection process.
    /// </summary>
    public class CharacterSelectionController : MonoBehaviour
    {
        [SerializeField]
        private CharacterSelectionView _characterSelectionView;

        [SerializeField]
        private CharacterDetailsView _characterDetailsView;

        private void Start()
        {
            _characterSelectionView.InitializeCharacters(CharactersData.GetCharacters(), this);
        }

        private void Update()
        {
            if (Input.GetKeyDown(KeyCode.Escape))
            {
                SceneManager.LoadScene("MenuScene");
            }
        }

        /// <summary>
        /// Handles the event when a character is selected from the character selection view.
        /// </summary>
        public void CharacterSelected(Character character)
        {
            PlayerPrefs.SetString("StartCharacter", character.Name);
            PlayerPrefs.SetString("StartWeapon", "Knife");

            SceneManager.LoadScene("GameScene");
        }

        /// <summary>
        /// Handles the event when the mouse pointer hovers over or exits a character button.
        /// </summary>
        public void OnCharacterHover(Item character, bool mouseEnter)
        {
            if (mouseEnter)
                _characterDetailsView.ViewCharacter(character);
            else if (!mouseEnter)
                _characterDetailsView.StopView();
        }
    }
}