/*
 * WeaponsData.cs
 * Script Author: Charles d'Ansembourg
 * Creation Date: 06/06/2024
 * Contact: c.dansembourg@icloud.com
 */

using Brotato_Clone.Controllers.Brotato_Clone.Controllers;
using System;
using System.Collections.Generic;
using UnityEngine;

namespace Brotato_Clone.Models
{
    public static class WeaponsData
    {
        public static readonly IReadOnlyDictionary<string, Weapon> Weapons;
        public static readonly IReadOnlyDictionary<string, Type> WeaponControllers;

        private static readonly string _assetSource = "Brotato";
        //private static readonly string _path = "Sprites/Weapons";

        static WeaponsData()
        {
            WeaponControllers = new Dictionary<string, Type>
            {
                { "Fist", typeof(FistController) },
                { "Knife", typeof(FistController) }
            };

            Weapons = new Dictionary<string, Weapon>
            {
                {
                    "Fist", new Weapon
                    {
                        Name = "Fist",
                        Description = "",
                        SpritePath = $"{_assetSource}/Sprites/Weapons/Icons/Fist",
                        Rarity = Rarity.Tier1,
                        Classes = new Class[] { Class.Weapon, Class.Unarmed },

                        Damage = 8,
                        Cooldown = 0.78f,
                        CritChance = 1,
                        CritDamage = 1.5f,
                        Range = 150,
                        Knockback = 15,
                        LifeSteal = 0,
                        WeaponSpritePath = $"{_assetSource}/Sprites/Weapons/Graphics/Fist",
                        WeaponType = WeaponType.Melee,
                        AttackType = AttackType.Thrust,
                        ImpactSound = Resources.Load<AudioClip>($"{_assetSource}/Audio/Weapons/Fist"),
                    }
                },
                {
                    "Knife", new Weapon
                    {
                        Name = "Knife",
                        Description = "",
                        SpritePath = $"{_assetSource}/Sprites/Weapons/Icons/Knife",
                        Rarity = Rarity.Tier1,
                        Classes = new Class[] { Class.Weapon, Class.Precise },

                        Damage = 6,
                        Cooldown = 1.01f,
                        CritChance = 20,
                        CritDamage = 2.5f,
                        Range = 150,
                        Knockback = 2,
                        LifeSteal = 0,
                        WeaponSpritePath = $"{_assetSource}/Sprites/Weapons/Graphics/Knife",
                        WeaponType = WeaponType.Melee,
                        AttackType = AttackType.Thrust,
                        ImpactSound = Resources.Load<AudioClip>($"{_assetSource}/Audio/Weapons/Fist"),
                    }
                },
            };
        }
    }
}