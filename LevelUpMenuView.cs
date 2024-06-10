/*
 * LevelUpMenuView.cs
 * Script Author: Charles d'Ansembourg
 * Creation Date: 10/06/2024
 * Contact: c.dansembourg@icloud.com
 */

using Brotato_Clone.Controllers;
using UnityEngine;

namespace Brotato_Clone.Views
{
    public class LevelUpMenuView : MonoBehaviour
    {
        [SerializeField]
        private LevelUpMenuController _levelUpMenuController;

        [SerializeField]
        private GameObject _levelUpMenu;

        [SerializeField]
        private Transform _levelUpContainer;

        [SerializeField]
        private GameObject _upgradesPrefab;

        public void Initialize()
        {
            _levelUpMenu.SetActive(true);
        }

        public void LoadUpgrade(Upgrade upgrade)
        {
            Instantiate(_upgradesPrefab, _levelUpContainer)
                .GetComponent<UpgradeView>()
                .Initialize(_levelUpMenuController, upgrade);
        }
    }
}