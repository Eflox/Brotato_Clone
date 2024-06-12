/*
 * PlayerPickupController.cs
 * Script Author: Charles d'Ansembourg
 * Creation Date: 11/06/2024
 * Contact: c.dansembourg@icloud.com
 */

using Brotato_Clone.Controllers;
using UnityEngine;

namespace Brotato_Clone
{
    public class PlayerPickupController : MonoBehaviour
    {
        private int _range;

        private GameObject _playerObject;

        public void StartPickupSearch(int pickupRange, GameObject playerObject)
        {
            _playerObject = playerObject;

            _range = pickupRange + 4;
            InvokeRepeating(nameof(ScanForMaterials), 0f, 0.05f);
        }

        public void UpdateRange(int pickupRange) => _range = pickupRange;

        public void StopSearch()
        {
            CancelInvoke(nameof(ScanForMaterials));
        }

        private void ScanForMaterials()
        {
            Collider2D[] hitColliders = Physics2D.OverlapCircleAll(_playerObject.transform.position, _range);

            foreach (var hitCollider in hitColliders)
            {
                if (hitCollider.CompareTag("Material"))
                {
                    MaterialController materialController = hitCollider.GetComponent<MaterialController>();

                    materialController.PickUp(_playerObject.transform);
                }
            }
        }
    }
}