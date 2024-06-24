/*
 * PlayerLevelUpMenuController.cs
 * Script Author: Charles d'Ansembourg
 * Creation Date: 10/06/2024
 * Contact: c.dansembourg@icloud.com
 */

using Brotato_Clone.Models;
using Brotato_Clone.Views;
using UnityEngine;
using UnityEngine.SceneManagement;

namespace Brotato_Clone.Controllers
{
    public class PlayerLevelUpMenuController : MonoBehaviour
    {
        private PlayerLevelUpMenuView _playerLevelUpMenuView;
        private int _upgradeCount;

        public void Initialize()
        {
            _playerLevelUpMenuView = GetComponent<PlayerLevelUpMenuView>();

            EventManager.Subscribe<NItem>(PlayerEvent.PlayerSelectItem, OnSelected);
        }

        public void ShowMenu(int levelsGained)
        {
            _upgradeCount = levelsGained;
            _playerLevelUpMenuView.ShowMenu();
            LoadUpgrades();
        }

        public void LoadUpgrades()
        {
            _playerLevelUpMenuView.ClearMenu();

            if (_upgradeCount-- == 0)
            {
                SceneManager.LoadScene("ShopScene");
                return;
            }

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