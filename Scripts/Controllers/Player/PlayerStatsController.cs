/*
 * PlayerStatsController.cs
 * Script Author: Charles d'Ansembourg
 * Creation Date: 11/06/2024
 * Contact: c.dansembourg@icloud.com
 */

using Brotato_Clone.Extensions;
using Brotato_Clone.Interfaces;
using Brotato_Clone.Models;
using Brotato_Clone.Services;
using System;
using System.Collections.Generic;
using System.Reflection;
using UnityEngine;

namespace Brotato_Clone.Controllers
{
    /// <summary>
    /// Handles the stat manipulation of the player.
    /// </summary>
    public class PlayerStatsController : MonoBehaviour
    {
        #region Fields

        [SerializeField]
        private PlayerStats _playerStats;

        #endregion Fields

        #region Public Methods

        /// <summary>
        /// Initializes the player stats controller by subscribing to the drop pickup event.
        /// </summary>
        public void Initialize()
        {
            //EventManager.Subscribe<IDrop>(PlayerEvent.PlayerPickupDrop, OnDropPickup);
            EventManager.Subscribe<int>(PlayerEvent.PlayerPayed, OnPlayerPayed);
        }

        /// <summary>
        /// Gets the current player stats.
        /// </summary>
        public PlayerStats GetStats()
        {
            return _playerStats;
        }

        public void NewGameStats()
        {
            Debug.Log("new wave");
            _playerStats.CurrentWave = 1;
            _playerStats.CurrentLvl = 0;
            _playerStats.CurrentXp = 0;
            _playerStats.CurrentMaterials = 0;
            _playerStats.CurrentBagMaterials = 0;

            SaveStats();
        }

        /// <summary>
        /// Initializes the stats at the start of the wave.
        /// </summary>
        public void StartWaveStats()
        {
            _playerStats.CurrentHP = _playerStats.MaxHP[StatType.TotalVisible];

            _playerStats.CurrentWave = PlayerPrefs.GetInt("Wave");
            _playerStats.CurrentLvl = PlayerPrefs.GetInt("Level");
            _playerStats.CurrentXp = PlayerPrefs.GetInt("Xp");
            _playerStats.CurrentMaterials = PlayerPrefs.GetInt("Materials");
            _playerStats.CurrentBagMaterials = PlayerPrefs.GetInt("BagMaterials");

            EventManager.TriggerEvent(PlayerEvent.PlayerStatsChanged, _playerStats);
        }

        public void NextWave()
        {
            _playerStats.CurrentWave++;
        }

        public void SaveStats()
        {
            PlayerPrefs.SetInt("Wave", _playerStats.CurrentWave);
            PlayerPrefs.SetInt("Level", _playerStats.CurrentLvl);
            PlayerPrefs.SetInt("Xp", _playerStats.CurrentXp);
            PlayerPrefs.SetInt("Materials", _playerStats.CurrentMaterials);
            PlayerPrefs.SetInt("BagMaterials", _playerStats.CurrentBagMaterials);
        }

        /// <summary>
        /// Updates the player stats based on a list of items.
        /// </summary>
        public void UpdateStats(List<Item> items)
        {
            _playerStats.SetDefaults();

            foreach (var item in items)
                ApplyItem(item);

            FinalStatsWithWeaponBonuses();

            EventManager.TriggerEvent(PlayerEvent.PlayerStatsChanged, _playerStats);
        }

        /// <summary>
        /// Updates material count
        /// </summary>
        public void UpdateMaterials(int materials)
        {
            _playerStats.CurrentMaterials += materials;
            IncreaseXP(materials);
            EventManager.TriggerEvent(PlayerEvent.PlayerStatsChanged, _playerStats);
        }

        #endregion Public Methods

        #region Private Methods

        private void OnPlayerPayed(int amount)
        {
            _playerStats.CurrentMaterials -= amount;
            PlayerPrefs.SetInt("Materials", _playerStats.CurrentMaterials);
            EventManager.TriggerEvent(PlayerEvent.PlayerStatsChanged, _playerStats);
        }

