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
        private WeaponView _weaponView;

        private WeaponRotationController _weaponRotationController;
        private WeaponAttackController _weaponAttackController;

        public void Initialize()
        {
            _weaponRotationController = GetComponent<WeaponRotationController>();
            _weaponAttackController = GetComponent<WeaponAttackController>();
        }

        public void Attack()
        {
        }

        public void AttackFinished()
        {
            _weaponAttackController.AttackFinished();
        }

        public void LoadWeapon(Weapon weapon)
        {
            _weaponView.Initialize(weapon);

            IWeaponMechanic weaponMechanic = gameObject.AddComponent(weapon.WeaponMechanic) as IWeaponMechanic;
            weaponMechanic.Initialize(this, weapon);

            _weaponAttackController.SetupWeapon(weapon.Cooldown, weaponMechanic, this);
        }

        public void TargetFound(Transform target)
        {
            _weaponRotationController.FoundTarget(target);
            _weaponAttackController.TargetFound();
        }

        public void TargetLost()
        {
            _weaponAttackController.TargetLost();
            _weaponRotationController.LostTarget();
        }

        public void OnHit(Vector2 hitPosition)
        {
            _weaponView.OnHit(hitPosition);
        }
    }
}