/*
 * ShopController.cs
 * Script Author: Charles d'Ansembourg
 * Creation Date: 25/06/2024
 * Contact: c.dansembourg@icloud.com
 */

using Brotato_Clone.Models;
using System;
using UnityEngine;

namespace Brotato_Clone
{
    public class ShopController : MonoBehaviour
    {
        private ShopView _shopView;
        private int _rerollPrice;
        private int _rerollIncrease;

        public void Initialize()
        {
            _shopView = GetComponent<ShopView>();

            _shopView.Initialize(this);

            EventManager.Subscribe(GameEvent.EnterShop, OnEnterShop);
        }

        public void Reroll()
        {
            LoadItems();
            EventManager.TriggerEvent(PlayerEvent.PlayerPayed, _rerollPrice);

            _rerollPrice += _rerollIncrease;
            _shopView.LoadReroll(_rerollPrice, _rerollPrice < PlayerPrefs.GetInt("Materials"));
        }

        public void OnEnterShop()
        {
            int wave = PlayerPrefs.GetInt("Wave");
            _rerollIncrease = Math.Max((int)Math.Floor(0.5 * wave), 1);
            _rerollPrice = wave + _rerollIncrease;
            _shopView.LoadReroll(_rerollPrice, true);

            LoadItems();
        }

        private void LoadItems()
        {
            Item[] shopItems = new Item[]
            {
                ItemsData.Items["AlienBaby"],
                ItemsData.Items["AlienBaby"],
                ItemsData.Items["AlienBaby"],
                ItemsData.Items["AlienBaby"]
            };

            _shopView.LoadShop(shopItems);
        }
    }
}