/*
 * ItemCullingController.cs
 * Script Author: Charles d'Ansembourg
 * Creation Date: 27/06/2024
 * Contact: c.dansembourg@icloud.com
 */

using UnityEngine;
using UnityEngine.UI;

public class ItemCulling : MonoBehaviour
{
    public ScrollRect scrollRect;
    public RectTransform contentPanel;
    public float cullHeight = 50f;

    private void Update()
    {
        CullItems();
    }

    private void CullItems()
    {
        RectTransform viewport = scrollRect.viewport;
        Vector3[] viewportCorners = new Vector3[4];
        viewport.GetWorldCorners(viewportCorners);
        float viewportTop = viewportCorners[1].y;
        float viewportBottom = viewportCorners[0].y;

        for (int i = 0; i < contentPanel.childCount; i++)
        {
            Transform item = contentPanel.GetChild(i);
            Vector3[] itemCorners = new Vector3[4];
            item.GetComponent<RectTransform>().GetWorldCorners(itemCorners);
            float itemTop = itemCorners[1].y;
            float itemBottom = itemCorners[0].y;

            bool isVisible = itemTop >= viewportBottom - cullHeight && itemBottom <= viewportTop + cullHeight;

            item.gameObject.SetActive(isVisible);
        }
    }
}