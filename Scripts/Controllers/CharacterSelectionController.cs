/*
 * CharacterSelectionController.cs
 * Script Author: Charles d'Ansembourg
 * Creation Date: 05/06/2024
 * Contact: c.dansembourg@icloud.com
 */

using Brotato_Clone.Models;
using Brotato_Clone.Views;
using System.Collections.Generic;
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
            _characterSelectionView.InitializeCharacters(ItemsData.GetItemsByClass(Class.Character), this);
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
        public void CharacterSelected(NItem character)
        {
            SaveManager.SaveCharacter(character);

            List<Weapon> weapons = new List<Weapon>();
            weapons.Add(WeaponsData.Weapons["Fist"]);

            SaveManager.SaveWeapons(weapons);
            SceneManager.LoadScene("GameScene");
        }

        /// <summary>
        /// Handles the event when the mouse pointer hovers over or exits a character button.
        /// </summary>
        public void OnCharacterHover(NItem character, bool mouseEnter)
        {
            if (mouseEnter)
                _characterDetailsView.ViewCharacter(character);
            else if (!mouseEnter)
                _characterDetailsView.StopView();
        }
    }
}