/*
 * UpgradesData.cs
 * Script Author: Charles d'Ansembourg
 * Creation Date: 10/06/2024
 * Contact: c.dansembourg@icloud.com
 */

using System.Collections.Generic;

namespace Brotato_Clone.Models
{
    public static class UpgradesData
    {
        public static readonly IReadOnlyDictionary<int, Upgrade> Upgrades;

        private static readonly string _assetSource = "Brotato";
        private static readonly string _path = "Sprites/Upgrades";

        static UpgradesData()
        {
            string fullPath = $"{_assetSource}/{_path}/";

            Upgrades = new Dictionary<int, Upgrade>
            {
                {
                    0,
                    new Upgrade
                    {
                        Name = "Heart",
                        Description = "[g]+3[c] Max HP",
                        SpritePath = $"{fullPath}Max_HP_Upgrade",
                        Classes = new Class[] { Class.Upgrade },
                        Rarity = Rarity.Common,
                    }
                },
                {
                    1,
                    new Upgrade
                    {
                        Name = "Lungs",
                        Description = "[g]+2[c] HP Regeneration",
                        SpritePath = $"{fullPath}HP_Regeneration_Upgrade",
                        Classes = new Class[] { Class.Upgrade },
                        Rarity = Rarity.Common,
                    }
                },
                {
                    2,
                    new Upgrade
                    {
                        Name = "Teeth",
                        Description = "[g]+1[c] Life Steal",
                        SpritePath = $"{fullPath}Life_Steal_Upgrade",
                        Classes = new Class[] { Class.Upgrade },
                        Rarity = Rarity.Common,
                    }
                },
                {
                    3,
                    new Upgrade
                    {
                        Name = "Triceps",
                        Description = "[g]+5[c] Damage",
                        SpritePath = $"{fullPath}Damage_Upgrade",
                        Classes = new Class[] { Class.Upgrade },
                        Rarity = Rarity.Common,
                    }
                },
                {
                    4,
                    new Upgrade
                    {
                        Name = "Forearms",
                        Description = "[g]+2[c] Melee Damage",
                        SpritePath = $"{fullPath}Melee_Damage_Upgrade",
                        Classes = new Class[] { Class.Upgrade },
                        Rarity = Rarity.Common,
                    }
                },
                {
                    5,
                    new Upgrade
                    {
                        Name = "Shoulders",
                        Description = "[g]+1[c] Ranged Damage",
                        SpritePath = $"{fullPath}Ranged_Damage_Upgrade",
                        Classes = new Class[] { Class.Upgrade },
                        Rarity = Rarity.Common,
                    }
                },
                {
                    6,
                    new Upgrade
                    {
                        Name = "Brain",
                        Description = "[g]+1[c] Elemental Damage",
                        SpritePath = $"{fullPath}Elemental_Damage_Upgrade",
                        Classes = new Class[] { Class.Upgrade },
                        Rarity = Rarity.Common,
                    }
                },
                {
                    7,
                    new Upgrade
                    {
                        Name = "Reflexes",
                        Description = "[g]+5[c] Attack Speed",
                        SpritePath = $"{fullPath}Attack_Speed_Upgrade",
                        Classes = new Class[] { Class.Upgrade },
                        Rarity = Rarity.Common,
                    }
                },
                {
                    8,
                    new Upgrade
                    {
                        Name = "Fingers",
                        Description = "[g]+3[c] Crit Chance",
                        SpritePath = $"{fullPath}Crit_Chance_Upgrade",
                        Classes = new Class[] { Class.Upgrade },
                        Rarity = Rarity.Common,
                    }
                },
                {
                    9,
                    new Upgrade
                    {
                        Name = "Skull",
                        Description = "[g]+2[c] Engineering",
                        SpritePath = $"{fullPath}Engineering_Upgrade",
                        Classes = new Class[] { Class.Upgrade },
                        Rarity = Rarity.Common,
                    }
                },
                {
                    10,
                    new Upgrade
                    {
                        Name = "Eyes",
                        Description = "[g]+15[c] Range",
                        SpritePath = $"{fullPath}Range_Upgrade",
                        Classes = new Class[] { Class.Upgrade },
                        Rarity = Rarity.Common,
                    }
                },
                {
                    11,
                    new Upgrade
                    {
                        Name = "Chest",
                        Description = "[g]+1[c] Armor",
                        SpritePath = $"{fullPath}Armor_Upgrade",
                        Classes = new Class[] { Class.Upgrade },
                        Rarity = Rarity.Common,
                    }
                },
                {
                    12,
                    new Upgrade
                    {
                        Name = "Back",
                        Description = "[g]+3[c] Dodge",
                        SpritePath = $"{fullPath}Dodge_Upgrade",
                        Classes = new Class[] { Class.Upgrade },
                        Rarity = Rarity.Common,
                    }
                },
                {
                    13,
                    new Upgrade
                    {
                        Name = "Legs",
                        Description = "[g]+3[c] Speed",
                        SpritePath = $"{fullPath}Speed_Upgrade",
                        Classes = new Class[] { Class.Upgrade },
                        Rarity = Rarity.Common,
                    }
                },
                {
                    14,
                    new Upgrade
                    {
                        Name = "Nose",
                        Description = "[g]+5[c] Luck",
                        SpritePath = $"{fullPath}Luck_Upgrade",
                        Classes = new Class[] { Class.Upgrade },
                        Rarity = Rarity.Common,
                    }
                },
                {
                    15,
                    new Upgrade
                    {
                        Name = "Hands",
                        Description = "[g]+5[c] Harvesting",
                        SpritePath = $"{fullPath}Harvesting_Upgrade",
                        Classes = new Class[] { Class.Upgrade },
                        Rarity = Rarity.Common,
                    }
                },
            };
        }
    }
}