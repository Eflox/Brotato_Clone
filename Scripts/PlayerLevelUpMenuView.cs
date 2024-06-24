/*
 * PlayerLevelUpMenuView.cs
 * Script Author: Charles d'Ansembourg
 * Creation Date: 10/06/2024
 * Contact: c.dansembourg@icloud.com
 */

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

        public void ShowMenu()
        {
            _levelUpMenu.SetActive(true);
        }

        public void ClearMenu()
        {
            foreach (Transform child in _levelUpContainer)
            {
                Destroy(child);
            }
            Debug.Log("Cleared");
        }

        public void LoadUpgrade(Upgrade upgrade)
        {
            Instantiate(_upgradesPrefab, _levelUpContainer)
                .GetComponent<UpgradeView>()
                .Initialize(upgrade);
        }
    }
}