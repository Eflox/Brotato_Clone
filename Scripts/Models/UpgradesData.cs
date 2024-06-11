/*
 * UpgradesData.cs
 * Script Author: Charles d'Ansembourg
 * Creation Date: 10/06/2024
 * Contact: c.dansembourg@icloud.com
 */

using System.Collections.Generic;
using UnityEngine;

namespace Brotato_Clone.Models
{
    public static class UpgradesData
    {
        public static readonly IReadOnlyDictionary<int, Upgrade> Upgrades;

        private static readonly string _assetSource = "Brotato";

        static UpgradesData()
        {
            Upgrades = new Dictionary<int, Upgrade>
            {
                {
                    0,
                    new Upgrade
                    {
                        Name = "Heart",
                        Description = "[g]+3[c] Max HP",
                        Icon = Resources.Load<Sprite>($"{_assetSource}/Sprites/Upgrades/Max_HP_Upgrade"),
                        Rarity = Rarity.Common,
                        Attribute = null
                    }
                },
                {
                    1,
                    new Upgrade
                    {
                        Name = "Lungs",
                        Description = "[g]+2[c] HP Regeneration",
                        Icon = Resources.Load<Sprite>($"{_assetSource}/Sprites/Upgrades/HP_Regeneration_Upgrade"),
                        Rarity = Rarity.Common,
                        Attribute = null
                    }
                },
                {
                    2,
                    new Upgrade
                    {
                        Name = "Teeth",
                        Description = "[g]+1[c] Life Steal",
                        Icon = Resources.Load<Sprite>($"{_assetSource}/Sprites/Upgrades/Life_Steal_Upgrade"),
                        Rarity = Rarity.Common,
                        Attribute = null
                    }
                },
                {
                    3,
                    new Upgrade
                    {
                        Name = "Triceps",
                        Description = "[g]+5[c] Damage",
                        Icon = Resources.Load<Sprite>($"{_assetSource}/Sprites/Upgrades/Damage_Upgrade"),
                        Rarity = Rarity.Common,
                        Attribute = null
                    }
                },
                {
                    4,
                    new Upgrade
                    {
                        Name = "Forearms",
                        Description = "[g]+2[c] Melee Damage",
                        Icon = Resources.Load<Sprite>($"{_assetSource}/Sprites/Upgrades/Melee_Damage_Upgrade"),
                        Rarity = Rarity.Common,
                        Attribute = null
                    }
                },
                {
                    5,
                    new Upgrade
                    {
                        Name = "Shoulders",
                        Description = "[g]+1[c] Ranged Damage",
                        Icon = Resources.Load<Sprite>($"{_assetSource}/Sprites/Upgrades/Ranged_Damage_Upgrade"),
                        Rarity = Rarity.Common,
                        Attribute = null
                    }
                },
                {
                    6,
                    new Upgrade
                    {
                        Name = "Brain",
                        Description = "[g]+1[c] Elemental Damage",
                        Icon = Resources.Load<Sprite>($"{_assetSource}/Sprites/Upgrades/Elemental_Damage_Upgrade"),
                        Rarity = Rarity.Common,
                        Attribute = null
                    }
                },
                {
                    7,
                    new Upgrade
                    {
                        Name = "Reflexes",
                        Description = "[g]+5[c] Attack Speed",
                        Icon = Resources.Load<Sprite>($"{_assetSource}/Sprites/Upgrades/Attack_Speed_Upgrade"),
                        Rarity = Rarity.Common,
                        Attribute = null
                    }
                },
                {
                    8,
                    new Upgrade
                    {
                        Name = "Fingers",
                        Description = "[g]+3[c] Crit Chance",
                        Icon = Resources.Load<Sprite>($"{_assetSource}/Sprites/Upgrades/Crit_Chance_Upgrade"),
                        Rarity = Rarity.Common,
                        Attribute = null
                    }
                },
                {
                    9,
                    new Upgrade
                    {
                        Name = "Skull",
                        Description = "[g]+2[c] Engineering",
                        Icon = Resources.Load<Sprite>($"{_assetSource}/Sprites/Upgrades/Engineering_Upgrade"),
                        Rarity = Rarity.Common,
                        Attribute = null
                    }
                },
                {
                    10,
                    new Upgrade
                    {
                        Name = "Eyes",
                        Description = "[g]+15[c] Range",
                        Icon = Resources.Load<Sprite>($"{_assetSource}/Sprites/Upgrades/Range_Upgrade"),
                        Rarity = Rarity.Common,
                        Attribute = null
                    }
                },
                {
                    11,
                    new Upgrade
                    {
                        Name = "Chest",
                        Description = "[g]+1[c] Armor",
                        Icon = Resources.Load<Sprite>($"{_assetSource}/Sprites/Upgrades/Armor_Upgrade"),
                        Rarity = Rarity.Common,
                        Attribute = null
                    }
                },
                {
                    12,
                    new Upgrade
                    {
                        Name = "Back",
                        Description = "[g]+3[c] Dodge",
                        Icon = Resources.Load<Sprite>($"{_assetSource}/Sprites/Upgrades/Dodge_Upgrade"),
                        Rarity = Rarity.Common,
                        Attribute = null
                    }
                },
                {
                    13,
                    new Upgrade
                    {
                        Name = "Legs",
                        Description = "[g]+3[c] Speed",
                        Icon = Resources.Load<Sprite>($"{_assetSource}/Sprites/Upgrades/Speed_Upgrade"),
                        Rarity = Rarity.Common,
                        Attribute = null
                    }
                },
                {
                    14,
                    new Upgrade
                    {
                        Name = "Nose",
                        Description = "[g]+5[c] Luck",
                        Icon = Resources.Load<Sprite>($"{_assetSource}/Sprites/Upgrades/Luck_Upgrade"),
                        Rarity = Rarity.Common,
                        Attribute = null
                    }
                },
                {
                    15,
                    new Upgrade
                    {
                        Name = "Hands",
                        Description = "[g]+5[c] Harvesting",
                        Icon = Resources.Load<Sprite>($"{_assetSource}/Sprites/Upgrades/Crit_Chance_Upgrade"),
                        Rarity = Rarity.Common,
                        Attribute = null
                    }
                },
            };
        }
    }
}