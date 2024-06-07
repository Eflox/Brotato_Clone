/*
 * Fist.cs
 * Script Author: Charles d'Ansembourg
 * Creation Date: 06/06/2024
 * Contact: c.dansembourg@icloud.com
 */

using Brotato_Clone.Interfaces;
using DG.Tweening;
using UnityEngine;

namespace Brotato_Clone.Controllers
{
    public class FistController : MonoBehaviour, IWeaponMechanic
    {
        private float PunchDistance = 1.0f;
        private float PunchDuration = 0.2f;
        private float ReturnDuration = 0.2f;

        public void Attack()
        {
            Vector3 punchDirection = transform.right * PunchDistance;
            Vector3 punchPosition = transform.localPosition + punchDirection;

            transform.DOLocalMove(punchPosition, PunchDuration)
                .OnComplete(() =>
                    transform.DOLocalMove(Vector3.zero, ReturnDuration)
                );

            Debug.Log("Fist Attacked");
        }
    }
}