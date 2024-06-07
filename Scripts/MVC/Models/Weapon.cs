/*
 * Weapon.cs
 * Script Author: Charles d'Ansembourg
 * Creation Date: 06/06/2024
 * Contact: c.dansembourg@icloud.com
 */

using System;
using UnityEngine;

namespace Brotato_Clone.Models
{
    public class Weapon : NItem
    {
        public int Damage;
        public float Cooldown;
        public int CritChance;
        public float CritDamage;
        public int Range;
        public int Knockback;
        public int LifeSteal;
        public Sprite Sprite;
        public AttackType AttackType;
        public Type WeaponMechanic;
    }

    public enum AttackType
    {
        None,
        Thrust,
        Sweep
    }
}