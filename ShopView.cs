/*
 * ShopView.cs
 * Script Author: Charles d'Ansembourg
 * Creation Date: 26/06/2024
 * Contact: c.dansembourg@icloud.com
 */

using Brotato_Clone.Models;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

namespace Brotato_Clone
{
    public class ShopView : MonoBehaviour
    {
        [SerializeField]
        private Transform _shopItemsContainer;

        [SerializeField]
        private GameObject _shopItemPrefab;

        [SerializeField]
        private TMP_Text _materials;

        [SerializeField]
        private TMP_Text _rerollPrice;

        [SerializeField]
        private Button _rerollButton;

        public void Initialize(ShopController shopController)
        {
            _rerollButton.onClick.AddListener(shopController.Reroll);

            EventManager.Subscribe<PlayerStats>(PlayerEvent.PlayerStatsChanged, OnStatsChanged);
        }

        public void LoadShop(Item[] items)
        {
            foreach (Transform child in _shopItemsContainer)
                Destroy(child);

            foreach (Item item in items)
                Instantiate(_shopItemPrefab, _shopItemsContainer).GetComponent<ShopItemView>().Initialize(item);
        }

        private void OnStatsChanged(PlayerStats stats)
        {
            _materials.text = stats.CurrentMaterials.ToString();
        }
    }
}