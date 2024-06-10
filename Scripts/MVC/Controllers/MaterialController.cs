/*
 * MaterialController.cs
 * Script Author: Charles d'Ansembourg
 * Creation Date: 09/06/2024
 * Contact: c.dansembourg@icloud.com
 */

using Brotato_Clone.Views;
using System.Collections;
using UnityEngine;

namespace Brotato_Clone.Controllers
{
    public class MaterialController : MonoBehaviour
    {
        [SerializeField]
        private MaterialView _materialView;

        [SerializeField]
        private CircleCollider2D _circleCollider;

        private int _value;

        private void Start()
        {
            _value = 1;
            _materialView.SetSprite();

            Invoke(nameof(EnableMaterial), 0.2f);
        }

        private void EnableMaterial()
        {
            _circleCollider.enabled = true;
        }

        public void PickUp(PlayerController controller, Transform playerTransform)
        {
            StartCoroutine(MoveToPlayer(controller, playerTransform));
        }

        private IEnumerator MoveToPlayer(PlayerController controller, Transform playerTransform)
        {
            float duration = 0.2f;
            float elapsedTime = 0f;
            Vector3 startingPosition = transform.position;
            Vector3 targetPosition = playerTransform.position;

            while (elapsedTime < duration)
            {
                transform.position = Vector3.Lerp(startingPosition, targetPosition, elapsedTime / duration);
                elapsedTime += Time.deltaTime;
                yield return null;
            }

            transform.position = targetPosition;
            ReachedPlayer(controller);
        }

        private void ReachedPlayer(PlayerController controller)
        {
            controller.AddMaterial(_value);
            Destroy(gameObject);
        }
    }
}