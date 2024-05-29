/*
 * Script Author: Charles d'Ansembourg
 * Creation Date: 29/05/2024
 * Contact: c.dansembourg@icloud.com
 */

using UnityEngine;

public class MovementService : MonoBehaviour
{
    public float speed = 5f;

    private void Start()
    {
        gameObject.transform.position = Vector3.zero;
    }

    private void Update()
    {
        Vector3 movement = Vector3.zero;

        if (Input.GetKey(KeyCode.W))
            movement.y += 1;
        if (Input.GetKey(KeyCode.S))
            movement.y -= 1;
        if (Input.GetKey(KeyCode.A))
            movement.x -= 1;
        if (Input.GetKey(KeyCode.D))
            movement.x += 1;

        movement.Normalize();
        transform.position += movement * speed * Time.deltaTime;
    }
}
