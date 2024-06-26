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
    [Serializable]
    public class Weapon : Item
    {
        public int Damage;
        public float Cooldown;
        public int CritChance;
        public float CritDamage;
        public int Range;
        public int Knockback;
        public int LifeSteal;
        public string WeaponSpritePath;
        public AttackType AttackType;
        public WeaponType WeaponType;
        public AudioClip ImpactSound;
    }

    public enum AttackType
    {
        None,
        Thrust,
        Sweep
    }

    public enum WeaponType
    {
        Range,
        Melee
    }
}