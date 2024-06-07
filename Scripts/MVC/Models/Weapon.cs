/*
 * Weapon.cs
 * Script Author: Charles d'Ansembourg
 * Creation Date: 06/06/2024
 * Contact: c.dansembourg@icloud.com
 */

using Brotato_Clone.Interfaces;
using Brotato_Clone.Models;
using UnityEngine;

namespace Brotato_Clone
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

        public IWeaponMechanic WeaponMechanic;
    }
}