/*
 * Script Author: Charles d'Ansembourg
 * Creation Date: #CREATIONDATE#
 * Contact: c.dansembourg@icloud.com
 */

using TMPro;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.EventSystems;
using UnityEngine.UI;

public class ButtonHover : MonoBehaviour, IPointerEnterHandler, IPointerExitHandler
{
    [SerializeField]
    private TMP_Text _buttonText;

    [SerializeField]
    private Image _buttonImage;

    [SerializeField]
    private UnityEvent _onHover;

    [SerializeField]
    private UnityEvent _onNotHover;

    private Color originalTextColor;
    private Color originalBackgroundColor;

    void Start()
    {
        if (_buttonText != null)
            originalTextColor = _buttonText.color;
        if (_buttonImage != null)
            originalBackgroundColor = _buttonImage.color;
    }

    public void OnPointerEnter(PointerEventData eventData)
    {
        if (_onHover != null)
            _onHover.Invoke();

        if (_buttonText != null)
            _buttonText.color = Color.black;

        if (_buttonImage != null)
            _buttonImage.color = Color.white;
    }

    public void OnPointerExit(PointerEventData eventData)
    {
        if (_onNotHover != null)
            _onNotHover.Invoke();

        if (_buttonText != null)
            _buttonText.color = originalTextColor;

        if (_buttonImage != null)
            _buttonImage.color = originalBackgroundColor;
    }
}