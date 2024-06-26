/*
 * PlayerLevelUpMenuView.cs
 * Script Author: Charles d'Ansembourg
 * Creation Date: 10/06/2024
 * Contact: c.dansembourg@icloud.com
 */

using System.Collections.Generic;
using System.Linq;
using UnityEngine;

namespace Brotato_Clone.Views
{
    public class PlayerLevelUpMenuView : MonoBehaviour
    {
        [SerializeField]
        private GameObject _levelUpMenu;

        [SerializeField]
        private Transform _levelUpContainer;

        [SerializeField]
        private GameObject _upgradesPrefab;

        private List<UpgradeView> _upgradeViews = new List<UpgradeView>();

        public void ShowMenu()
        {
            _levelUpMenu.SetActive(true);
        }

        public void ClearMenu()
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