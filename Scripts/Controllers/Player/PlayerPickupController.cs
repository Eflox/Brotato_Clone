/*
 * PlayerPickupController.cs
 * Script Author: Charles d'Ansembourg
 * Creation Date: 11/06/2024
 * Contact: c.dansembourg@icloud.com
 */

using UnityEngine;

namespace Brotato_Clone.Controllers
{
    /// <summary>
    /// Controls the player pickup actions, scanning for materials within a specified range.
    /// </summary>
    public class PlayerPickupController : MonoBehaviour
    {
        #region Fields

        private int _range;
        private GameObject _playerObject;

        #endregion Fields

        #region Public Methods

        /// <summary>
        /// Starts searching for pickups within the specified range.
        /// </summary>
        public void StartPickupSearch(int pickupRange, GameObject playerObject)
        {
            _playerObject = playerObject;
            _range = pickupRange + 4;
            InvokeRepeating(nameof(ScanForMaterials), 0f, 0.05f);
        }

        /// <summary>
        /// Updates the range within which pickups are searched.
        /// </summary>
        public void UpdateRange(int pickupRange) => _range = pickupRange;

        /// <summary>
        /// Stops the search for pickups.
        /// </summary>
        public void StopSearch()
        {
            CancelInvoke(nameof(ScanForMaterials));
        }

        #endregion Public Methods

        #region Private Methods

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

        #endregion Private Methods
    }
}