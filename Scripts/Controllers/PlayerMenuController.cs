/*
 * PlayerMenuController.cs
 * Script Author: Charles d'Ansembourg
 * Creation Date: 10/06/2024
 * Contact: c.dansembourg@icloud.com
 */

using Brotato_Clone.Models;
using Brotato_Clone.Views;
using UnityEngine;

namespace Brotato_Clone.Controllers
{
    public class PlayerMenuController : MonoBehaviour
    {
        private PlayerMenuView _playerMenuView;
        private int _upgradeCount;

        public void Initialize()
        {
            _playerMenuView = GetComponent<PlayerMenuView>();

            EventManager.Subscribe<Upgrade>(PlayerEvent.PlayerSelectUpgrade, OnSelected);
        }

        public void ShowMenu(int levelsGained)
        {
            _upgradeCount = levelsGained;
            _playerMenuView.ShowLevelMenu();
            LoadUpgrades();
        }

        public void LoadUpgrades()
        {
            if (_upgradeCount-- == 0)
            {
                _playerMenuView.ShowShopMenu();
                return;
            }

            _playerMenuView.ClearLevelMenu();

            for (int i = 0; i < 4; i++)
            {
                int index = Random.Range(0, UpgradesData.Upgrades.Count);

                Upgrade upgrade = UpgradesData.Upgrades[index];
                _playerMenuView.LoadUpgrade(upgrade);
            }
        }

        private void OnSelected(Upgrade item)
        {
            LoadUpgrades();
        }
    }
}