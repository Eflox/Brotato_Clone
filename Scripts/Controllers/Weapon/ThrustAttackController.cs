/*
 * ThrustAttackController.cs
 * Script Author: Charles d'Ansembourg
 * Creation Date: 14/06/2024
 * Contact: c.dansembourg@icloud.com
 */

using Brotato_Clone.Interfaces;
using DG.Tweening;
using UnityEngine;

namespace Brotato_Clone
{
    public class ThrustAttackController : MonoBehaviour
    {
        private float _offset = 0.5f;

        public void Attack(IWeaponMechanic controller, CircleCollider2D collider, float range, float duration, float returnDuration)
        {
            Vector3 punchDirection = transform.right * (range / 2);
            Vector3 punchPosition = transform.localPosition + punchDirection;

            collider.offset = new Vector2(_offset, 0);
            collider.enabled = true;

            transform.DOLocalMove(punchPosition, duration)
                .OnComplete(() =>
                {
                    collider.enabled = false;
                    transform.DOLocalMove(Vector3.zero, returnDuration)
                        .OnComplete(() => controller.AttackFinish());
                });
        }
    }
}