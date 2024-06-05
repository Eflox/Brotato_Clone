/*
 * PlayerMovementController.cs
 * Script Author: Charles d'Ansembourg
 * Creation Date: 05/06/2024
 * Contact: c.dansembourg@icloud.com
 */

using UnityEngine;

namespace Brotato_Clone.Controllers
{
    public class PlayerMovementController : MonoBehaviour
    {
        [SerializeField]
        private PlayerController _playerController;

        private float baseHiddenSpeed = 5f;
        private float percentageBaseSpeed = 100f;

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

            float percentageIncrease = _playerController.Stats.Speed[Models.StatType.TotalVisible] / percentageBaseSpeed;
            float newSpeed = baseHiddenSpeed * (1 + percentageIncrease);

            transform.position += movement * newSpeed * Time.deltaTime;
        }
    }
}