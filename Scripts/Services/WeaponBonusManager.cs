/*
 * WeaponBonusManager.cs
 * Script Author: Charles d'Ansembourg
 * Creation Date: 29/05/2024
 * Contact: c.dansembourg@icloud.com
 */

using Brotato_Clone.Models;

namespace Brotato_Clone.Services
{
    public static class WeaponBonusManager
    {
        public static int MaxHPWeaponClassBonus(int LegendaryWeapons, int PrimitiveWeapons, int BluntWeapons) =>
            WeaponClassBonusesData.CalculateBonus(LegendaryWeapons, WeaponClassBonusesData.LegendaryWeaponsBonusMap) +
            WeaponClassBonusesData.CalculateBonus(PrimitiveWeapons, WeaponClassBonusesData.PrimitiveWeaponsBonusMap) +
            WeaponClassBonusesData.CalculateBonus(BluntWeapons, WeaponClassBonusesData.BluntWeaponsBonusMap);

        public static int DamageWeaponClassBonus(int HeavyWeapons) =>
            WeaponClassBonusesData.CalculateBonus(HeavyWeapons, WeaponClassBonusesData.HeavyWeaponsBonusMap);

        public static int MeleeDmgWeaponClassBonus(int BladeWeapons) =>
            WeaponClassBonusesData.CalculateBonus(BladeWeapons, WeaponClassBonusesData.BladeWeaponsBonusMap);

        public static int LifeStealWeaponClassBonus(int BladeWeapons) =>
            WeaponClassBonusesData.CalculateBonus(BladeWeapons, WeaponClassBonusesData.BladeWeaponsBonusMap);

        public static int HPRegenWeaponClassBonus(int MedicalWeapons) =>
            WeaponClassBonusesData.CalculateBonus(MedicalWeapons, WeaponClassBonusesData.MedicalWeaponsBonusMap);

        public static int DodgeWeaponClassBonus(int UnarmedWeapons, int MedievalWeapons, int EtherealWeapons) =>
            WeaponClassBonusesData.CalculateBonus(UnarmedWeapons, WeaponClassBonusesData.UnarmedWeaponsBonusMap) +
            WeaponClassBonusesData.CalculateBonus(MedievalWeapons, WeaponClassBonusesData.MedievalWeaponsBonusMap) +
            WeaponClassBonusesData.CalculateBonus(EtherealWeapons, WeaponClassBonusesData.EtherealWeaponsBonusMap);

        public static int CritChanceWeaponClassBonus(int PreciseWeapons) =>
            WeaponClassBonusesData.CalculateBonus(PreciseWeapons, WeaponClassBonusesData.PreciseWeaponsBonusMap);

        public static int ArmorWeaponClassBonus(int MedievalWeapons, int EtherealWeapons, int BluntWeapons) =>
            WeaponClassBonusesData.CalculateBonus(MedievalWeapons, WeaponClassBonusesData.MedievalWeaponsBonusMap) +
            WeaponClassBonusesData.CalculateBonus(EtherealWeapons, WeaponClassBonusesData.EtherealWeaponsBonusMap) +
            WeaponClassBonusesData.CalculateBonus(BluntWeapons, WeaponClassBonusesData.BluntWeaponsBonusMap);

        public static int ElementalDmgWeaponClassBonus(int ElementalWeapons) =>
            WeaponClassBonusesData.CalculateBonus(ElementalWeapons, WeaponClassBonusesData.ElementalWeaponsBonusMap);

        public static int SpeedWeaponClassBonus(int BluntWeapons) =>
            WeaponClassBonusesData.CalculateBonus(BluntWeapons, WeaponClassBonusesData.BluntWeaponsBonusMap);

        public static int HarvestingWeaponClassBonus(int SupportWeapons) =>
            WeaponClassBonusesData.CalculateBonus(SupportWeapons, WeaponClassBonusesData.SupportWeaponsBonusMap);

        public static int ExplosionSizeWeaponClassBonus(int ExplosiveWeapons) =>
            WeaponClassBonusesData.CalculateBonus(ExplosiveWeapons, WeaponClassBonusesData.ExplosiveWeaponsBonusMap);

        public static int EngineeringWeaponClassBonus(int ToolWeapons) =>
            WeaponClassBonusesData.CalculateBonus(ToolWeapons, WeaponClassBonusesData.ToolWeaponsBonusMap);
    }
}