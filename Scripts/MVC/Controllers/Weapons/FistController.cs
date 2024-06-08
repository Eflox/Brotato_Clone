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

        private float _punchDuration = 0.08f;
        private float _returnDuration = 0.3f;
        private CircleCollider2D _circleCollider;

        private float _radius = 0.4f;
        private float _offset = 0.5f;

        public void Initialize(WeaponController weaponController, Weapon weapon)
        {
            _weaponController = weaponController;
            _weapon = weapon;

            _circleCollider = gameObject.AddComponent<CircleCollider2D>();
            _circleCollider.enabled = false;
            _circleCollider.isTrigger = true;
            _circleCollider.radius = _radius;
        }

        public void Attack()
        {
            Vector3 punchDirection = transform.right * ((_weapon.Range / 30) / 2);
            Vector3 punchPosition = transform.localPosition + punchDirection;

            _circleCollider.offset = new Vector2(_offset, 0);
            _circleCollider.enabled = true;

            transform.DOLocalMove(punchPosition, _punchDuration)
                .OnComplete(() =>
                {
                    _circleCollider.enabled = false;
                    transform.DOLocalMove(Vector3.zero, _returnDuration)
                        .OnComplete(() => AttackFinish());
                });
        }

        public void AttackFinish()
        {
            _weaponController.AttackFinished();
        }

        public void OnTriggerEnter2D(Collider2D collision)
        {
            if (collision.tag == "Mob")
                Hit(collision.gameObject);
        }

        private void Hit(GameObject mob)
        {
            Vector2 hitDirection = (mob.transform.position - transform.position).normalized;
            mob.GetComponent<MobController>().GetHit(5, 15, hitDirection);

            _weaponController.OnHit(mob.transform.position);
        }
    }
}