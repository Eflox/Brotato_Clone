/*
 * CharacterButtonView.cs
 * Script Author: Charles d'Ansembourg
 * Creation Date: 05/06/2024
 * Contact: c.dansembourg@icloud.com
 */

using Brotato_Clone.Controllers;
using Brotato_Clone.Models;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

namespace Brotato_Clone.Views
{
    /// <summary>
    /// Represents a button in the character selection view.
    /// </summary>
    public class CharacterButtonView : MonoBehaviour, IPointerEnterHandler, IPointerExitHandler
    {
        [SerializeField]
        private Image _icon;

        [SerializeField]
        private Image _buttonBorder;

        [SerializeField]
        private NItem _character;

        private CharacterSelectionController _controller;

        private AudioSource _audioSource;

        /// <summary>
        /// Initializes the button with character data and sets up the controller reference.
        /// </summary>
        public void SetCharacter(NItem character, CharacterSelectionController controller)
        {
            _character = character;
            _controller = controller;
            _icon.sprite = Resources.Load<Sprite>(character.SpritePath);

            gameObject.name = $"{_character.Name}_Spawned_Button";

            _audioSource = gameObject.AddComponent<AudioSource>();
            _audioSource.clip = Resources.Load<AudioClip>("Audio/ButtonSelectAudio");

            GetComponent<Button>().onClick.AddListener(OnButtonClick);
        }

        /// <summary>
        /// Notifies the controller that the character is being hovered over.
        /// </summary>
        public void OnPointerEnter(PointerEventData eventData)
        {
            _audioSource.Play();

            _buttonBorder.color = Color.white;
            _controller.OnCharacterHover(_character, true);
        }

        /// <summary>
        /// Notifies the controller that the character is no longer being hovered over.
        /// </summary>
        public void OnPointerExit(PointerEventData eventData)
        {
            _buttonBorder.color = Color.black;
            _controller.OnCharacterHover(_character, false);
        }

        private void OnButtonClick()
        {
            _controller.CharacterSelected(_character);
        }
    }
}