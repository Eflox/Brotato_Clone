/*
 * LevelUpMenuController.cs
 * Script Author: Charles d'Ansembourg
 * Creation Date: 10/06/2024
 * Contact: c.dansembourg@icloud.com
 */

using Brotato_Clone.Models;
using Brotato_Clone.Views;
using UnityEngine;

namespace Brotato_Clone.Controllers
{
    public class LevelUpMenuController : MonoBehaviour
    {
        [SerializeField]
        private PlayerController _playerController;

        [SerializeField]
        private LevelUpMenuView _levelUpMenuView;

        public void OpenLevelUpMenu(int levelsGained)
        {
            _levelUpMenuView.Initialize();
            LoadUpgrades();
        }

        public void LoadUpgrades()
        {
            for (int i = 0; i < 4; i++)
            {
                int index = Random.Range(0, UpgradesData.Upgrades.Count);

                Upgrade upgrade = UpgradesData.Upgrades[index];
                _levelUpMenuView.LoadUpgrade(upgrade);
            }
        }

        public void UpgradeSelected(Upgrade upgrade)
        {
            _playerController.AddUpgrade(upgrade);
        }
    }
}