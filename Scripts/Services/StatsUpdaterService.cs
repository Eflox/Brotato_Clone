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
            stats.MaxHP[StatType.TotalVisible] = (stats.MaxHP[StatType.Base] + stats.MaxHP[StatType.Temporary] +
                WeaponBonusManager.MaxHPWeaponClassBonus(stats.LegendaryWeapons, stats.PrimitiveWeapons, stats.BluntWeapons))
                .ApplyMultiplier(stats.MaxHP[StatType.Multiplier]);

            stats.HPRegen[StatType.TotalVisible] = (stats.HPRegen[StatType.Base] + stats.HPRegen[StatType.Temporary] +
                WeaponBonusManager.HPRegenWeaponClassBonus(stats.MedicalWeapons))
                .ApplyMultiplier(stats.HPRegen[StatType.Multiplier]);

            stats.LifeSteal[StatType.TotalVisible] = (stats.LifeSteal[StatType.Base] + stats.LifeSteal[StatType.Temporary] +
                WeaponBonusManager.LifeStealWeaponClassBonus(stats.BladeWeapons))
                .ApplyMultiplier(stats.LifeSteal[StatType.Multiplier]);

            stats.Damage[StatType.TotalVisible] = (stats.Damage[StatType.Base] + stats.Damage[StatType.Temporary] +
                WeaponBonusManager.DamageWeaponClassBonus(stats.HeavyWeapons))
                .ApplyMultiplier(stats.Damage[StatType.Multiplier]);

            stats.MeleeDmg[StatType.TotalVisible] = (stats.MeleeDmg[StatType.Base] + stats.MeleeDmg[StatType.Temporary] +
                WeaponBonusManager.MeleeDmgWeaponClassBonus(stats.BladeWeapons))
                .ApplyMultiplier(stats.MeleeDmg[StatType.Multiplier]);

            stats.RangedDmg[StatType.TotalVisible] = (stats.RangedDmg[StatType.Base] + stats.RangedDmg[StatType.Temporary])
                .ApplyMultiplier(stats.RangedDmg[StatType.Multiplier]);

            stats.ElementalDmg[StatType.TotalVisible] = (stats.ElementalDmg[StatType.Base] + stats.ElementalDmg[StatType.Temporary] +
                WeaponBonusManager.ElementalDmgWeaponClassBonus(stats.ElementalWeapons))
                .ApplyMultiplier(stats.ElementalDmg[StatType.Multiplier]);

            stats.AttackSpeed[StatType.TotalVisible] = (stats.AttackSpeed[StatType.Base] + stats.AttackSpeed[StatType.Temporary])
                .ApplyMultiplier(stats.AttackSpeed[StatType.Multiplier]);

            stats.CritChance[StatType.TotalVisible] = (stats.CritChance[StatType.Base] + stats.CritChance[StatType.Temporary] +
                WeaponBonusManager.CritChanceWeaponClassBonus(stats.PreciseWeapons))
                .ApplyMultiplier(stats.CritChance[StatType.Multiplier]);

            stats.Engineering[StatType.TotalVisible] = (stats.Engineering[StatType.Base] + stats.Engineering[StatType.Temporary] +
                WeaponBonusManager.EngineeringWeaponClassBonus(stats.ToolWeapons))
                .ApplyMultiplier(stats.Engineering[StatType.Multiplier]);

            stats.Range[StatType.TotalVisible] = (stats.Range[StatType.Base] + stats.Range[StatType.Temporary])
                .ApplyMultiplier(stats.Range[StatType.Multiplier]);

            stats.Armor[StatType.TotalVisible] = (stats.Armor[StatType.Base] + stats.Armor[StatType.Temporary] +
                WeaponBonusManager.ArmorWeaponClassBonus(stats.MedievalWeapons, stats.EtherealWeapons, stats.BluntWeapons))
                .ApplyMultiplier(stats.Armor[StatType.Multiplier]);

            stats.Dodge[StatType.TotalVisible] = (stats.Dodge[StatType.Base] + stats.Dodge[StatType.Temporary] +
                WeaponBonusManager.DodgeWeaponClassBonus(stats.UnarmedWeapons, stats.MedievalWeapons, stats.EtherealWeapons))
                .ApplyMultiplier(stats.Dodge[StatType.Multiplier]);

            stats.Speed[StatType.TotalVisible] = (stats.Speed[StatType.Base] + stats.Speed[StatType.Temporary] +
                WeaponBonusManager.SpeedWeaponClassBonus(stats.BluntWeapons))
                .ApplyMultiplier(stats.Speed[StatType.Multiplier]);

            stats.Luck[StatType.TotalVisible] = (stats.Luck[StatType.Base] + stats.Luck[StatType.Temporary])
                .ApplyMultiplier(stats.Luck[StatType.Multiplier]);

            stats.Harvesting[StatType.TotalVisible] = (stats.Harvesting[StatType.Base] + stats.Harvesting[StatType.Temporary] +
                WeaponBonusManager.HarvestingWeaponClassBonus(stats.SupportWeapons))
                .ApplyMultiplier(stats.Harvesting[StatType.Multiplier]);

            stats.XPGain[StatType.TotalVisible] = (stats.XPGain[StatType.Base] + stats.XPGain[StatType.Temporary])
                .ApplyMultiplier(stats.XPGain[StatType.Multiplier]);
        }
    }
}