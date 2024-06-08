/*
 * BloodSplatController.cs
 * Script Author: Charles d'Ansembourg
 * Creation Date: 08/06/2024
 * Contact: c.dansembourg@icloud.com
 */

using UnityEngine;

namespace Brotato_Clone.Controllers
{
    public class BloodSplatController : MonoBehaviour
    {
        [SerializeField]
        private Rigidbody2D _rigidbody2d;

        [SerializeField]
        private float _forceMagnitude = 5f;

        private void Start()
        {
            if (_rigidbody2d.bodyType == RigidbodyType2D.Kinematic)
            {
                float randomAngle = Random.Range(0f, Mathf.PI * 2);
                Vector2 direction = new Vector2(Mathf.Cos(randomAngle), Mathf.Sin(randomAngle));
                _rigidbody2d.velocity = direction * _forceMagnitude;
            }
        }
    }
}