/*
 * Script Author: Charles d'Ansembourg
 * Creation Date: 29/05/2024
 * Contact: c.dansembourg@icloud.com
 */

using UnityEngine;

public class CameraFollowService : MonoBehaviour
{
    public Vector2 boundaries;
    private Transform playerTransform;

    private void Start()
    {
        GameObject player = GameObject.Find("Player(Clone)");

        if (player != null)
            playerTransform = player.transform;
        else
            Debug.LogError("Player(Clone) not found!");
    }

    private void Update()
    {
        if (playerTransform != null)
        {
            Vector3 targetPosition = new Vector3(playerTransform.position.x, playerTransform.position.y, transform.position.z);
            float clampedX = Mathf.Clamp(targetPosition.x, -boundaries.x, boundaries.x);
            float clampedY = Mathf.Clamp(targetPosition.y, -boundaries.y, boundaries.y);
            transform.position = new Vector3(clampedX, clampedY, targetPosition.z);
        }
    }
}
