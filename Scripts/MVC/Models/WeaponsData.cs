/*
 * WeaponsData.cs
 * Script Author: Charles d'Ansembourg
 * Creation Date: 06/06/2024
 * Contact: c.dansembourg@icloud.com
 */

using System.Collections.Generic;
using UnityEngine;

namespace Brotato_Clone.Models
{
    public static class WeaponsData
    {
        public static readonly IReadOnlyDictionary<string, Weapon> Weapons;

        static WeaponsData()
        {
            Weapons = new Dictionary<string, Weapon>
            {
                {
                    "Fist", new Weapon
                    {
                        Name = "Fist",
                        Description = "",
                        Icon = Resources.Load<Sprite>("Weapons/Fist"),
                        Rarity = Rarity.Common,
                        Classes = new Class[] { Class.Unarmed },

                        Damage = 8,
                        Cooldown = 0.78f,
                        CritChance = 1,
                        CritDamage = 1.5f,
                        Range = 150,
                        Knockback = 15,
                        LifeSteal = 0,

                        //WeaponMechanic = new FistController()
                    }
                }
            };
        }
    }
}