        private void IncreaseXP(int value)
        {
            _playerStats.CurrentXp += value;

            if (_playerStats.CurrentXp >= LevelData.LevelsXP[_playerStats.CurrentLvl])
            {
                _playerStats.CurrentXp = 0;
                _playerStats.CurrentLvl++;
                _playerStats.LevelsGainedDuringWave++;
            }
        }

        private void OnDisable()
        {
            EventManager.Unsubscribe<IDrop>(PlayerEvent.PlayerPickupDrop, OnDropPickup);
        }

        private void ApplyItem(Item item)
        {
            if (item.Attribute == null)
                return;

            ApplyItemStats(item.Attribute);
        }

        private void ApplyItemStats(IAttribute attribute)
        {
            var attributeType = attribute.GetType();
            var statsType = typeof(PlayerStats);

            foreach (var attributeField in attributeType.GetFields(BindingFlags.Public | BindingFlags.Instance))
            {
                var statAttribute = attributeField.GetCustomAttribute<StatAttribute>();

                if (statAttribute != null)
                    ApplyStat(attribute, attributeField, statAttribute, statsType);
            }
        }

        private void ApplyStat(IAttribute attribute, FieldInfo attributeField, StatAttribute statAttribute, Type statsType)
        {
            string statFieldName = attributeField.Name.Replace("Multiplier", "");
            var statField = statsType.GetField(statFieldName);
            if (statField != null)
            {
                if (statField.FieldType == typeof(Dictionary<StatType, int>))
                {
                    var statDict = (Dictionary<StatType, int>)statField.GetValue(_playerStats);
                    int valueToApply = (int)attributeField.GetValue(attribute);
                    var statType = statAttribute.IsMultiplier ? StatType.Multiplier : StatType.Base;

                    if (statAttribute.Operation == StatOperation.Add)
                        statDict[statType] += valueToApply;
                    else if (statAttribute.Operation == StatOperation.Set)
                        statDict[statType] = valueToApply;
                }
                else if (statField.FieldType == typeof(int))
                {
                    int valueToApply = (int)attributeField.GetValue(attribute);

                    if (statAttribute.Operation == StatOperation.Add)
                    {
                        int currentValue = (int)statField.GetValue(_playerStats);
                        statField.SetValue(_playerStats, currentValue + valueToApply);
                    }
                    else if (statAttribute.Operation == StatOperation.Set)
                        statField.SetValue(_playerStats, valueToApply);
                }
            }
        }

        private void OnDropPickup(IDrop drop)
        {
            _playerStats.CurrentMaterials += drop.Value;
            _playerStats.CurrentXp += drop.Value;

            if (_playerStats.CurrentXp >= LevelData.LevelsXP[_playerStats.CurrentLvl])
            {
                _playerStats.CurrentLvl++;
                _playerStats.LevelsGainedDuringWave++;
                _playerStats.CurrentXp = 0;
            }

            EventManager.TriggerEvent(PlayerEvent.PlayerStatsChanged, _playerStats);
        }

