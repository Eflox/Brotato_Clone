/*
 * ScrollController.cs
 * Script Author: Charles d'Ansembourg
 * Creation Date: 27/06/2024
 * Contact: c.dansembourg@icloud.com
 */

using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

public class ScrollController : MonoBehaviour, IPointerEnterHandler, IPointerExitHandler
{
    public ScrollRect scrollRect;
    public float scrollSpeed = 10f;

    private bool isPointerOver = false;

    private void Update()
    {
        if (isPointerOver)
        {
            float scrollDelta = Input.GetAxis("Mouse ScrollWheel");
            if (scrollDelta != 0.0f)
            {
                scrollRect.verticalNormalizedPosition += scrollDelta * scrollSpeed * Time.deltaTime;
                scrollRect.verticalNormalizedPosition = Mathf.Clamp01(scrollRect.verticalNormalizedPosition);
            }
        }
    }

    public void OnPointerEnter(PointerEventData eventData)
    {
        isPointerOver = true;
    }

    public void OnPointerExit(PointerEventData eventData)
    {
        isPointerOver = false;
    }
}