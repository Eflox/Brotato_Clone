/*
 * PlayerLevelUpMenuController.cs
 * Script Author: Charles d'Ansembourg
 * Creation Date: 10/06/2024
 * Contact: c.dansembourg@icloud.com
 */

using Brotato_Clone.Models;
using Brotato_Clone.Views;
using UnityEngine;

namespace Brotato_Clone.Controllers
{
    public class PlayerLevelUpMenuController : MonoBehaviour
    {
        private PlayerLevelUpMenuView _playerLevelUpMenuView;

        public void Initialize()
        {
            _playerLevelUpMenuView = GetComponent<PlayerLevelUpMenuView>();

            EventManager.Subscribe<NItem>(PlayerEvent.PlayerSelectItem, OnSelected);
        }

        public void ShowMenu(int levelsGained)
        {
            _playerLevelUpMenuView.ShowMenu();
            LoadUpgrades();
        }

        public void LoadUpgrades()
        {
            _playerLevelUpMenuView.ClearMenu();

            for (int i = 0; i < 4; i++)
            {
                int index = Random.Range(0, UpgradesData.Upgrades.Count);

                Upgrade upgrade = UpgradesData.Upgrades[index];
                _playerLevelUpMenuView.LoadUpgrade(upgrade);
            }
        }

        private void OnSelected(NItem item)
        {
            LoadUpgrades();
        }
    }
}