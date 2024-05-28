/*
 * Script Author: Charles d'Ansembourg
 * Creation Date: 28/05/2024
 * Contact: c.dansembourg@icloud.com
 */

[System.Serializable]
public class PlayerStats
{
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
}