/*
 * ButtonController.cs
 * Script Author: Charles d'Ansembourg
 * Creation Date: 07/06/2024
 * Contact: c.dansembourg@icloud.com
 */

using TMPro;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

namespace Brotato_Clone.Controllers
{
    public class ButtonController : MonoBehaviour, IPointerEnterHandler, IPointerExitHandler
    {
        private Image _buttonImage;
        private TMP_Text _buttonText;
        private Color _originalButtonColor = Color.black;
        private Color _hoverButtonColor = Color.white;
        private Color _originalTextColor = Color.white;
        private Color _hoverTextColor = Color.black;
        private AudioSource _audioSource;
        private bool _disableEffect = false;

        public void ToggleEffect(bool toggle)
        {
            _disableEffect = toggle;
        }

        private void Start()
        {
            _audioSource = gameObject.AddComponent<AudioSource>();
            _audioSource.clip = Resources.Load<AudioClip>("Audio/ButtonSelectAudio");

            _buttonImage = GetComponent<Image>();
            _buttonText = GetComponentInChildren<TMP_Text>();

            _originalButtonColor = _buttonImage.color;
            _originalTextColor = _buttonText.color;
        }

        public void OnPointerEnter(PointerEventData eventData)
        {
            _audioSource.Play();

            if (_disableEffect)
                return;

            _buttonImage.color = _hoverButtonColor;
            _buttonText.color = _hoverTextColor;
        }

        public void OnPointerExit(PointerEventData eventData)
        {
            if (_disableEffect)
                return;

            _buttonImage.color = _originalButtonColor;
            _buttonText.color = _originalTextColor;
        }
    }
}