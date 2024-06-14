/*
 * Fist.cs
 * Script Author: Charles d'Ansembourg
 * Creation Date: 06/06/2024
 * Contact: c.dansembourg@icloud.com
 */

using Brotato_Clone.Interfaces;
using UnityEngine;

namespace Brotato_Clone.Controllers
{
    namespace Brotato_Clone.Controllers
    {
        public class FistController : MonoBehaviour, IWeaponMechanic
        {
            private WeaponAttackController _weaponAttackController;

            private IAttackStyle _attackStyle;

            //private float _punchDuration = 0.08f;
            //private float _returnDuration = 0.3f;
            private CircleCollider2D _circleCollider;

            private float _radius = 0.7f;

            private float _range;

            public void Initialize(float range)
            {
                _weaponAttackController = GetComponent<WeaponAttackController>();

                _range = range;

                _circleCollider = gameObject.AddComponent<CircleCollider2D>();
                _circleCollider.enabled = false;
                _circleCollider.isTrigger = true;
                _circleCollider.radius = _radius;

                //_attackStyle = WeaponAttackStylesData.StyleControllers[0]
            }

            public void AttackFinish()
            {
                _weaponAttackController.AttackFinished();
            }

            public void OnTriggerEnter2D(Collider2D collision)
            {
                if (collision.tag == "Mob")
                    Hit(collision.gameObject);
            }

            private void Hit(GameObject mob)
            {
                Vector2 hitDirection = (mob.transform.position - transform.position).normalized;
                mob.GetComponent<MobController>().GetHit(1, 15, hitDirection);
            }

            public void Attack()
            {
                //_attackStyle.Attack(this, _circleCollider, _range, _punchDuration, _returnDuration);
            }
        }
    }
}