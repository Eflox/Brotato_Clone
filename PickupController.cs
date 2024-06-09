/*
 * PickupController.cs
 * Script Author: Charles d'Ansembourg
 * Creation Date: 09/06/2024
 * Contact: c.dansembourg@icloud.com
 */

using UnityEngine;

namespace Brotato_Clone.Controllers
{
    public class PickupController : MonoBehaviour
    {
        private int _range;
        private PlayerController _playerController;

        public void Initialize(PlayerController playerController)
        {
            _range = 3 + playerController.Stats.PickupRange;
            _playerController = playerController;

            InvokeRepeating(nameof(ScanForMaterials), 0f, 0.1f);
        }

        private void ScanForMaterials()
        {
            Collider2D[] hitColliders = Physics2D.OverlapCircleAll(_playerController.PlayerObject.transform.position, _range);

            foreach (var hitCollider in hitColliders)
            {
                if (hitCollider.CompareTag("Material"))
                {
                    MaterialController materialController = hitCollider.GetComponent<MaterialController>();

                    materialController.PickUp(_playerController);
                }
            }
        }

        private void OnDrawGizmosSelected()
        {
            Gizmos.color = Color.green;
            Gizmos.DrawWireSphere(transform.position, _range);
        }
    }
}