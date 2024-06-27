/*
 * ShopItemView.cs
 * Script Author: Charles d'Ansembourg
 * Creation Date: 26/06/2024
 * Contact: c.dansembourg@icloud.com
 */

using Brotato_Clone.Extensions;
using Brotato_Clone.Models;
using System.Linq;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

namespace Brotato_Clone
{
    public class ShopItemView : MonoBehaviour
    {
        [SerializeField]
        private Image _itemPanelBg;

        [SerializeField]
        private Image _itemImage;

        [SerializeField]
        private TMP_Text _itemName;

        [SerializeField]
        private TMP_Text _itemClass;

        [SerializeField]
        private TMP_Text _itemDescription;

        [SerializeField]
        private TMP_Text _itemBuyPrice;

        [SerializeField]
        private Button _buyButton;

        [SerializeField]
        private Button _lockButton;

        private Item _item;

        public void Initialize(Item item)
        {
            _item = item;

            _itemPanelBg.color = RarityColorsData.Colors[item.Rarity];
            _itemImage.sprite = Resources.Load<Sprite>(item.SpritePath);
            _itemName.text = item.Name;
            _itemClass.text = string.Join(", ", item.Classes.Select(c => c.ToString()).ToArray());
            _itemDescription.text = item.Description.WithColors().WithNL();

            _itemBuyPrice.text = item.BasePrice.ToString();
            _buyButton.onClick.AddListener(Selected);
        }

        private void Selected()
        {
            if (PlayerPrefs.GetInt("Materials") < _item.BasePrice)
                return;

            _item.SelectItem();
            EventManager.TriggerEvent(PlayerEvent.PlayerPayed, _item.BasePrice);
            Destroy(this.gameObject);
        }
    }
}