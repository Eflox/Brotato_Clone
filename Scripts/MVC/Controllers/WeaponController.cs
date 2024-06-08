/*
 * WeaponController.cs
 * Script Author: Charles d'Ansembourg
 * Creation Date: 06/06/2024
 * Contact: c.dansembourg@icloud.com
 */

using Brotato_Clone.Interfaces;
using Brotato_Clone.Models;
using Brotato_Clone.Views;
using UnityEngine;

namespace Brotato_Clone.Controllers
{
    public class WeaponController : MonoBehaviour
    {
        [SerializeField]
        private WeaponView _weaponView;

        [SerializeField]
        private WeaponRotationController _weaponRotationController;

        private WeaponsController _weaponsController;
        private IWeaponMechanic _weaponMechanic;
        private Weapon _weapon;
        private float _attackCooldown = 0f;

        public void Initialize(Weapon weapon, WeaponsController weaponsController)
        {
            _weapon = weapon;

            _weaponsController = weaponsController;

            _weaponView.Initialize(weapon);

            _weaponMechanic = gameObject.AddComponent(_weapon.WeaponMechanic) as IWeaponMechanic;
            _weaponMechanic.Initialize(this, _weapon);

            _weaponRotationController.Initialize(_weapon);
        }

        private void Update()
        {
            HandleAutoAttack();
        }

        private void HandleAutoAttack()
        {
            if (!_weaponRotationController.IsAttacking)
                _attackCooldown -= Time.deltaTime;

            if (_attackCooldown <= 0f)
            {
                if (_weaponRotationController.EnemyInRange)
                {
                    _weaponRotationController.IsAttacking = true;
                    _weaponMechanic.Attack();
                    _attackCooldown = _weapon.Cooldown;
                }
            }
        }

        public void AttackFinished()
        {
            _weaponRotationController.IsAttacking = false;
        }

        public void Flip(bool right)
        {
            _weaponRotationController.Flip(right);
        }

        public void CheckDirection()
        {
            _weaponsController.CheckDirection();
        }

        private void OnDestroy()
        {
            Destroy(_weaponRotationController);
        }

        public void OnHit(Vector2 hitPosition)
        {
            _weaponView.OnHit(hitPosition);
        }
    }
}