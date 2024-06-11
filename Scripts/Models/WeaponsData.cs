/*
 * WeaponsData.cs
 * Script Author: Charles d'Ansembourg
 * Creation Date: 06/06/2024
 * Contact: c.dansembourg@icloud.com
 */

using Brotato_Clone.Controllers;
using System.Collections.Generic;
using UnityEngine;

namespace Brotato_Clone.Models
{
    public static class WeaponsData
    {
        public static readonly IReadOnlyDictionary<string, Weapon> Weapons;

        private static readonly string _assetSource = "Brotato";

        static WeaponsData()
        {
            Weapons = new Dictionary<string, Weapon>
            {
                {
                    "Fist", new Weapon
                    {
                        Name = "Fist",
                        Description = "",
                        Icon = Resources.Load<Sprite>($"{_assetSource}/Sprites/Weapons/Icons/Fist"),
                        Rarity = Rarity.Common,
                        Classes = new Class[] { Class.Unarmed },

                        Damage = 8,
                        Cooldown = 0.78f,
                        CritChance = 1,
                        CritDamage = 1.5f,
                        Range = 150,
                        Knockback = 15,
                        LifeSteal = 0,
                        Sprite = Resources.Load<Sprite>($"{_assetSource}/Sprites/Weapons/Graphics/Fist"),
                        WeaponType = WeaponType.Melee,
                        AttackType = AttackType.Thrust,
                        WeaponMechanic = typeof(FistController),
                        ImpactSound = Resources.Load<AudioClip>($"{_assetSource}/Audio/Weapons/Fist"),
                    }
                },
                {
                    "Knife", new Weapon
                    {
                        Name = "Knife",
                        Description = "",
                        Icon = Resources.Load<Sprite>($"{_assetSource}/Sprites/Weapons/Icons/Knife"),
                        Rarity = Rarity.Common,
                        Classes = new Class[] { Class.Precise },

                        Damage = 6,
                        Cooldown = 1.01f,
                        CritChance = 20,
                        CritDamage = 2.5f,
                        Range = 150,
                        Knockback = 2,
                        LifeSteal = 0,
                        Sprite = Resources.Load<Sprite>($"{_assetSource}/Sprites/Weapons/Graphics/Knife"),
                        WeaponType = WeaponType.Melee,
                        AttackType = AttackType.Thrust,
                        WeaponMechanic = typeof(FistController),
                        ImpactSound = Resources.Load<AudioClip>($"{_assetSource}/Audio/Weapons/Fist"),
                    }
                },
            };
        }
    }
}