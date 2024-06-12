/*
 * PlayerCameraView.cs
 * Script Author: Charles d'Ansembourg
 * Creation Date: 11/06/2024
 * Contact: c.dansembourg@icloud.com
 */

using System.Collections;
using UnityEngine;

public class PlayerCameraView : MonoBehaviour
{
    [SerializeField]
    private Camera _camera;

    private Vector3 originalPosition;
    private Coroutine shakeCoroutine;

    public void Initialize()
    {
        originalPosition = _camera.transform.localPosition;
        EventManager.Subscribe(PlayerEvent.PlayerTakeDamage, OnPlayerTakeDamage);
        EventManager.Subscribe(PlayerEvent.PlayerDealDamage, OnPlayerDealDamage);
    }

    private void OnPlayerTakeDamage()
    {
        if (shakeCoroutine != null)
            StopCoroutine(shakeCoroutine);

        shakeCoroutine = StartCoroutine(ShakeCamera(0.2f, 0.3f));
    }

    private void OnPlayerDealDamage()
    {
        if (shakeCoroutine != null)
            StopCoroutine(shakeCoroutine);

        shakeCoroutine = StartCoroutine(ShakeCamera(0.1f, 0.2f));
    }

    private IEnumerator ShakeCamera(float duration, float magnitude)
    {
        float elapsed = 0.0f;

        while (elapsed < duration)
        {
            float offsetX = Random.Range(-1f, 1f) * magnitude;
            float offsetY = Random.Range(-1f, 1f) * magnitude;

            _camera.transform.localPosition = new Vector3(originalPosition.x + offsetX, originalPosition.y + offsetY, originalPosition.z);

            elapsed += Time.deltaTime;

            yield return null;
        }

        _camera.transform.localPosition = originalPosition;
        shakeCoroutine = null;
    }
}