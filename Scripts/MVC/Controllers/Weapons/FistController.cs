/*
 * Fist.cs
 * Script Author: Charles d'Ansembourg
 * Creation Date: 06/06/2024
 * Contact: c.dansembourg@icloud.com
 */

using Brotato_Clone.Interfaces;
using Brotato_Clone.Models;
using DG.Tweening;
using UnityEngine;

namespace Brotato_Clone.Controllers
{
    public class FistController : MonoBehaviour, IWeaponMechanic
    {
        private WeaponController _weaponController;
        private Weapon _weapon;

        private float PunchDuration = 0.08f;
        private float ReturnDuration = 0.3f;

        public void Initialize(WeaponController weaponController, Weapon weapon)
        {
            _weaponController = weaponController;
            _weapon = weapon;
        }

        public void Attack()
        {
            Vector3 punchDirection = transform.right * ((_weapon.Range / 30) / 2);
            Vector3 punchPosition = transform.localPosition + punchDirection;

            transform.DOLocalMove(punchPosition, PunchDuration)
                .OnComplete(() =>
                    transform.DOLocalMove(Vector3.zero, ReturnDuration)
                        .OnComplete(() => AttackFinish())
                );
        }

        public void AttackFinish()
        {
            _weaponController.AttackFinished();
        }
    }
}