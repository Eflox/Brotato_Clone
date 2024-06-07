/*
 * WeaponRotationController.cs
 * Script Author: Charles d'Ansembourg
 * Creation Date: 07/06/2024
 * Contact: c.dansembourg@icloud.com
 */

using Brotato_Clone.Views;
using UnityEngine;

namespace Brotato_Clone.Controllers
{
    public class WeaponRotationController : MonoBehaviour
    {
        [SerializeField]
        private WeaponController _weaponController;

        [SerializeField]
        private WeaponView _weaponView;

        [SerializeField]
        private float detectionRange = 2.0f;

        private bool _shouldFlip = true;
        private bool _mobSearchReset = false;

        private void Update()
        {
            RotateTowardsNearestEnemy();
        }

        public void Flip(bool right)
        {
            if (_shouldFlip)
                _weaponView.Flip(right);
        }

        private void RotateTowardsNearestEnemy()
        {
            GameObject nearestEnemy = FindNearestEnemy();
            if (nearestEnemy != null)
            {
                _mobSearchReset = true;

                _weaponView.ResetFlip();
                _shouldFlip = false;

                Vector3 direction = nearestEnemy.transform.position - transform.position;
                float angle = Mathf.Atan2(direction.y, direction.x) * Mathf.Rad2Deg;
                transform.rotation = Quaternion.Euler(new Vector3(0, 0, angle));
            }
            else if (_mobSearchReset)
            {
                _mobSearchReset = false;
                _shouldFlip = true;
                transform.rotation = Quaternion.identity;
                _weaponController.CheckDirection();
            }
        }

        private GameObject FindNearestEnemy()
        {
            GameObject[] enemies = GameObject.FindGameObjectsWithTag("Mob");
            GameObject nearestEnemy = null;
            float minDistance = detectionRange;

            foreach (GameObject enemy in enemies)
            {
                float distance = Vector2.Distance(transform.position, enemy.transform.position);
                if (distance < minDistance)
                {
                    minDistance = distance;
                    nearestEnemy = enemy;
                }
            }

            return nearestEnemy;
        }
    }
}