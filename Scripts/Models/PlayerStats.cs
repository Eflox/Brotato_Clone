/*
 * PlayerStats.cs
 * Script Author: Charles d'Ansembourg
 * Creation Date: 28/05/2024
 * Contact: c.dansembourg@icloud.com
 */

using System;
using System.Collections.Generic;

namespace Brotato_Clone.Models
{
    [System.Serializable]
    public class PlayerStats
    {
        public PlayerStats()
        {
            SetDefaults();
        }

        //Primary Stats
        [InspectableDictionary]
        public Dictionary<StatType, int> MaxHP = new Dictionary<StatType, int>
        {
            { StatType.Base, 10 },
            { StatType.Multiplier, 0 },
            { StatType.TotalVisible, 0 },
            { StatType.Temporary, 0 }
        };

        [InspectableDictionary]
        public Dictionary<StatType, int> HPRegen = new Dictionary<StatType, int>
        {
            { StatType.Base, 0 },
            { StatType.Multiplier, 0 },
            { StatType.TotalVisible, 0 },
            { StatType.Temporary, 0 }
        };

        [InspectableDictionary]
        public Dictionary<StatType, int> LifeSteal = new Dictionary<StatType, int>
        {
            { StatType.Base, 0 },
            { StatType.Multiplier, 0 },
            { StatType.TotalVisible, 0 },
            { StatType.Temporary, 0 }
        };

        [InspectableDictionary]
        public Dictionary<StatType, int> Damage = new Dictionary<StatType, int>
        {
            { StatType.Base, 0 },
            { StatType.Multiplier, 0 },
            { StatType.TotalVisible, 0 },
            { StatType.Temporary, 0 }
        };

        [InspectableDictionary]
        public Dictionary<StatType, int> MeleeDmg = new Dictionary<StatType, int>
        {
            { StatType.Base, 0 },
            { StatType.Multiplier, 0 },
            { StatType.TotalVisible, 0 },
            { StatType.Temporary, 0 }
        };

        [InspectableDictionary]
        public Dictionary<StatType, int> RangedDmg = new Dictionary<StatType, int>
        {
            { StatType.Base, 0 },
            { StatType.Multiplier, 0 },
            { StatType.TotalVisible, 0 },
            { StatType.Temporary, 0 }
        };

        [InspectableDictionary]
        public Dictionary<StatType, int> ElementalDmg = new Dictionary<StatType, int>
        {
            { StatType.Base, 0 },
            { StatType.Multiplier, 0 },
            { StatType.TotalVisible, 0 },
            { StatType.Temporary, 0 }
        };

        [InspectableDictionary]
        public Dictionary<StatType, int> AttackSpeed = new Dictionary<StatType, int>
        {
            { StatType.Base, 0 },
            { StatType.Multiplier, 0 },
            { StatType.TotalVisible, 0 },
            { StatType.Temporary, 0 }
        };

        [InspectableDictionary]
        public Dictionary<StatType, int> CritChance = new Dictionary<StatType, int>
        {
            { StatType.Base, 0 },
            { StatType.Multiplier, 0 },
            { StatType.TotalVisible, 0 },
            { StatType.Temporary, 0 }
        };

        [InspectableDictionary]
        public Dictionary<StatType, int> Engineering = new Dictionary<StatType, int>
        {
            { StatType.Base, 0 },
            { StatType.Multiplier, 0 },
            { StatType.TotalVisible, 0 },
            { StatType.Temporary, 0 }
        };

        [InspectableDictionary]
        public Dictionary<StatType, int> Range = new Dictionary<StatType, int>
        {
            { StatType.Base, 0 },
            { StatType.Multiplier, 0 },
            { StatType.TotalVisible, 0 },
            { StatType.Temporary, 0 }
        };

        [InspectableDictionary]
        public Dictionary<StatType, int> Armor = new Dictionary<StatType, int>
        {
            { StatType.Base, 0 },
            { StatType.Multiplier, 0 },
            { StatType.TotalVisible, 0 },
            { StatType.Temporary, 0 }
        };

        [InspectableDictionary]
        public Dictionary<StatType, int> Dodge = new Dictionary<StatType, int>
        {
            { StatType.Base, 0 },
            { StatType.Multiplier, 0 },
            { StatType.TotalVisible, 0 },
            { StatType.Temporary, 0 }
        };

        [InspectableDictionary]
        public Dictionary<StatType, int> Speed = new Dictionary<StatType, int>
        {
            { StatType.Base, 0 },
            { StatType.Multiplier, 0 },
            { StatType.TotalVisible, 0 },
            { StatType.Temporary, 0 }
        };

