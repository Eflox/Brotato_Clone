/*
 * WeaponController.cs
 * Script Author: Charles d'Ansembourg
 * Creation Date: 06/06/2024
 * Contact: c.dansembourg@icloud.com
 */

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
        private WeaponTargetingController _weaponTargetingController;

        public void Initialize()
        {
            _weaponView = GetComponent<WeaponView>();

            _weaponTargetingController = GetComponent<WeaponTargetingController>();
            _weaponRotationController = GetComponent<WeaponRotationController>();
            _weaponAttackController = GetComponent<WeaponAttackController>();

            _weaponTargetingController.Initialize(this);
        }

        public void LoadWeapon(Weapon weapon)
        {
            _weaponView.Initialize(weapon);

            int range = weapon.WeaponType == WeaponType.Melee ? weapon.Range / 40 : weapon.Range / 20;

            _weaponTargetingController.SetRange(range);
            _weaponAttackController.SetupWeapon(weapon.Name, weapon.Cooldown, range);
        }

        public void TargetFound(Transform target)
        {
            _weaponRotationController.FoundTarget(target);
            _weaponAttackController.TargetFound();
            _weaponView.TargetStatus(true);
        }

        public void TargetLost()
        {
            _weaponAttackController.TargetLost();
            _weaponRotationController.LostTarget();
            _weaponView.TargetStatus(false);
        }

        public void OnHit(Vector2 hitPosition)
        {
            _weaponView.OnHit(hitPosition);
        }
    }
}