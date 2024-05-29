/*
 * Script Author: Charles d'Ansembourg
 * Creation Date: 30/05/2024
 * Contact: c.dansembourg@icloud.com
 */

using UnityEngine;

public class MapDecorationService : MonoBehaviour
{
    [SerializeField]
    private Sprite[] _decorations;

    [SerializeField]
    private int numberOfDecorations = 10;

    [SerializeField]
    private Vector2 boundaries;

    private void Start()
    {
        CreateDecorations();
    }

    private void CreateDecorations()
    {
        for (int i = 0; i < numberOfDecorations; i++)
        {
            GameObject decoration = new GameObject("Decoration" + i);
            SpriteRenderer spriteRenderer = decoration.AddComponent<SpriteRenderer>();

            spriteRenderer.sprite = _decorations[Random.Range(0, _decorations.Length)];
            float randomX = Random.Range(-boundaries.x, boundaries.x);
            float randomY = Random.Range(-boundaries.y, boundaries.y);
            decoration.transform.position = new Vector2(randomX, randomY);
        }
    }
}
