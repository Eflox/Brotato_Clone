/*
 * Script Author: Charles d'Ansembourg
 * Creation Date: 29/05/2024
 * Contact: c.dansembourg@icloud.com
 */

public static class WeaponBonusCalculator
{
    public static int MaxHPWeaponClassBonus(int LegendaryWeapons, int PrimitiveWeapons, int BluntWeapons) =>
        WeaponClassBonuses.CalculateBonus(LegendaryWeapons, WeaponClassBonuses.LegendaryWeaponsBonusMap) +
        WeaponClassBonuses.CalculateBonus(PrimitiveWeapons, WeaponClassBonuses.PrimitiveWeaponsBonusMap) +
        WeaponClassBonuses.CalculateBonus(BluntWeapons, WeaponClassBonuses.BluntWeaponsBonusMap);

    public static int DamageWeaponClassBonus(int HeavyWeapons) =>
        WeaponClassBonuses.CalculateBonus(HeavyWeapons, WeaponClassBonuses.HeavyWeaponsBonusMap);

    public static int MeleeDmgWeaponClassBonus(int BladeWeapons) =>
        WeaponClassBonuses.CalculateBonus(BladeWeapons, WeaponClassBonuses.BladeWeaponsBonusMap);

    public static int LifeStealWeaponClassBonus(int BladeWeapons) =>
        WeaponClassBonuses.CalculateBonus(BladeWeapons, WeaponClassBonuses.BladeWeaponsBonusMap);

    public static int HPRegenWeaponClassBonus(int MedicalWeapons) =>
        WeaponClassBonuses.CalculateBonus(MedicalWeapons, WeaponClassBonuses.MedicalWeaponsBonusMap);

    public static int DodgeWeaponClassBonus(int UnarmedWeapons, int MedievalWeapons, int EtherealWeapons) =>
        WeaponClassBonuses.CalculateBonus(UnarmedWeapons, WeaponClassBonuses.UnarmedWeaponsBonusMap) +
        WeaponClassBonuses.CalculateBonus(MedievalWeapons, WeaponClassBonuses.MedievalWeaponsBonusMap) +
        WeaponClassBonuses.CalculateBonus(EtherealWeapons, WeaponClassBonuses.EtherealWeaponsBonusMap);

    public static int CritChanceWeaponClassBonus(int PreciseWeapons) =>
        WeaponClassBonuses.CalculateBonus(PreciseWeapons, WeaponClassBonuses.PreciseWeaponsBonusMap);

    public static int ArmorWeaponClassBonus(int MedievalWeapons, int EtherealWeapons, int BluntWeapons) =>
        WeaponClassBonuses.CalculateBonus(MedievalWeapons, WeaponClassBonuses.MedievalWeaponsBonusMap) +
        WeaponClassBonuses.CalculateBonus(EtherealWeapons, WeaponClassBonuses.EtherealWeaponsBonusMap) +
        WeaponClassBonuses.CalculateBonus(BluntWeapons, WeaponClassBonuses.BluntWeaponsBonusMap);

    public static int ElementalDmgWeaponClassBonus(int ElementalWeapons) =>
        WeaponClassBonuses.CalculateBonus(ElementalWeapons, WeaponClassBonuses.ElementalWeaponsBonusMap);

    public static int SpeedWeaponClassBonus(int BluntWeapons) =>
        WeaponClassBonuses.CalculateBonus(BluntWeapons, WeaponClassBonuses.BluntWeaponsBonusMap);

    public static int HarvestingWeaponClassBonus(int SupportWeapons) =>
        WeaponClassBonuses.CalculateBonus(SupportWeapons, WeaponClassBonuses.SupportWeaponsBonusMap);

    public static int ExplosionSizeWeaponClassBonus(int ExplosiveWeapons) =>
        WeaponClassBonuses.CalculateBonus(ExplosiveWeapons, WeaponClassBonuses.ExplosiveWeaponsBonusMap);

    public static int EngineeringWeaponClassBonus(int ToolWeapons) =>
        WeaponClassBonuses.CalculateBonus(ToolWeapons, WeaponClassBonuses.ToolWeaponsBonusMap);
}
