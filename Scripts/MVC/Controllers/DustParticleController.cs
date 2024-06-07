/*
 * DustParticleController.cs
 * Script Author: Charles d'Ansembourg
 * Creation Date: 07/06/2024
 * Contact: c.dansembourg@icloud.com
 */

using UnityEngine;

public class DustParticleController : MonoBehaviour
{
    [SerializeField]
    private float lifeTime = 1.0f;

    [SerializeField]
    private Vector2 initialScaleRange = new Vector2(0.8f, 1.2f);

    private Vector3 initialScale;
    private float elapsedTime = 0f;

    private float positionVariation = 0.1f;

    private void Start()
    {
        transform.rotation = Quaternion.Euler(0, 0, Random.Range(0, 360f));

        float randomScaleFactor = Random.Range(initialScaleRange.x, initialScaleRange.y);
        initialScale = transform.localScale * randomScaleFactor;
        transform.localScale = initialScale;
        transform.position += new Vector3(Random.Range(-positionVariation, positionVariation), Random.Range(-positionVariation, positionVariation));
    }

    private void Update()
    {
        elapsedTime += Time.deltaTime;
        float scaleReductionFactor = 1 - (elapsedTime / lifeTime);
        transform.localScale = initialScale * scaleReductionFactor;

        if (transform.localScale.x <= 0f || transform.localScale.y <= 0f)
        {
            Destroy(gameObject);
        }
    }
}