        private void FinalStatsWithWeaponBonuses()
        {
            _playerStats.MaxHP[StatType.TotalVisible] = (_playerStats.MaxHP[StatType.Base] +
                WeaponBonusManager.MaxHPWeaponClassBonus(_playerStats.LegendaryWeapons, _playerStats.PrimitiveWeapons, _playerStats.BluntWeapons))
                .ApplyMultiplier(_playerStats.MaxHP[StatType.Multiplier]);

            _playerStats.HPRegen[StatType.TotalVisible] = (_playerStats.HPRegen[StatType.Base] +
                WeaponBonusManager.HPRegenWeaponClassBonus(_playerStats.MedicalWeapons))
                .ApplyMultiplier(_playerStats.HPRegen[StatType.Multiplier]);

            _playerStats.LifeSteal[StatType.TotalVisible] = (_playerStats.LifeSteal[StatType.Base] +
                WeaponBonusManager.LifeStealWeaponClassBonus(_playerStats.BladeWeapons))
                .ApplyMultiplier(_playerStats.LifeSteal[StatType.Multiplier]);

            _playerStats.Damage[StatType.TotalVisible] = (_playerStats.Damage[StatType.Base] +
                WeaponBonusManager.DamageWeaponClassBonus(_playerStats.HeavyWeapons))
                .ApplyMultiplier(_playerStats.Damage[StatType.Multiplier]);

            _playerStats.MeleeDmg[StatType.TotalVisible] = (_playerStats.MeleeDmg[StatType.Base] +
                WeaponBonusManager.MeleeDmgWeaponClassBonus(_playerStats.BladeWeapons))
                .ApplyMultiplier(_playerStats.MeleeDmg[StatType.Multiplier]);

            _playerStats.RangedDmg[StatType.TotalVisible] = (_playerStats.RangedDmg[StatType.Base])
                .ApplyMultiplier(_playerStats.RangedDmg[StatType.Multiplier]);

            _playerStats.ElementalDmg[StatType.TotalVisible] = (_playerStats.ElementalDmg[StatType.Base] +
                WeaponBonusManager.ElementalDmgWeaponClassBonus(_playerStats.ElementalWeapons))
                .ApplyMultiplier(_playerStats.ElementalDmg[StatType.Multiplier]);

            _playerStats.AttackSpeed[StatType.TotalVisible] = (_playerStats.AttackSpeed[StatType.Base])
                .ApplyMultiplier(_playerStats.AttackSpeed[StatType.Multiplier]);

            _playerStats.CritChance[StatType.TotalVisible] = (_playerStats.CritChance[StatType.Base] +
                WeaponBonusManager.CritChanceWeaponClassBonus(_playerStats.PreciseWeapons))
                .ApplyMultiplier(_playerStats.CritChance[StatType.Multiplier]);

            _playerStats.Engineering[StatType.TotalVisible] = (_playerStats.Engineering[StatType.Base] +
                WeaponBonusManager.EngineeringWeaponClassBonus(_playerStats.ToolWeapons))
                .ApplyMultiplier(_playerStats.Engineering[StatType.Multiplier]);

            _playerStats.Range[StatType.TotalVisible] = (_playerStats.Range[StatType.Base])
                .ApplyMultiplier(_playerStats.Range[StatType.Multiplier]);

            _playerStats.Armor[StatType.TotalVisible] = (_playerStats.Armor[StatType.Base] +
                WeaponBonusManager.ArmorWeaponClassBonus(_playerStats.MedievalWeapons, _playerStats.EtherealWeapons, _playerStats.BluntWeapons))
                .ApplyMultiplier(_playerStats.Armor[StatType.Multiplier]);

            _playerStats.Dodge[StatType.TotalVisible] = (_playerStats.Dodge[StatType.Base] +
                WeaponBonusManager.DodgeWeaponClassBonus(_playerStats.UnarmedWeapons, _playerStats.MedievalWeapons, _playerStats.EtherealWeapons))
                .ApplyMultiplier(_playerStats.Dodge[StatType.Multiplier]);

            _playerStats.Speed[StatType.TotalVisible] = (_playerStats.Speed[StatType.Base] +
                WeaponBonusManager.SpeedWeaponClassBonus(_playerStats.BluntWeapons))
                .ApplyMultiplier(_playerStats.Speed[StatType.Multiplier]);

            _playerStats.Luck[StatType.TotalVisible] = (_playerStats.Luck[StatType.Base])
                .ApplyMultiplier(_playerStats.Luck[StatType.Multiplier]);

            _playerStats.Harvesting[StatType.TotalVisible] = (_playerStats.Harvesting[StatType.Base] +
                WeaponBonusManager.HarvestingWeaponClassBonus(_playerStats.SupportWeapons))
                .ApplyMultiplier(_playerStats.Harvesting[StatType.Multiplier]);

            _playerStats.XPGain[StatType.TotalVisible] = _playerStats.XPGain[StatType.Base];
        }

        #endregion Private Methods
    }
}