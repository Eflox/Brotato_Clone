/*
 * ItemsData.cs
 * Script Author: Charles d'Ansembourg
 * Creation Date: 05/06/2024
 * Contact: c.dansembourg@icloud.com
 */

using Brotato_Clone.Interfaces;
using System.Collections.Generic;
using System.Linq;

namespace Brotato_Clone.Models
{
    public static class ItemsData
    {
        public static readonly IReadOnlyDictionary<string, NItem> Items;
        public static readonly IReadOnlyDictionary<string, IAttribute> ItemAttributes;

        private static readonly string _assetSource = "Brotato";

        static ItemsData()
        {
            ItemAttributes = new Dictionary<string, IAttribute>
            {
                { "WellRounded", new WellRoundedAttribute() },
                { "Brawler", new BrawlerAttributeData() }
            };

            Items = new Dictionary<string, NItem>
            {
                {
                    "WellRounded", new NItem
                    {
                        Name = "WellRounded",
                        Description = "[g]+5[c] Max Hp[nl][g]+5%[c] Speed[nl][g]+8[c] Harvesting",
                        SpritePath = $"{_assetSource}/Sprites/Characters/Well_Rounded",
                        Rarity = Rarity.Common,
                        Classes = new Class[] { Class.Character },
                    }
                },
                {
                    "Brawler", new NItem
                    {
                        Name = "Brawler",
                        Description = "[g]+50%[c] Attack Speed with [g]Unarmed[c] weapons [nl]You start with [g]1 Fist[c] [nl][g]+15%[c] Dodge [nl][r]-50[c] Range [nl][r]-50[c] Ranged Damage",
                        SpritePath = $"{_assetSource}/Sprites/Characters/Brawler",
                        Rarity = Rarity.Common,
                        Classes = new Class[] { Class.Character },
                        Attribute = new BrawlerAttributeData()
                    }
                },
                {
                    "Crazy", new NItem
                    {
                        Name = "Crazy",
                        Description = "[g]+100 Range[c] with [g]Precise[c] weapons [nl][g]+25%[c] Attack Speed [nl]You start with [g]1 Knife[c] [nl][r]-30%[c] Dodge [nl][r]-10[c] Engineering [nl][r]-10[c] Ranged Damage",
                        SpritePath = $"{_assetSource}/Sprites/Characters/Crazy",
                        Rarity = Rarity.Common,
                        Classes = new Class[] { Class.Character },
                        Attribute = new BrawlerAttributeData()
                    }
                },
                {
                    "Ranger", new NItem
                    {
                        Name = "Ranger",
                        Description = "[g]+50[c] Range [nl]You start with [g]1 Pistol[c] [nl][g]Ranged Damage[c] modifications are increased by [g]50%[c] [nl]You can't equip melee weapons [nl][r]Max HP[c] modifications are reduced by [r]25%[c]",
                        SpritePath = $"{_assetSource}/Sprites/Characters/Ranger",
                        Rarity = Rarity.Common,
                        Classes = new Class[] { Class.Character },
                        Attribute = null
                    }
                },
                {
                    "Mage", new NItem
                    {
                        Name = "Mage",
                        Description = "[g]Elemental Damage[c] modifications are increased by [g]33%[c] [nl]You start with [g]1 Snake[c] [nl]You start with [g]1 Scared Sausage[c] [nl][r]Melee Damage[c] Modifications are reduced by [r]-100%[c] [nl][r]Ranged Damage[c] Modifications are reduced by [r]-100%[c] [nl][r]Engineering[c] Modifications are reduced by [r]-100%[c]",
                        SpritePath = $"{_assetSource}/Sprites/Characters/Mage",
                        Rarity = Rarity.Common,
                        Classes = new Class[] { Class.Character },
                        Attribute = null
                    }
                },
                {
                    "Chunky", new NItem
                    {
                        Name = "Chunky",
                        Description = "[g]Max HP[c] modifications are increased by [g]25%[c] [nl][g]+1%[c] Damage for every [g]3 Max HP[c] you have [g]+3[c] [nl][g]+3[c] HP recovered from consumables [nl][r]-100%[c] Life Steal [nl][r]HP Regeneration[c] modifications are reduced by [r]50%[c] [nl][r]Dodge[c] modifications are reduced by [r]50%[c] [nl][r]Speed[c] modifications are reduced by [r]100%[c]",
                        SpritePath = $"{_assetSource}/Sprites/Characters/Chunky",
                        Rarity = Rarity.Common,
                        Classes = new Class[] { Class.Character },
                        Attribute = null
                    }
                },
                {
                    "Old", new NItem
                    {
                        Name = "Old",
                        Description = "[g]-25%[c] Enemy speed [nl][g]+10[c] Harvesting [nl]-33% Map Size [nl]-10% Enemies [nl][r]-10%[c] Speed",
                        SpritePath = $"{_assetSource}/Sprites/Characters/Old",
                        Rarity = Rarity.Common,
                        Classes = new Class[] { Class.Character },
                        Attribute = null
                    }
                },
                {
                    "Lucky", new NItem
                    {
                        Name = "Lucky",
                        Description = "[g]+100[c] Luck [nl][g]Luck[c] modifications are increased by [g]25%[c] [nl][g]+75%[c] chance to deal [g]1[c] (15% Luck) damage to a random enemy when you pick up a material [nl][r]-60%[c] Attack Speed [nl][r]-50%[c] XP Gain",
                        SpritePath = $"{_assetSource}/Sprites/Characters/Lucky",
                        Rarity = Rarity.Common,
                        Classes = new Class[] { Class.Character },
                        Attribute = null
                    }
                },
                {
                    "Mutant", new NItem
                    {
                        Name = "Mutant",
                        Description = "[g]+200%[c] XP Gain [nl][r]+50%[c] Items Price",
                        SpritePath = $"{_assetSource}/Sprites/Characters/Mutant",
                        Rarity = Rarity.Common,
                        Classes = new Class[] { Class.Character },
                        Attribute = null
                    }
                },
                {
                    "Generalist", new NItem
                    {
                        Name = "Generalist",
                        Description = "[g]+2 Melee Damage[c] for every [g]1 Ranged Damage[c] you have [nl][g]+1 Ranged Damage[c] for every [g]2 Melee Damage[c] you have [nl]You can only equip [r]3[c] melee weapons and [r]3[c] ranged weapons at a time",
                        SpritePath = $"{_assetSource}/Sprites/Characters/Generalist",
                        Rarity = Rarity.Common,
                        Classes = new Class[] { Class.Character },
                        Attribute = null
                    }
                },
                {
                    "Loud", new NItem
                    {
                        Name = "Loud",
                        Description = "[g]+30%[c] Damage [nl]+50% Enemies [nl][r]-3 Harvesting[c] at the end of a wave",
                        SpritePath = $"{_assetSource}/Sprites/Characters/Loud",
                        Rarity = Rarity.Common,
                        Classes = new Class[] { Class.Character },
                        Attribute = null
                    }
                },
                {
                    "Multitasker", new NItem
                    {
                        Name = "Multitasker",
                        Description = "[g]+20%[c] Damage [nl]You can equip up to [g]12[c] weapons at a time [nl][r]-5% Damage[c] for every weapon you have",
                        SpritePath = $"{_assetSource}/Sprites/Characters/Multitasker",
                        Rarity = Rarity.Common,
                        Classes = new Class[] { Class.Character },
                        Attribute = null
                    }
                },
                {
                    "Wildling", new NItem
                    {
                        Name = "Wildling",
                        Description = "[g]+30% Life Steal[c] with [g]Primitive[c] weapons [nl]You start with [g]1 Stick[c] [nl]You can't equip weapons above tier [r]2[c]",
                        SpritePath = $"{_assetSource}/Sprites/Characters/Wildling",
                        Rarity = Rarity.Common,
                        Classes = new Class[] { Class.Character },
                        Attribute = null
                    }
                },
                {
                    "Pacifist", new NItem
                    {
                        Name = "Pacifist",
                        Description = "Gain [g]0.65[c] material and XP for every living enemy at the end of a wave [nl]You start with [g]1 Lumberjack Shirt[c] [nl][r]-100%[c] Damage [nl][r]-100[c] Engineering",
                        SpritePath = $"{_assetSource}/Sprites/Characters/Pacifist",
                        Rarity = Rarity.Common,
                        Classes = new Class[] { Class.Character },
                        Attribute = null
                    }
                },
                {
                    "Gladiator", new NItem
                    {
                        Name = "Gladiator",
                        Description = "[g]+20% Attack Speed[c] for every different weapon you have [nl][g]+5[c] Melee Damage [nl]You can't equip ranged weapons [nl][r]-40%[c] Attack Speed [nl][r]-30[c] Luck",
                        SpritePath = $"{_assetSource}/Sprites/Characters/Gladiator",
                        Rarity = Rarity.Common,
                        Classes = new Class[] { Class.Character },
                        Attribute = null
                    }
                },
                {
                    "Saver", new NItem
                    {
                        Name = "Saver",
                        Description = "[g]+15[c] Harvesting [nl][g]+1% Damage[c] for every [g]25 Materials[c] you have [nl]You start with [g]1 Piggy Bank[c] [nl][r]+50%[c] Item & Weapon Price",
                        SpritePath = $"{_assetSource}/Sprites/Characters/Saver",
                        Rarity = Rarity.Common,
                        Classes = new Class[] { Class.Character },
                        Attribute = null
                    }
                },
                {
                    "Sick", new NItem
                    {
                        Name = "Sick",
                        Description = "[g]+12[c] Max HP [nl][g]+25%[c] Life Steal [nl]You take [r]1[c] damage per second (does not give invulnerability time) [nl][r]-100[c] HP Regeneration",
                        SpritePath = $"{_assetSource}/Sprites/Characters/Sick",
                        Rarity = Rarity.Common,
                        Classes = new Class[] { Class.Character },
                        Attribute = null
                    }
                },
                {
                    "Farmer", new NItem
                    {
                        Name = "Farmer",
                        Description = "[g]+20[c] Harvesting [nl]Harvesting increases by an additional [g]3%[c] at the end of a wave [nl][g]+1[c] Harvesting when eating a consumable while at full health [nl][r]-50%[c] materials dropped",
                        SpritePath = $"{_assetSource}/Sprites/Characters/Farmer",
                        Rarity = Rarity.Common,
                        Classes = new Class[] { Class.Character },
                        Attribute = null
                    }
                },
                {
                    "Ghost", new NItem
                    {
                        Name = "Ghost",
                        Description = "[g]+10 Damage[c] with [g]Ethereal[c] weapons [nl][g]+30%[c] Dodge [nl]Dodge is capped at [g]90%[c] [nl][r]-100[c] Armor",
                        SpritePath = $"{_assetSource}/Sprites/Characters/Ghost",
                        Rarity = Rarity.Common,
                        Classes = new Class[] { Class.Character },
                        Attribute = null
                    }
                },
                {
                    "Speedy", new NItem
                    {
                        Name = "Speedy",
                        Description = "[g]+30%[c] Speed [nl][g]+1 Melee Damage[c] for every [g]2% Speed[c] you have [nl][r]-100 Armor[c] while standing still [nl][r]-3[c] Armor",
                        SpritePath = $"{_assetSource}/Sprites/Characters/Speedy",
                        Rarity = Rarity.Common,
                        Classes = new Class[] { Class.Character },
                        Attribute = null
                    }
                },
                {
                    "Entrepreneur", new NItem
                    {
                        Name = "Entrepreneur",
                        Description = "[g]-25%[c] Items Price [nl][g]Harvesting[c] modifications are increased by [g]50%[c] [nl]Gain [g]25%[c] more materials from recycling items [nl][r]-100%[c] of your materials at the start of waves [nl][r]Damage[c] modifications are reduced by [r]50%[c]",
                        SpritePath = $"{_assetSource}/Sprites/Characters/Entrepreneur",
                        Rarity = Rarity.Common,
                        Classes = new Class[] { Class.Character },
                        Attribute = null
                    }
                },
                {
                    "Engineer", new NItem
                    {
                        Name = "Engineer",
                        Description = "[g]+10[c] Engineering [nl][g]Engineering[c] modifications are increased by [g]25%[c] [nl]You start with [g]1 Wrench[c] [nl]Structures spawn close to each other [nl][r]Damage[c] modifications are reduced by [r]50%[c]",
                        SpritePath = $"{_assetSource}/Sprites/Characters/Engineer",
                        Rarity = Rarity.Common,
                        Classes = new Class[] { Class.Character },
                        Attribute = null
                    }
                },
                {
                    "Explorer", new NItem
                    {
                        Name = "Explorer",
                        Description = "More trees spawn [nl]You start with [g]1 Lumberjack Shirt[c] [nl][g]+10%[c] Speed [nl][g]+50%[c] pickup range [nl]+33% Map Size [nl]+25% Enemies [nl][r]-50%[c] materials dropped from enemies [nl][r]+10%[c] Enemy Speed [nl][r]-40%[c] Damage",
                        SpritePath = $"{_assetSource}/Sprites/Characters/Explorer",
                        Rarity = Rarity.Common,
                        Classes = new Class[] { Class.Character },
                        Attribute = null
                    }
                },
                {
                    "Doctor", new NItem
                    {
                        Name = "Doctor",
                        Description = "[g]+200% Attack Speed[c] with [g]Medical[c] weapons [nl][g]+5[c] HP Regeneration [nl]HP Regeneration is doubled [nl][g]+5[c] Harvesting [nl][r]-100%[c] Attack Speed [nl][r]Armor[c] modifications are reduced by [r]50%[c]",
                        SpritePath = $"{_assetSource}/Sprites/Characters/Doctor",
                        Rarity = Rarity.Common,
                        Classes = new Class[] { Class.Character },
                        Attribute = null
                    }
                },
                {
                    "Hunter", new NItem
                    {
                        Name = "Hunter",
                        Description = "[g]+100[c] Range [nl][g]+1% Damage[c] for every [g]10 Range[c] you have [nl][g]Crit Chance[c] modifications are increased by [g]25%[c] [nl][r]Harvesting[c] modifications are reduced by [r]100%[c] [nl][r]Max HP[c] modifications are reduced by [r]33%[c]",
                        SpritePath = $"{_assetSource}/Sprites/Characters/Hunter",
                        Rarity = Rarity.Common,
                        Classes = new Class[] { Class.Character },
                        Attribute = null
                    }
                },
                {
                    "Artificer", new NItem
                    {
                        Name = "Artificer",
                        Description = "[g]+175%[c] Explosion Damage [nl][g]+4% Explosion Size[c] for every [g]1 Elemental Damage[c] you have [nl][r]-100%[c] Damage [nl][r]Armor[c] modifications are reduced by [r]50%[c]",
                        SpritePath = $"{_assetSource}/Sprites/Characters/Artificer",
                        Rarity = Rarity.Common,
                        Classes = new Class[] { Class.Character },
                        Attribute = null
                    }
                },
                {
                    "ArmsDealer", new NItem
                    {
                        Name = "ArmsDealer",
                        Description = "[g]-95%[c] Weapons Price [nl][g]+30[c] Harvesting [nl][g]Damage[c] modifications are increased by [g]+33%[c] [nl]You start with [g]1 Dangerous Bunny[c] [nl]Shops always sell at least [g]1[c] weapon [nl]All of your weapons are destroyed when entering a shop",
                        SpritePath = $"{_assetSource}/Sprites/Characters/Arms_Dealer",
                        Rarity = Rarity.Common,
                        Classes = new Class[] { Class.Character },
                        Attribute = null
                    }
                },
                {
                    "Streamer", new NItem
                    {
                        Name = "Streamer",
                        Description = "[g]+3%[c] of your materials per second while standing still ([g]+25[c] max) [nl][g]+40% Damage[c] while moving [nl][g]+40% Attack Speed[c] while moving [nl][g]+2 Armor[c] for every [g]1 Structure[c] you have [nl][r]-50%[c] materials dropped [nl][r]-1% Damage[c] for every [r]15 Materials[c] you have [nl][r]-1% Speed[c] for every [r]30 Materials[c] you have",
                        SpritePath = $"{_assetSource}/Sprites/Characters/Streamer",
                        Rarity = Rarity.Common,
                        Classes = new Class[] { Class.Character },
                        Attribute = null
                    }
                },
                {
                    "Cyborg", new NItem
                    {
                        Name = "Cyborg",
                        Description = "You start with [g]1 Minigun[c] [nl][g]Ranged Damage[c] modifications are increased by [g]250%[c] [nl][g]100%[c] of your [g]Ranged Damage[c] are temporarily converted into [g]Engineering[c] halfway through a wave ([g]1 Ranged Damage[c] = [g]2 Engineering[c]) [nl][r]Engineering[c] modifications are reduced by [r]75%[c] [nl][r]Melee[c] modifications are reduced by [r]100%[c] [nl][r]Elemental[c] modifications are reduced by [r]100%[c]",
                        SpritePath = $"{_assetSource}/Sprites/Characters/Cyborg",
                        Rarity = Rarity.Common,
                        Classes = new Class[] { Class.Character },
                        Attribute = null
                    }
                },
                {
                    "Glutton", new NItem
                    {
                        Name = "Glutton",
                        Description = "[g]+50[c] Luck [nl][g]+1% Explosion Damage[c] when picking up a consumable while at maximum health [nl]Consumables have a [g]100%[c] chance to explode for [g]10[c] (500% Melee Damage) damage when picked up [nl][r]+25%[c] Items Price [nl][r]-25%[c] XP Gain",
                        SpritePath = $"{_assetSource}/Sprites/Characters/Glutton",
                        Rarity = Rarity.Common,
                        Classes = new Class[] { Class.Character },
                        Attribute = null
                    }
                },
                {
                    "Jack", new NItem
                    {
                        Name = "Jack",
                        Description = "[g]+75%[c] damage against bosses and elites [nl][g]+200%[c] materials dropped from enemies [nl]-75% Enemies [nl][r]+250%[c] Enemy health [nl][r]+50%[c] Enemy damage [nl][gray]Note: On higher danger levels, only Elites spawn, never hordes[c]",
                        SpritePath = $"{_assetSource}/Sprites/Characters/Jack",
                        Rarity = Rarity.Common,
                        Classes = new Class[] { Class.Character },
                        Attribute = null
                    }
                },
                {
                    "Lich", new NItem
                    {
                        Name = "Lich",
                        Description = "[g]+10[c] HP Regeneration [nl][g]+10%[c] Life Steal [nl][g]100%[c] chance to deal [g]10[c] (Max HP) damage to a random enemy when you heal [nl][r]Damage[c] modifications are reduced by [r]50%[c]",
                        SpritePath = $"{_assetSource}/Sprites/Characters/Lich",
                        Rarity = Rarity.Common,
                        Classes = new Class[] { Class.Character },
                        Attribute = null
                    }
                },
                {
                    "Apprentice", new NItem
                    {
                        Name = "Apprentice",
                        Description = "[g]+2 Melee Damage[c] when you level up [nl][g]+1 Ranged Damage[c] when you level up [nl][g]+1 Elemental Damage[c] when you level up [nl][g]+1 Engineering[c] when you level up [nl][r]-2 Max HP[c] when you level up",
                        SpritePath = $"{_assetSource}/Sprites/Characters/Apprentice",
                        Rarity = Rarity.Common,
                        Classes = new Class[] { Class.Character },
                        Attribute = null
                    }
                },
                {
                    "Cryptid", new NItem
                    {
                        Name = "Cryptid",
                        Description = "More trees spawn [gray](+6)[c] [nl]Gain [g]12[c] material and XP for every living tree at the end of a wave [nl][g]+3 HP Regeneration[c] for every current living tree [nl]Dodge is capped at [g]70%[c] [nl][g]+3 Attack Speed[c] until the end of the wave when you dodge an attack [nl][r]-100%[c] Life Steal [nl][r]-100[c] Range [nl][r]-50%[c] materials dropped from enemies",
                        SpritePath = $"{_assetSource}/Sprites/Characters/Cryptid",
                        Rarity = Rarity.Common,
                        Classes = new Class[] { Class.Character },
                        Attribute = null
                    }
                },
                {
                    "Fisherman", new NItem
                    {
                        Name = "Fisherman",
                        Description = "[g]+5[c] Max HP [nl][g]+20[c] Harvesting [nl]Shops always sell a [g]Bait[c] [nl][g]-100% Bait[c] price [nl][g]+2 Harvesting[c] for every [g]1 Bait[c] you have [nl]Baits make some special enemies spawn throughout all future waves [nl][r]-50%[c] materials dropped from enemies",
                        SpritePath = $"{_assetSource}/Sprites/Characters/Fisherman",
                        Rarity = Rarity.Common,
                        Classes = new Class[] { Class.Character },
                        Attribute = null
                    }
                },
                {
                    "Golem", new NItem
                    {
                        Name = "Golem",
                        Description = "[g]+20[c] Max HP [nl][g]Max HP[c] modifications are increased by [g]33%[c] [nl][g]Armor[c] modifications are increased by [g]33%[c] [nl][g]+40% Attack Speed[c] when you have less than 50% health [nl][g]+20% Speed[c] when you have less than 50% health [nl]You can't heal in any way",
                        SpritePath = $"{_assetSource}/Sprites/Characters/Golem",
                        Rarity = Rarity.Common,
                        Classes = new Class[] { Class.Character },
                        Attribute = null
                    }
                },
                {
                    "King", new NItem
                    {
                        Name = "King",
                        Description = "[g]+50[c] Luck[nl][g]+25% Damage[c] for every [g]Tier IV weapon[c] you have[nl][g]+25% Attack Speed[c] for every [g]Tier IV weapon[c] you have[nl][g]+5 Max HP[c] for every different [g]Tier IV item[c] you have[nl][r]-15% Damage[c] for every [r]Tier I weapon[c] you have[nl][r]-15% Attack Speed[c] for every [r]Tier I weapon[c] you have[nl][r]-2 Max HP[c] for every different [r]Tier I item[c] you have[nl]Starting weapon is [g]Tier II[c]",
                        SpritePath = $"{_assetSource}/Sprites/Characters/King",
                        Rarity = Rarity.Common,
                        Classes = new Class[] { Class.Character },
                        Attribute = null
                    }
                },
                {
                    "Renegade", new NItem
                    {
                        Name = "Renegade",
                        Description = "[g]+2[c] projectiles [nl]Projectiles pierce through [g]1[c] additional target [nl][g]+10% Damage[c] for every different Tier I item you have [nl]You can't equip melee weapons [nl][r]-400%[c] Damage [nl][r]-50%[c] accuracy [nl][r]% Damage[c] modifications are reduced by [r]80%[c]",
                        SpritePath = $"{_assetSource}/Sprites/Characters/Renegade",
                        Rarity = Rarity.Common,
                        Classes = new Class[] { Class.Character },
                        Attribute = null
                    }
                },
                {
                    "OneArmed", new NItem
                    {
                        Name = "OneArmed",
                        Description = "[g]+2[c] projectiles [nl]Projectiles pierce through [g]1[c] additional target [nl][g]+10% Damage[c] for every different Tier I item you have [nl]You can't equip melee weapons [nl][r]-400%[c] Damage [nl][r]-50%[c] accuracy [nl][r]% Damage[c] modifications are reduced by [r]80%[c]",
                        SpritePath = $"{_assetSource}/Sprites/Characters/One_Armed",
                        Rarity = Rarity.Common,
                        Classes = new Class[] { Class.Character },
                        Attribute = null
                    }
                },
                {
                    "Bull", new NItem
                    {
                        Name = "Bull",
                        Description = "[g]+20[c] Max HP [nl][g]+15[c] HP Regeneration [nl][g]+10[c] Armor [nl][g]HP Regeneration[c] modifications are increased by [g]50%[c] [nl]You explode for [g]30[c] (300% Melee Damage, 300% Ranged Damage, 300% Elemental Damage) damage when you take damage [nl]This explosion has a 1.5x crit multiplier [nl]You can't equip weapons",
                        SpritePath = $"{_assetSource}/Sprites/Characters/Bull",
                        Rarity = Rarity.Common,
                        Classes = new Class[] { Class.Character },
                        Attribute = null
                    }
                },
                {
                    "Soldier", new NItem
                    {
                        Name = "Soldier",
                        Description = "[g]+50% Damage[c] while standing still [nl][g]+50% Attack Speed[c] while standing still [nl][g]+10%[c] Speed [nl][g]+200%[c] pickup range [nl][g]+15[c] Knockback [nl]You can't attack while moving",
                        SpritePath = $"{_assetSource}/Sprites/Characters/Soldier",
                        Rarity = Rarity.Common,
                        Classes = new Class[] { Class.Character },
                        Attribute = null
                    }
                },
                {
                        "Masochist", new NItem
                    {
                        Name = "Masochist",
                        Description = "[g]+5% Damage[c] when you take damage until the end of the wave [nl][g]+10[c] Max HP [nl][g]+20[c] HP Regeneration [nl][g]+8[c] Armor [nl][r]-100%[c] Damage",
                        SpritePath = $"{_assetSource}/Sprites/Characters/Masochist",
                        Rarity = Rarity.Common,
                        Classes = new Class[] { Class.Character },
                        Attribute = null
                    }
                },
                {
                    "Knight", new NItem
                    {
                        Name = "Knight",
                        Description = "[g]+2 Melee Damage[c] for every [g]1 Armor[c] you have [nl][g]+5[c] Armor [nl]You can't equip ranged weapons [nl]You can only equip tier [g]2[c] weapons or above [nl][r]% Attack Speed[c] modifications are reduced by [r]50%[c] [nl][r]Harvesting[c] modifications are reduced by [r]80%[c]",
                        SpritePath = $"{_assetSource}/Sprites/Characters/Knight",
                        Rarity = Rarity.Common,
                        Classes = new Class[] { Class.Character },
                        Attribute = null
                    }
                },
                {
                    "Demon", new NItem
                    {
                        Name = "Demon",
                        Description = "[g]+50%[c] of your [g]Materials[c] are converted into [g]Max HP[c] at the end of a wave ([g]13 Materials=1 Max HP[c]) [nl]You buy items using Max HP instead of materials",
                        SpritePath = $"{_assetSource}/Sprites/Characters/Demon",
                        Rarity = Rarity.Common,
                        Classes = new Class[] { Class.Character },
                        Attribute = null
                    }
                }
            };
        }

        public static NItem[] GetItemsByClass(Class itemClass)
        {
            return Items.Values.Where(item => item.Classes.Contains(itemClass)).ToArray();
        }
    }
}