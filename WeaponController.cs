/*
 * WeaponController.cs
 * Script Author: Charles d'Ansembourg
 * Creation Date: 06/06/2024
 * Contact: c.dansembourg@icloud.com
 */

using Brotato_Clone.Interfaces;
using Brotato_Clone.Views;
using UnityEngine;

namespace Brotato_Clone.Controllers
{
    public class WeaponController : MonoBehaviour
    {
        private WeaponsController _weaponsController;

        [SerializeField]
        private WeaponView _weaponView;

        private IWeaponMechanic _weaponMechanic;

        [SerializeField]
        private WeaponRotationController _weaponRotationController;

        private Weapon _weapon;

        private float _attackCooldown = 0f;

        public void AttackFinished()
        {
            _weaponRotationController.IsAttacking = false;
        }

        private void Update()
        {
            if (Input.GetKeyDown(KeyCode.Space))
            {
                if (_weaponRotationController.EnemyInRange)
                    _weaponMechanic.Attack();
            }

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

        public void Initialize(Weapon weapon, WeaponsController weaponsController)
        {
            _weapon = weapon;

            _weaponsController = weaponsController;
            _weaponView.SetSprite(_weapon.Sprite);
            _weaponMechanic = gameObject.AddComponent(_weapon.WeaponMechanic) as IWeaponMechanic;
            _weaponMechanic.Initialize(this);
        }

        public void Flip(bool right)
        {
            _weaponRotationController.Flip(right);
        }

        public void CheckDirection()
        {
            _weaponsController.CheckDirection();
        }
    }
}