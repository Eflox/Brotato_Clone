/*
 * Script Author: Charles d'Ansembourg
 * Creation Date: 29/05/2024
 * Contact: c.dansembourg@icloud.com
 */

public static class StatsUpdater
{
    public static void UpdateVisibleStats(PlayerStats stats)
    {
        stats.MaxHP[StatType.TotalVisible] = (stats.MaxHP[StatType.Base] +
            WeaponBonusCalculator.MaxHPWeaponClassBonus(stats.LegendaryWeapons, stats.PrimitiveWeapons, stats.BluntWeapons))
            .ApplyMultiplier(stats.MaxHP[StatType.Multiplier]);

        // Similar updates for other stats
        stats.HPRegen[StatType.TotalVisible] = (stats.HPRegen[StatType.Base] +
            WeaponBonusCalculator.HPRegenWeaponClassBonus(stats.MedicalWeapons))
            .ApplyMultiplier(stats.HPRegen[StatType.Multiplier]);

        stats.LifeSteal[StatType.TotalVisible] = (stats.LifeSteal[StatType.Base] +
            WeaponBonusCalculator.LifeStealWeaponClassBonus(stats.BladeWeapons))
            .ApplyMultiplier(stats.LifeSteal[StatType.Multiplier]);

        stats.Damage[StatType.TotalVisible] = (stats.Damage[StatType.Base] +
            WeaponBonusCalculator.DamageWeaponClassBonus(stats.HeavyWeapons))
            .ApplyMultiplier(stats.Damage[StatType.Multiplier]);

        stats.MeleeDmg[StatType.TotalVisible] = (stats.MeleeDmg[StatType.Base] +
            WeaponBonusCalculator.MeleeDmgWeaponClassBonus(stats.BladeWeapons))
            .ApplyMultiplier(stats.MeleeDmg[StatType.Multiplier]);

        stats.RangeDmg[StatType.TotalVisible] = (stats.RangeDmg[StatType.Base])
            .ApplyMultiplier(stats.RangeDmg[StatType.Multiplier]);

        stats.ElementalDmg[StatType.TotalVisible] = (stats.ElementalDmg[StatType.Base] +
            WeaponBonusCalculator.ElementalDmgWeaponClassBonus(stats.ElementalWeapons))
            .ApplyMultiplier(stats.ElementalDmg[StatType.Multiplier]);

        stats.AttackSpeed[StatType.TotalVisible] = (stats.AttackSpeed[StatType.Base])
            .ApplyMultiplier(stats.AttackSpeed[StatType.Multiplier]);

        stats.CritChance[StatType.TotalVisible] = (stats.CritChance[StatType.Base] +
            WeaponBonusCalculator.CritChanceWeaponClassBonus(stats.PreciseWeapons))
            .ApplyMultiplier(stats.CritChance[StatType.Multiplier]);

        stats.Engineering[StatType.TotalVisible] = (stats.Engineering[StatType.Base] +
            WeaponBonusCalculator.EngineeringWeaponClassBonus(stats.ToolWeapons))
            .ApplyMultiplier(stats.Engineering[StatType.Multiplier]);

        stats.Range[StatType.TotalVisible] = (stats.Range[StatType.Base])
            .ApplyMultiplier(stats.Range[StatType.Multiplier]);

        stats.Armor[StatType.TotalVisible] = (stats.Armor[StatType.Base] +
            WeaponBonusCalculator.ArmorWeaponClassBonus(stats.MedievalWeapons, stats.EtherealWeapons, stats.BluntWeapons))
            .ApplyMultiplier(stats.Armor[StatType.Multiplier]);

        stats.Dodge[StatType.TotalVisible] = (stats.Dodge[StatType.Base] +
            WeaponBonusCalculator.DodgeWeaponClassBonus(stats.UnarmedWeapons, stats.MedievalWeapons, stats.EtherealWeapons))
            .ApplyMultiplier(stats.Dodge[StatType.Multiplier]);

        stats.Speed[StatType.TotalVisible] = (stats.Speed[StatType.Base] +
            WeaponBonusCalculator.SpeedWeaponClassBonus(stats.BluntWeapons))
            .ApplyMultiplier(stats.Speed[StatType.Multiplier]);

        stats.Luck[StatType.TotalVisible] = (stats.Luck[StatType.Base])
            .ApplyMultiplier(stats.Luck[StatType.Multiplier]);

        stats.Harvesting[StatType.TotalVisible] = (stats.Harvesting[StatType.Base] +
            WeaponBonusCalculator.HarvestingWeaponClassBonus(stats.SupportWeapons))
            .ApplyMultiplier(stats.Harvesting[StatType.Multiplier]);
    }
}
