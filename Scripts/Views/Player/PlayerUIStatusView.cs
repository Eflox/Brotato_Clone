/*
 * PlayerUIStatusView.cs
 * Script Author: Charles d'Ansembourg
 * Creation Date: 11/06/2024
 * Contact: c.dansembourg@icloud.com
 */

using Brotato_Clone.Models;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

namespace Brotato_Clone.Player.Views
{
    /// <summary>
    /// Manages the player's UI status, including health, level, and materials display.
    /// </summary>
    public class PlayerUIStatusView : MonoBehaviour
    {
        #region Fields

        [SerializeField]
        private TMP_Text _healthText;

        [SerializeField]
        private Transform _healthBar;

        [SerializeField]
        private TMP_Text _levelText;

        [SerializeField]
        private Transform _levelBar;

        [SerializeField]
        private TMP_Text _materialsText;

        [SerializeField]
        private TMP_Text _bagMaterialsText;

        [SerializeField]
        private Image _bagSprite;

        #endregion Fields

        #region Public Methods

        /// <summary>
        /// Initializes the player UI status view by subscribing to relevant events.
        /// </summary>
        public void Initialize()
        {
            Debug.Log("First");
            EventManager.Subscribe<PlayerStats>(PlayerEvent.PlayerStatsChanged, OnPlayerStatsChanged);
        }

        /// <summary>
        /// Updates the UI based on the player's stats.
        /// </summary>
        public void OnPlayerStatsChanged(PlayerStats playerStats)
        {
            Debug.Log("Second");
            SetHealth(playerStats.CurrentHP, playerStats.MaxHP[StatType.TotalVisible]);
            SetLevel(playerStats.CurrentLvl, playerStats.CurrentXp, LevelData.LevelsXP[playerStats.CurrentLvl]);
            SetMaterials(playerStats.CurrentMaterials);
            SetBagMaterials(playerStats.CurrentBagMaterials);
        }

        #endregion Public Methods

        #region Private Methods

        private void SetHealth(int currentHealth, int maxHealth)
        {
            if (_healthText != null && _healthBar != null)
            {
                _healthText.text = $"{currentHealth} / {maxHealth}";

                float healthPercentage = (float)currentHealth / maxHealth;
                _healthBar.localScale = new Vector3(healthPercentage, _healthBar.localScale.y, _healthBar.localScale.z);
            }
            else
            {
                Debug.LogWarning("Health text or health bar is null.");
            }
        }

        private void SetLevel(int level, int xp, int nextLevelXp)
        {
            if (_levelText != null && _levelBar != null)
            {
                _levelText.text = $"LV.{level}";

                float levelPercentage = (float)xp / nextLevelXp;
                _levelBar.localScale = new Vector3(levelPercentage, _levelBar.localScale.y, _levelBar.localScale.z);
            }
            else
            {
                Debug.LogWarning("Level text or level bar is null.");
            }
        }

        private void SetMaterials(int materials)
        {
            if (_materialsText != null)
            {
                _materialsText.text = $"{materials}";
            }
            else
            {
                Debug.LogWarning("Materials text is null.");
            }
        }

        private void SetBagMaterials(int bagMaterials)
        {
            if (_bagMaterialsText != null && _bagSprite != null)
            {
                if (bagMaterials != 0)
                {
                    _bagSprite.enabled = true;
                    _bagMaterialsText.text = $"{bagMaterials}";
                }
                else
                {
                    _bagMaterialsText.text = "";
                    _bagSprite.enabled = false;
                }
            }
            else
            {
                Debug.LogWarning("Bag materials text or bag sprite is null.");
            }
        }

        #endregion Private Methods
    }
}