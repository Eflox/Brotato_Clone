/*
 * Weapon.cs
 * Script Author: Charles d'Ansembourg
 * Creation Date: 06/06/2024
 * Contact: c.dansembourg@icloud.com
 */

using Brotato_Clone.Models;

namespace Brotato_Clone
{
    public class Weapon : NItem
    {
        public int Damage;
        public float Cooldown;
        public int CritChance;
        public int Range;
        public int Knockback;
        public int LifeSteal;
    }
}