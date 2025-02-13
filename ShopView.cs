/*
 * ShopView.cs
 * Script Author: Charles d'Ansembourg
 * Creation Date: 26/06/2024
 * Contact: c.dansembourg@icloud.com
 */

using Brotato_Clone.Controllers;
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

        [SerializeField]
        private Button _startWaveButton;

        [SerializeField]
        private TMP_Text _startWaveButtonText;

        public void Initialize(ShopController shopController)
        {
            _rerollButton.onClick.AddListener(shopController.Reroll);
            _startWaveButton.onClick.AddListener(shopController.StartWave);

            EventManager.Subscribe<PlayerStats>(PlayerEvent.PlayerStatsChanged, OnStatsChanged);
        }

        public void LoadShop(Item[] items)
        {
            _startWaveButtonText.text = $"Go (Wave {PlayerPrefs.GetInt("Wave") + 1})";

            foreach (Transform child in _shopItemsContainer)
                Destroy(child.gameObject);

            foreach (Item item in items)
                Instantiate(_shopItemPrefab, _shopItemsContainer).GetComponent<ShopItemView>().Initialize(item);
        }

        public void LoadReroll(int price, bool canPay)
        {
            _rerollPrice.text = $"REROLL - {price.ToString()}";

            if (!canPay)
            {
                _rerollButton.GetComponent<ButtonController>().ToggleEffect(true);
                _rerollPrice.color = Color.red;
            }
            else
            {
                _rerollButton.GetComponent<ButtonController>().ToggleEffect(false);
            }
        }

        private void OnStatsChanged(PlayerStats stats)
        {
            _materials.text = stats.CurrentMaterials.ToString();
        }
    }
}