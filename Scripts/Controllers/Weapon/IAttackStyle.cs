/*
 * IAttackStyle.cs
 * Script Author: Charles d'Ansembourg
 * Creation Date: 14/06/2024
 * Contact: c.dansembourg@icloud.com
 */

using Brotato_Clone.Interfaces;
using UnityEngine;

namespace Brotato_Clone
{
    public interface IAttackStyle
    {
        public void Attack(IWeaponMechanic controller, CircleCollider2D collider, float range, float duration, float returnDuration);
    }
}