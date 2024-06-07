/*
 * WeaponRotationController.cs
 * Script Author: Charles d'Ansembourg
 * Creation Date: 07/06/2024
 * Contact: c.dansembourg@icloud.com
 */

using Brotato_Clone.Models;
using Brotato_Clone.Views;
using UnityEngine;

namespace Brotato_Clone.Controllers
{
    public class WeaponRotationController : MonoBehaviour
    {
        public bool EnemyInRange = false;
        public bool IsAttacking = false;
        private bool _rotatedWeapon = false;

        [SerializeField]
        private WeaponController _weaponController;

        [SerializeField]
        private WeaponView _weaponView;

        private Weapon _weapon;
        private bool _shouldFlip = true;

        private float _attackDistance;

        public void Initialize(Weapon weapon)
        {
            _weapon = weapon;

            _attackDistance = (_weapon.Range / 13) / 2;

            if (_weapon.WeaponType == WeaponType.Melee)
                _attackDistance /= 2;
        }

        private void Update()
        {
            if (!IsAttacking)
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
                _rotatedWeapon = true;

                float distance = Vector2.Distance(transform.position, nearestEnemy.transform.position);
                if (distance < _attackDistance)
                    EnemyInRange = true;

                _weaponView.ResetFlip();
                _shouldFlip = false;

                Vector3 direction = nearestEnemy.transform.position - transform.position;
                float angle = Mathf.Atan2(direction.y, direction.x) * Mathf.Rad2Deg;
                transform.rotation = Quaternion.Euler(new Vector3(0, 0, angle));
            }
            else if (_rotatedWeapon)
            {
                _rotatedWeapon = false;
                EnemyInRange = false;
                _shouldFlip = true;
                transform.rotation = Quaternion.identity;
                _weaponController.CheckDirection();
            }
        }

        private GameObject FindNearestEnemy()
        {
            GameObject[] enemies = GameObject.FindGameObjectsWithTag("Mob");
            GameObject nearestEnemy = null;

            foreach (GameObject enemy in enemies)
            {
                float distance = Vector2.Distance(transform.position, enemy.transform.position);
                if (distance < _attackDistance + 1)
                    nearestEnemy = enemy;
            }

            return nearestEnemy;
        }

        private void OnDestroy()
        {
            transform.rotation = Quaternion.identity;
        }
    }
}