        [InspectableDictionary]
        public Dictionary<StatType, int> Luck = new Dictionary<StatType, int>
        {
            { StatType.Base, 0 },
            { StatType.Multiplier, 0 },
            { StatType.TotalVisible, 0 },
            { StatType.Temporary, 0 }
        };

        [InspectableDictionary]
        public Dictionary<StatType, int> Harvesting = new Dictionary<StatType, int>
        {
            { StatType.Base, 0 },
            { StatType.Multiplier, 0 },
            { StatType.TotalVisible, 0 },
            { StatType.Temporary, 0 }
        };

        [InspectableDictionary]
        public Dictionary<StatType, int> XPGain = new Dictionary<StatType, int>
        {
            { StatType.Base, 0 },
            { StatType.Multiplier, 0 },
            { StatType.TotalVisible, 0 },
            { StatType.Temporary, 0 }
        };

        //Variable Stats

        public int LevelsGainedDuringWave;
        public int CurrentWave;
        public int CurrentHP;
        public int CurrentLvl;
        public int CurrentXp;
        public int CurrentBagMaterials;
        public int CurrentMaterials;

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
        public int Pierces;
        public int PiercingDmg;
        public int BurningSpeed;
        public int BurningSpread;
        public int Knockback;
        public int BurnSpread;
        public int BurnRate;

        //Stand Still

        public int StandStillArmor;
        public int StandStillDodge;
        public int StandStillDmg;

        //Enemies

        public int EnemyAmount;
        public int EnemySpeed;
        public int ElitesDamage;
        public int TreeCount;

        //HP & Healing

        public int ConsumableHeal;
        public int MaterialsHealing;
        public int HPPerConsumable;
        public int Nullifies;

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

        public void SetDefaults()
        {
            MaxHP[StatType.Base] = 10;
            MaxHP[StatType.Multiplier] = 0;
            DefaultStatDictionary(HPRegen);
            DefaultStatDictionary(LifeSteal);
            DefaultStatDictionary(Damage);
            DefaultStatDictionary(MeleeDmg);
            DefaultStatDictionary(RangedDmg);
            DefaultStatDictionary(ElementalDmg);
            DefaultStatDictionary(AttackSpeed);
            DefaultStatDictionary(CritChance);
            DefaultStatDictionary(Engineering);
            DefaultStatDictionary(Range);
            DefaultStatDictionary(Armor);
            DefaultStatDictionary(Dodge);
            DefaultStatDictionary(Speed);
            DefaultStatDictionary(Luck);
            DefaultStatDictionary(Harvesting);
            DefaultStatDictionary(XPGain);

            SetDefaultVariables();
        }

        private void DefaultStatDictionary(Dictionary<StatType, int> statDictionary)
        {
            statDictionary.Clear();
            foreach (StatType type in Enum.GetValues(typeof(StatType)))
                statDictionary[type] = 0;
        }

        private void SetDefaultVariables()
        {
            MaxWeapons = 0;
            UnarmedAttackSpeed = 0;
            PreciseRange = 0;
            PrimitiveLifeSteal = 0;
            EtherealDamage = 0;
            MedicalAttackSpeed = 0;

            ExplosionDmg = 0;
            ExplosionSize = 0;
            Bounces = 0;
            Pierces = 0;
            PiercingDmg = 0;
            BurningSpeed = 0;
            BurningSpread = 0;
            Knockback = 0;

            StandStillArmor = 0;
            StandStillDodge = 0;
            StandStillDmg = 0;

            EnemyAmount = 0;
            EnemySpeed = 0;

            ConsumableHeal = 0;
            MaterialsHealing = 0;
            HPPerConsumable = 0;

            PickupRange = 3;
            Trees = 0;
            MaterialsInCrates = 0;
            ChanceDoubleMaterials = 0;
            ChanceInstantMaterialPickup = 0;
            ChanceDamageOnMaterialPickUp = 0;

            ItemPrice = 0;
            FreeRolls = 0;
            ItemRecycling = 0;
            MaterialsInterestGain = 0;

            UnarmedWeapons = 0;
            PrimitiveWeapons = 0;
            HeavyWeapons = 0;
            BladeWeapons = 0;
            MedicalWeapons = 0;
            PreciseWeapons = 0;
            LegendaryWeapons = 0;
            MedievalWeapons = 0;
            ElementalWeapons = 0;
            EtherealWeapons = 0;
            BluntWeapons = 0;
            SupportWeapons = 0;
            ExplosiveWeapons = 0;
            ToolWeapons = 0;
        }
    }

    public enum StatType
    {
        Base,
        Multiplier,
        TotalVisible,
        Temporary,
    }
}