/*
 * WeaponTargetingController.cs
 * Script Author: Charles d'Ansembourg
 * Creation Date: 07/06/2024
 * Contact: c.dansembourg@icloud.com
 */

using UnityEngine;

namespace Brotato_Clone.Controllers
{
    public class WeaponTargetingController : MonoBehaviour
    {
        private float _range;
        private GameObject _currentTarget;

        private WeaponController _weaponController;

        public void Initialize(WeaponController weaponController)
        {
            _weaponController = weaponController;
        }

        public void SetRange(int range)
        {
            _range = range;
        }

        private void Update()
        {
            FindAndNotifyNearestEnemy();
        }

        private void FindAndNotifyNearestEnemy()
        {
            GameObject nearestEnemy = FindNearestEnemy();
            if (nearestEnemy != null)
            {
                float distance = Vector2.Distance(transform.position, nearestEnemy.transform.position);
                bool enemyInRange = distance < _range;

                if (enemyInRange && _currentTarget != nearestEnemy)
                {
                    _currentTarget = nearestEnemy;
                    _weaponController.TargetFound(nearestEnemy.transform);
                }
                else if (!enemyInRange && _currentTarget != null)
                {
                    _currentTarget = null;
                    _weaponController.TargetLost();
                }
            }
            else if (_currentTarget != null)
            {
                _currentTarget = null;
                _weaponController.TargetLost();
            }
        }

        private GameObject FindNearestEnemy()
        {
            GameObject[] enemies = GameObject.FindGameObjectsWithTag("Mob");
            GameObject nearestEnemy = null;
            float minDistance = float.MaxValue;

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