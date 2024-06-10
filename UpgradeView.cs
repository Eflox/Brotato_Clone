/*
 * UpgradeView.cs
 * Script Author: Charles d'Ansembourg
 * Creation Date: 10/06/2024
 * Contact: c.dansembourg@icloud.com
 */

using Brotato_Clone.Controllers;
using Brotato_Clone.Extensions;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

namespace Brotato_Clone.Views
{
    public class UpgradeView : MonoBehaviour
    {
        [SerializeField]
        private TMP_Text _name;

        [SerializeField]
        private Image _icon;

        [SerializeField]
        private TMP_Text _description;

        [SerializeField]
        private Button _chooseButton;

        private LevelUpMenuController _levelUpMenuController;
        private Upgrade _upgrade;

        public void Initialize(LevelUpMenuController levelUpMenuController, Upgrade upgrade)
        {
            _levelUpMenuController = levelUpMenuController;
            _upgrade = upgrade;
            _chooseButton.onClick.AddListener(Selected);

            _name.text = _upgrade.Name;
            _icon.sprite = _upgrade.Icon;
            _description.text = _upgrade.Description.WithColors();
        }

        private void Selected()
        {
            _levelUpMenuController.UpgradeSelected(_upgrade);
        }
    }
}