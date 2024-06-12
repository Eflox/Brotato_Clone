/*
 * WeaponRotationController.cs
 * Script Author: Charles d'Ansembourg
 * Creation Date: 07/06/2024
 * Contact: c.dansembourg@icloud.com
 */

using UnityEngine;

namespace Brotato_Clone.Controllers
{
    public class WeaponRotationController : MonoBehaviour
    {
        private Transform _target;
        private bool _hasTarget = false;

        public void FoundTarget(Transform target)
        {
            _target = target;
            _hasTarget = true;
        }

        public void LostTarget()
        {
            ResetRotation();

            _target = null;
            _hasTarget = false;
        }

        private void Update()
        {
            if (_hasTarget)
                RotateTowardsTarget();
        }

        private void RotateTowardsTarget()
        {
            Vector3 direction = _target.position - transform.position;
            float angle = Mathf.Atan2(direction.y, direction.x) * Mathf.Rad2Deg;
            transform.rotation = Quaternion.Euler(0, 0, angle);
        }

        private void ResetRotation()
        {
            transform.rotation = Quaternion.Euler(0, 0, 0);
        }
    }
}