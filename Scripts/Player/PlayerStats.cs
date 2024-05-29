/*
 * Script Author: Charles d'Ansembourg
 * Creation Date: 28/05/2024
 * Contact: c.dansembourg@icloud.com
 */

[System.Serializable]
public class PlayerStats
{
    //Variable Stats
    public int Materials;

    //Character Specific Stats
    public int MaxWeapons = 6;

    //Primary Stats
    public int MaxHP;
    public int HPRegen;
    public int LifeSteal;
    public int Damage;
    public int MeleeDmg;
    public int RangeDmg;
    public int ElementalDmg;
    public int AttackSpeed;
    public int CritChance;
    public int Engineering;
    public int Range;
    public int Armor;
    public int Dodge;
    public int Speed;
    public int Luck;
    public int Harvesting;

    //Multipliers
    public int MaxHPMultiplier;
    public int HPRegenMultiplier;
    public int LifeStealMultiplier;
    public int DamageMultiplier;
    public int MeleeDmgMultiplier;
    public int RangeDmgMultiplier;
    public int ElementalDmgMultiplier;
    public int AttackSpeedMultiplier;
    public int CritChanceMultiplier;
    public int EngineeringMultiplier;
    public int RangeMultiplier;
    public int ArmorMultiplier;
    public int DodgeMultiplier;
    public int SpeedMultiplier;
    public int LuckMultiplier;
    public int HarvestingMultiplier;


    //Secondary Stats
    //Combat
    public int XPGain;
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