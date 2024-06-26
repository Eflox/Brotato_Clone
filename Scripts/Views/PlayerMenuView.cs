/*
 * PlayerMenuView.cs
 * Script Author: Charles d'Ansembourg
 * Creation Date: 10/06/2024
 * Contact: c.dansembourg@icloud.com
 */

using Brotato_Clone.Models;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;

namespace Brotato_Clone.Views
{
    public class PlayerMenuView : MonoBehaviour
    {
        [SerializeField]
        private GameObject _shopMenu;

        [SerializeField]
        private GameObject _levelUpMenu;

        [SerializeField]
        private Transform _levelUpContainer;

        [SerializeField]
        private GameObject _upgradesPrefab;

        private List<UpgradeView> _upgradeViews = new List<UpgradeView>();

        public void ShowShopMenu()
        {
            _levelUpMenu.SetActive(false);
            _shopMenu.SetActive(true);

            EventManager.TriggerEvent(GameEvent.EnterShop);
        }

        public void ShowLevelMenu()
        {
            _levelUpMenu.SetActive(true);
        }

        public void ClearLevelMenu()
        {
            _upgradeViews.ForEach(u => u.Remove());
            _upgradeViews.Clear();
        }

        public void LoadUpgrade(Upgrade upgrade)
        {
            _upgradeViews.Add(Instantiate(_upgradesPrefab, _levelUpContainer)
                .GetComponent<UpgradeView>());

            _upgradeViews.Last().Initialize(upgrade);
        }
    }
}