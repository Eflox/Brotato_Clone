/*
 * Script Author: Charles d'Ansembourg
 * Creation Date: 28/05/2024
 * Contact: c.dansembourg@icloud.com
 */

using System.Collections.Generic;

namespace Brotato_Clone.Models
{
    [System.Serializable]
    public class PlayerStats
    {
        //Primary Stats
        [InspectableDictionary]
        public Dictionary<StatType, int> MaxHP = new Dictionary<StatType, int>
        {
            { StatType.Base, 0 },
            { StatType.Multiplier, 0 },
            { StatType.TotalVisible, 0 }
        };

        [InspectableDictionary]
        public Dictionary<StatType, int> HPRegen = new Dictionary<StatType, int>
        {
            { StatType.Base, 0 },
            { StatType.Multiplier, 0 },
            { StatType.TotalVisible, 0 }
        };

        [InspectableDictionary]
        public Dictionary<StatType, int> LifeSteal = new Dictionary<StatType, int>
        {
            { StatType.Base, 0 },
            { StatType.Multiplier, 0 },
            { StatType.TotalVisible, 0 }
        };

        [InspectableDictionary]
        public Dictionary<StatType, int> Damage = new Dictionary<StatType, int>
        {
            { StatType.Base, 0 },
            { StatType.Multiplier, 0 },
            { StatType.TotalVisible, 0 }
        };

        [InspectableDictionary]
        public Dictionary<StatType, int> MeleeDmg = new Dictionary<StatType, int>
        {
            { StatType.Base, 0 },
            { StatType.Multiplier, 0 },
            { StatType.TotalVisible, 0 }
        };

        [InspectableDictionary]
        public Dictionary<StatType, int> RangedDmg = new Dictionary<StatType, int>
        {
            { StatType.Base, 0 },
            { StatType.Multiplier, 0 },
            { StatType.TotalVisible, 0 }
        };

        [InspectableDictionary]
        public Dictionary<StatType, int> ElementalDmg = new Dictionary<StatType, int>
        {
            { StatType.Base, 0 },
            { StatType.Multiplier, 0 },
            { StatType.TotalVisible, 0 }
        };

        [InspectableDictionary]
        public Dictionary<StatType, int> AttackSpeed = new Dictionary<StatType, int>
        {
            { StatType.Base, 0 },
            { StatType.Multiplier, 0 },
            { StatType.TotalVisible, 0 }
        };

        [InspectableDictionary]
        public Dictionary<StatType, int> CritChance = new Dictionary<StatType, int>
        {
            { StatType.Base, 0 },
            { StatType.Multiplier, 0 },
            { StatType.TotalVisible, 0 }
        };

        [InspectableDictionary]
        public Dictionary<StatType, int> Engineering = new Dictionary<StatType, int>
        {
            { StatType.Base, 0 },
            { StatType.Multiplier, 0 },
            { StatType.TotalVisible, 0 }
        };

        [InspectableDictionary]
        public Dictionary<StatType, int> Range = new Dictionary<StatType, int>
        {
            { StatType.Base, 0 },
            { StatType.Multiplier, 0 },
            { StatType.TotalVisible, 0 }
        };

        [InspectableDictionary]
        public Dictionary<StatType, int> Armor = new Dictionary<StatType, int>
        {
            { StatType.Base, 0 },
            { StatType.Multiplier, 0 },
            { StatType.TotalVisible, 0 }
        };

        [InspectableDictionary]
        public Dictionary<StatType, int> Dodge = new Dictionary<StatType, int>
        {
            { StatType.Base, 0 },
            { StatType.Multiplier, 0 },
            { StatType.TotalVisible, 0 }
        };

        [InspectableDictionary]
        public Dictionary<StatType, int> Speed = new Dictionary<StatType, int>
        {
            { StatType.Base, 10 },
            { StatType.Multiplier, 50 },
            { StatType.TotalVisible, 0 }
        };

        [InspectableDictionary]
        public Dictionary<StatType, int> Luck = new Dictionary<StatType, int>
        {
            { StatType.Base, 0 },
            { StatType.Multiplier, 0 },
            { StatType.TotalVisible, 0 }
        };

        [InspectableDictionary]
        public Dictionary<StatType, int> Harvesting = new Dictionary<StatType, int>
        {
            { StatType.Base, 0 },
            { StatType.Multiplier, 0 },
            { StatType.TotalVisible, 0 }
        };

        [InspectableDictionary]
        public Dictionary<StatType, int> XPGain = new Dictionary<StatType, int>
        {
            { StatType.Base, 0 },
            { StatType.TotalVisible, 0 }
        };

        //Variable Stats
        public int Materials;

        //Character Specific Stats
        public int MaxWeapons;

        public int UnarmedAttackSpeed;
        public int PreciseRange;
        public int PrimitiveLifeSteal;
        public int EtherealDamage;
        public int MedicalAttackSpeed;

        //Secondary Stats
        //Combat
        public int ExplosionDmg;

        public int ExplosionSize;
        public int Bounces;
        public int Piercing;
        public int PiercingDmg;
        public int BurningSpeed;
        public int BurningSpread;
        public int Knockback;

        //Stand Still
        public int StandStillArmor;

        public int StandStillDodge;
        public int StandStillDmg;

        //Enemies
        public int EnemyAmount;

        public int EnemySpeed;

        //HP & Healing
        public int ConsumableHeal;

        public int MaterialsHealing;
        public int HPPerMaterials;

        //Pick-Ups & Materials
        public int PickupRange;

        public int Trees;
        public int MaterialsInCrates;
        public int ChanceDoubleMaterials;
        public int ChanceInstantMaterialPickup;
        public int ChanceDamageOnMaterialPickUp;

        //Shop & Economy
        public int ItemPrice;

        public int FreeRolls;
        public int ItemRecycling;
        public int MaterialsInterestGain;

        //Class Weapon Count
        public int UnarmedWeapons;

        public int PrimitiveWeapons;
        public int HeavyWeapons;
        public int BladeWeapons;
        public int MedicalWeapons;
        public int PreciseWeapons;
        public int LegendaryWeapons;
        public int MedievalWeapons;
        public int ElementalWeapons;
        public int EtherealWeapons;
        public int BluntWeapons;
        public int SupportWeapons;
        public int ExplosiveWeapons;
        public int ToolWeapons;
    }

    public enum StatType
    {
        Base,
        Multiplier,
        TotalVisible,
    }
}