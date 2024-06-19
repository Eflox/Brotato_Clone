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
    public class MaterialController : MonoBehaviour, IDrop
    {
        [SerializeField]
        private MaterialView _materialView;

        [SerializeField]
        private CircleCollider2D _circleCollider;

        public int Value => 1;

        public DropType Drop => DropType.Material;

        private void Start()
        {
            _materialView.SetSprite();

            Invoke(nameof(EnableMaterial), 0.2f);
        }

        private void EnableMaterial()
        {
            _circleCollider.enabled = true;
        }

        public void PickUp(Transform playerTransform)
        {
            StartCoroutine(MoveToPlayer(playerTransform));
        }

        private IEnumerator MoveToPlayer(Transform playerTransform)
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
            ReachedPlayer();
        }

        private void ReachedPlayer()
        {
            EventManager.TriggerEvent(PlayerEvent.PlayerPickupDrop);
            Destroy(gameObject);
        }
    }
}