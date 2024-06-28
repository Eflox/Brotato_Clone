/*
 * UpgradeView.cs
 * Script Author: Charles d'Ansembourg
 * Creation Date: 10/06/2024
 * Contact: c.dansembourg@icloud.com
 */

using Brotato_Clone.Extensions;
using Brotato_Clone.Models;
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

        private Upgrade _upgrade;

        public void Initialize(Upgrade upgrade)
        {
            _upgrade = upgrade;
            _chooseButton.onClick.AddListener(Selected);

            _name.text = _upgrade.Name;
            _icon.sprite = Resources.Load<Sprite>(upgrade.SpritePath);
            _description.text = _upgrade.Description.WithColors();
        }

        public void Remove()
        {
            Destroy(this.gameObject);
        }

        private void Selected()
        {
            _upgrade.SelectUpgrade();
        }
    }
}