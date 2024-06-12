/*
 * StatsUpdaterService.cs
 * Script Author: Charles d'Ansembourg
 * Creation Date: 28/05/2024
 * Contact: c.dansembourg@icloud.com
 */

using Brotato_Clone.Extensions;
using Brotato_Clone.Models;

namespace Brotato_Clone.Services
{
    /// <summary>
    /// Updates the TotalVisible of the stats
    /// </summary>
    public class StatsUpdaterService
    {
        /// <summary>
        /// Updates TotalVisible of stats with multipliers and weapon bonuses included
        /// </summary>
        public void UpdateVisibleStats(PlayerStats stats)
        {
            stats.MaxHP[StatType.TotalVisible] = (stats.MaxHP[StatType.Base] +
                WeaponBonusManager.MaxHPWeaponClassBonus(stats.LegendaryWeapons, stats.PrimitiveWeapons, stats.BluntWeapons))
                .ApplyMultiplier(stats.MaxHP[StatType.Multiplier]);

            stats.HPRegen[StatType.TotalVisible] = (stats.HPRegen[StatType.Base] +
                WeaponBonusManager.HPRegenWeaponClassBonus(stats.MedicalWeapons))
                .ApplyMultiplier(stats.HPRegen[StatType.Multiplier]);

            stats.LifeSteal[StatType.TotalVisible] = (stats.LifeSteal[StatType.Base] +
                WeaponBonusManager.LifeStealWeaponClassBonus(stats.BladeWeapons))
                .ApplyMultiplier(stats.LifeSteal[StatType.Multiplier]);

            stats.Damage[StatType.TotalVisible] = (stats.Damage[StatType.Base] +
                WeaponBonusManager.DamageWeaponClassBonus(stats.HeavyWeapons))
                .ApplyMultiplier(stats.Damage[StatType.Multiplier]);

            stats.MeleeDmg[StatType.TotalVisible] = (stats.MeleeDmg[StatType.Base] +
                WeaponBonusManager.MeleeDmgWeaponClassBonus(stats.BladeWeapons))
                .ApplyMultiplier(stats.MeleeDmg[StatType.Multiplier]);

            stats.RangedDmg[StatType.TotalVisible] = (stats.RangedDmg[StatType.Base])
                .ApplyMultiplier(stats.RangedDmg[StatType.Multiplier]);

            stats.ElementalDmg[StatType.TotalVisible] = (stats.ElementalDmg[StatType.Base] +
                WeaponBonusManager.ElementalDmgWeaponClassBonus(stats.ElementalWeapons))
                .ApplyMultiplier(stats.ElementalDmg[StatType.Multiplier]);

            stats.AttackSpeed[StatType.TotalVisible] = (stats.AttackSpeed[StatType.Base])
                .ApplyMultiplier(stats.AttackSpeed[StatType.Multiplier]);

            stats.CritChance[StatType.TotalVisible] = (stats.CritChance[StatType.Base] +
                WeaponBonusManager.CritChanceWeaponClassBonus(stats.PreciseWeapons))
                .ApplyMultiplier(stats.CritChance[StatType.Multiplier]);

            stats.Engineering[StatType.TotalVisible] = (stats.Engineering[StatType.Base] +
                WeaponBonusManager.EngineeringWeaponClassBonus(stats.ToolWeapons))
                .ApplyMultiplier(stats.Engineering[StatType.Multiplier]);

            stats.Range[StatType.TotalVisible] = (stats.Range[StatType.Base])
                .ApplyMultiplier(stats.Range[StatType.Multiplier]);

            stats.Armor[StatType.TotalVisible] = (stats.Armor[StatType.Base] +
                WeaponBonusManager.ArmorWeaponClassBonus(stats.MedievalWeapons, stats.EtherealWeapons, stats.BluntWeapons))
                .ApplyMultiplier(stats.Armor[StatType.Multiplier]);

            stats.Dodge[StatType.TotalVisible] = (stats.Dodge[StatType.Base] +
                WeaponBonusManager.DodgeWeaponClassBonus(stats.UnarmedWeapons, stats.MedievalWeapons, stats.EtherealWeapons))
                .ApplyMultiplier(stats.Dodge[StatType.Multiplier]);

            stats.Speed[StatType.TotalVisible] = (stats.Speed[StatType.Base] +
                WeaponBonusManager.SpeedWeaponClassBonus(stats.BluntWeapons))
                .ApplyMultiplier(stats.Speed[StatType.Multiplier]);

            stats.Luck[StatType.TotalVisible] = (stats.Luck[StatType.Base])
                .ApplyMultiplier(stats.Luck[StatType.Multiplier]);

            stats.Harvesting[StatType.TotalVisible] = (stats.Harvesting[StatType.Base] +
                WeaponBonusManager.HarvestingWeaponClassBonus(stats.SupportWeapons))
                .ApplyMultiplier(stats.Harvesting[StatType.Multiplier]);

            stats.XPGain[StatType.TotalVisible] = stats.XPGain[StatType.Base];
        }
    }
}