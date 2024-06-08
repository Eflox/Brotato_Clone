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
        private Image buttonImage;
        private TMP_Text buttonText;
        private Color originalButtonColor = Color.black;
        private Color hoverButtonColor = Color.white;
        private Color originalTextColor = Color.white;
        private Color hoverTextColor = Color.black;
        private AudioSource _audioSource;

        private void Start()
        {
            _audioSource = gameObject.AddComponent<AudioSource>();
            _audioSource.clip = Resources.Load<AudioClip>("Audio/ButtonSelectAudio");

            buttonImage = GetComponent<Image>();
            buttonText = GetComponentInChildren<TMP_Text>();

            buttonImage.color = originalButtonColor;
            buttonText.color = originalTextColor;
        }

        public void OnPointerEnter(PointerEventData eventData)
        {
            _audioSource.Play();

            buttonImage.color = hoverButtonColor;
            buttonText.color = hoverTextColor;
        }

        public void OnPointerExit(PointerEventData eventData)
        {
            buttonImage.color = originalButtonColor;
            buttonText.color = originalTextColor;
        }
    }
}