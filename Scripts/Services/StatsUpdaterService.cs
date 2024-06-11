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
        private WeaponBonusCalculatorService _weaponBonusCalculatorService;

        /// <summary>
        /// Constructor for StatsUpdaterService
        /// </summary>
        public StatsUpdaterService()
        {
            _weaponBonusCalculatorService = new WeaponBonusCalculatorService();
        }

        /// <summary>
        /// Updates TotalVisible of stats with multipliers and weapon bonuses included
        /// </summary>
        public void UpdateVisibleStats(PlayerStats stats)
        {
            stats.MaxHP[StatType.TotalVisible] = (stats.MaxHP[StatType.Base] +
                _weaponBonusCalculatorService.MaxHPWeaponClassBonus(stats.LegendaryWeapons, stats.PrimitiveWeapons, stats.BluntWeapons))
                .ApplyMultiplier(stats.MaxHP[StatType.Multiplier]);

            stats.HPRegen[StatType.TotalVisible] = (stats.HPRegen[StatType.Base] +
                _weaponBonusCalculatorService.HPRegenWeaponClassBonus(stats.MedicalWeapons))
                .ApplyMultiplier(stats.HPRegen[StatType.Multiplier]);

            stats.LifeSteal[StatType.TotalVisible] = (stats.LifeSteal[StatType.Base] +
                _weaponBonusCalculatorService.LifeStealWeaponClassBonus(stats.BladeWeapons))
                .ApplyMultiplier(stats.LifeSteal[StatType.Multiplier]);

            stats.Damage[StatType.TotalVisible] = (stats.Damage[StatType.Base] +
                _weaponBonusCalculatorService.DamageWeaponClassBonus(stats.HeavyWeapons))
                .ApplyMultiplier(stats.Damage[StatType.Multiplier]);

            stats.MeleeDmg[StatType.TotalVisible] = (stats.MeleeDmg[StatType.Base] +
                _weaponBonusCalculatorService.MeleeDmgWeaponClassBonus(stats.BladeWeapons))
                .ApplyMultiplier(stats.MeleeDmg[StatType.Multiplier]);

            stats.RangedDmg[StatType.TotalVisible] = (stats.RangedDmg[StatType.Base])
                .ApplyMultiplier(stats.RangedDmg[StatType.Multiplier]);

            stats.ElementalDmg[StatType.TotalVisible] = (stats.ElementalDmg[StatType.Base] +
                _weaponBonusCalculatorService.ElementalDmgWeaponClassBonus(stats.ElementalWeapons))
                .ApplyMultiplier(stats.ElementalDmg[StatType.Multiplier]);

            stats.AttackSpeed[StatType.TotalVisible] = (stats.AttackSpeed[StatType.Base])
                .ApplyMultiplier(stats.AttackSpeed[StatType.Multiplier]);

            stats.CritChance[StatType.TotalVisible] = (stats.CritChance[StatType.Base] +
                _weaponBonusCalculatorService.CritChanceWeaponClassBonus(stats.PreciseWeapons))
                .ApplyMultiplier(stats.CritChance[StatType.Multiplier]);

            stats.Engineering[StatType.TotalVisible] = (stats.Engineering[StatType.Base] +
                _weaponBonusCalculatorService.EngineeringWeaponClassBonus(stats.ToolWeapons))
                .ApplyMultiplier(stats.Engineering[StatType.Multiplier]);

            stats.Range[StatType.TotalVisible] = (stats.Range[StatType.Base])
                .ApplyMultiplier(stats.Range[StatType.Multiplier]);

            stats.Armor[StatType.TotalVisible] = (stats.Armor[StatType.Base] +
                _weaponBonusCalculatorService.ArmorWeaponClassBonus(stats.MedievalWeapons, stats.EtherealWeapons, stats.BluntWeapons))
                .ApplyMultiplier(stats.Armor[StatType.Multiplier]);

            stats.Dodge[StatType.TotalVisible] = (stats.Dodge[StatType.Base] +
                _weaponBonusCalculatorService.DodgeWeaponClassBonus(stats.UnarmedWeapons, stats.MedievalWeapons, stats.EtherealWeapons))
                .ApplyMultiplier(stats.Dodge[StatType.Multiplier]);

            stats.Speed[StatType.TotalVisible] = (stats.Speed[StatType.Base] +
                _weaponBonusCalculatorService.SpeedWeaponClassBonus(stats.BluntWeapons))
                .ApplyMultiplier(stats.Speed[StatType.Multiplier]);

            stats.Luck[StatType.TotalVisible] = (stats.Luck[StatType.Base])
                .ApplyMultiplier(stats.Luck[StatType.Multiplier]);

            stats.Harvesting[StatType.TotalVisible] = (stats.Harvesting[StatType.Base] +
                _weaponBonusCalculatorService.HarvestingWeaponClassBonus(stats.SupportWeapons))
                .ApplyMultiplier(stats.Harvesting[StatType.Multiplier]);

            stats.XPGain[StatType.TotalVisible] = stats.XPGain[StatType.Base];
        }
    }
}