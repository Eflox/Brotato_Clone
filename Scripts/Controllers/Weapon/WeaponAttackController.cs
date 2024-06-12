/*
 * WeaponAttackController.cs
 * Script Author: Charles d'Ansembourg
 * Creation Date: 12/06/2024
 * Contact: c.dansembourg@icloud.com
 */

using Brotato_Clone.Interfaces;
using UnityEngine;

namespace Brotato_Clone.Controllers
{
    public class WeaponAttackController : MonoBehaviour
    {
        private WeaponController _weaponController;
        private IWeaponMechanic _weaponMechanic;

        private float _weaponCooldown;
        private float _currentAttackCooldown;
        private bool _hasTarget = false;
        private bool _attackOngoing = false;

        public void SetupWeapon(float weaponCooldown, IWeaponMechanic weaponMechanic, WeaponController weaponController)
        {
            _weaponCooldown = weaponCooldown;
            _currentAttackCooldown = _weaponCooldown;
        }

        public void TargetFound()
        {
            _hasTarget = true;
        }

        public void TargetLost()
        {
            _hasTarget = false;
        }

        public void AttackFinished()
        {
            _hasTarget = false;
        }

        private void Update()
        {
            HandleAutoAttack();
        }

        private void HandleAutoAttack()
        {
            if (_attackOngoing)
                _currentAttackCooldown -= Time.deltaTime;

            if (_currentAttackCooldown <= 0f)
            {
                if (_hasTarget)
                {
                    _attackOngoing = true;
                    _weaponMechanic.Attack();
                    _currentAttackCooldown = _weaponCooldown;
                }
            }
        }
    }
}