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

    [SerializeField]
    private float patchProbability = 0.3f; // Probability of creating a patch

    [SerializeField]
    private int minPatchSize = 2; // Minimum number of decorations in a patch

    [SerializeField]
    private int maxPatchSize = 5; // Maximum number of decorations in a patch

    [SerializeField]
    private float patchRadius = 2f; // Radius of the patch

    private void Start()
    {
        CreateDecorations();
    }

    private void CreateDecorations()
    {
        for (int i = 0; i < numberOfDecorations; i++)
        {
            // Determine if we should create a patch
            if (Random.value < patchProbability)
            {
                // Determine the patch size
                int patchSize = Random.Range(minPatchSize, maxPatchSize + 1);

                // Determine the central position of the patch
                float patchCenterX = Random.Range(-boundaries.x, boundaries.x);
                float patchCenterY = Random.Range(-boundaries.y, boundaries.y);

                for (int j = 0; j < patchSize; j++)
                {
                    CreateDecoration(patchCenterX, patchCenterY, i * 100 + j); // Use a unique ID for each decoration in the patch
                }

                // Skip creating individual decorations for the ones already created in the patch
                i += patchSize - 1;
            }
            else
            {
                // Create a single decoration
                float randomX = Random.Range(-boundaries.x, boundaries.x);
                float randomY = Random.Range(-boundaries.y, boundaries.y);
                CreateDecoration(randomX, randomY, i);
            }
        }
    }

    private void CreateDecoration(float x, float y, int id)
    {
        GameObject decoration = new GameObject("Decoration" + id);
        SpriteRenderer spriteRenderer = decoration.AddComponent<SpriteRenderer>();

        spriteRenderer.sprite = _decorations[Random.Range(0, _decorations.Length)];

        // If the decoration is part of a patch, slightly offset its position
        if (Random.value < patchProbability)
        {
            x += Random.Range(-patchRadius, patchRadius);
            y += Random.Range(-patchRadius, patchRadius);
        }

        decoration.transform.position = new Vector2(x, y);
    }
}
