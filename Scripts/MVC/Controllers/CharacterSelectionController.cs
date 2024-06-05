/*
 * CharacterSelectionController.cs
 * Script Author: Charles d'Ansembourg
 * Creation Date: 05/06/2024
 * Contact: c.dansembourg@icloud.com
 */

using Brotato_Clone.Models;
using Brotato_Clone.Services;
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

        [SerializeField]
        private GameObject _playerGO;

        private PlayerPrefsService _playerPrefsService;

        private void Start()
        {
            _playerPrefsService = new PlayerPrefsService();
            _characterSelectionView.InitializeCharacters(ItemsData.GetItemsByClass(Class.Character), this);
        }

        /// <summary>
        /// Handles the event when a character is selected from the character selection view.
        /// </summary>
        public void CharacterSelected(NItem character)
        {
            _playerPrefsService.NewSave(character);
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