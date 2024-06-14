/*
 * WeaponAttackController.cs
 * Script Author: Charles d'Ansembourg
 * Creation Date: 12/06/2024
 * Contact: c.dansembourg@icloud.com
 */

using Brotato_Clone.Interfaces;
using Brotato_Clone.Models;
using UnityEngine;

namespace Brotato_Clone.Controllers
{
    public class WeaponAttackController : MonoBehaviour
    {
        private IWeaponMechanic _weaponMechanic;

        private float _weaponCooldown;
        private float _currentAttackCooldown;
        private bool _hasTarget = false;
        private bool _attackOngoing = false;

        public void SetupWeapon(string weaponName, float weaponCooldown, int range)
        {
            _weaponCooldown = weaponCooldown;
            _currentAttackCooldown = _weaponCooldown;

            _weaponMechanic = gameObject.AddComponent(WeaponsData.WeaponControllers[weaponName]) as IWeaponMechanic;
            _weaponMechanic.Initialize(range);
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
            _attackOngoing = false;
        }

        private void Update()
        {
            HandleAutoAttack();
        }

        private void HandleAutoAttack()
        {
            if (!_attackOngoing)
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