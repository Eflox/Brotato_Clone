/*
 * Script Author: Charles d'Ansembourg
 * Creation Date: #CREATIONDATE#
 * Contact: c.dansembourg@icloud.com
 */

using TMPro;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

public class ButtonHover : MonoBehaviour, IPointerEnterHandler, IPointerExitHandler
{
    public TMP_Text buttonText;
    public Image buttonImage;

    private Color originalTextColor;
    private Color originalBackgroundColor;

    void Start()
    {
        originalTextColor = buttonText.color;
        originalBackgroundColor = buttonImage.color;
    }

    public void OnPointerEnter(PointerEventData eventData)
    {
        buttonText.color = Color.black;
        buttonImage.color = Color.white;
    }

    public void OnPointerExit(PointerEventData eventData)
    {
        buttonText.color = originalTextColor;
        buttonImage.color = originalBackgroundColor;
    }
}