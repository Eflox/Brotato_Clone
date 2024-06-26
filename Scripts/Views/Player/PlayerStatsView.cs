/*
 * PlayerStatsView.cs
 * Script Author: Charles d'Ansembourg
 * Creation Date: 11/06/2024
 * Contact: c.dansembourg@icloud.com
 */

using Brotato_Clone.Extensions;
using Brotato_Clone.Models;
using TMPro;
using UnityEngine;

namespace Brotato_Clone.Player.Views
{
    public class PlayerStatsView : MonoBehaviour
    {
        [SerializeField]
        private TMP_Text _maxHPText;

        [SerializeField]
        private TMP_Text _HPRegenText;

        [SerializeField]
        private TMP_Text _lifeStealText;

        [SerializeField]
        private TMP_Text _damageText;

        [SerializeField]
        private TMP_Text _meleeDamageText;

        [SerializeField]
        private TMP_Text _rangedDamageText;

        [SerializeField]
        private TMP_Text _elementalDamageText;

        [SerializeField]
        private TMP_Text _attackSpeedText;

        [SerializeField]
        private TMP_Text _critChanceText;

        [SerializeField]
        private TMP_Text _engineeringText;

        [SerializeField]
        private TMP_Text _rangeText;

        [SerializeField]
        private TMP_Text _ArmorText;

        [SerializeField]
        private TMP_Text _DodgeText;

        [SerializeField]
        private TMP_Text _SpeedText;

        [SerializeField]
        private TMP_Text _LuckText;

        [SerializeField]
        private TMP_Text _HarvestingText;

        public void Initialize()
        {
            EventManager.Subscribe<PlayerStats>(PlayerEvent.PlayerStatsChanged, OnPlayerStatsChanged);
        }

        private void OnPlayerStatsChanged(PlayerStats stats)
        {
            _maxHPText.text = stats.MaxHP[StatType.TotalVisible].ToString().WithPN();
            _HPRegenText.text = stats.HPRegen[StatType.TotalVisible].ToString().WithPN();
            _lifeStealText.text = stats.LifeSteal[StatType.TotalVisible].ToString().WithPN();
            _damageText.text = stats.Damage[StatType.TotalVisible].ToString().WithPN();
            _meleeDamageText.text = stats.MeleeDmg[StatType.TotalVisible].ToString().WithPN();
            _rangedDamageText.text = stats.RangedDmg[StatType.TotalVisible].ToString().WithPN();
            _elementalDamageText.text = stats.ElementalDmg[StatType.TotalVisible].ToString().WithPN();
            _attackSpeedText.text = stats.AttackSpeed[StatType.TotalVisible].ToString().WithPN();
            _critChanceText.text = stats.CritChance[StatType.TotalVisible].ToString().WithPN();
            _engineeringText.text = stats.Engineering[StatType.TotalVisible].ToString().WithPN();
            _rangeText.text = stats.Range[StatType.TotalVisible].ToString().WithPN();
            _ArmorText.text = stats.Armor[StatType.TotalVisible].ToString().WithPN();
            _DodgeText.text = stats.Dodge[StatType.TotalVisible].ToString().WithPN();
            _SpeedText.text = stats.Speed[StatType.TotalVisible].ToString().WithPN();
            _LuckText.text = stats.Luck[StatType.TotalVisible].ToString().WithPN();
            _HarvestingText.text = stats.Harvesting[StatType.TotalVisible].ToString().WithPN();
        }
    }
}