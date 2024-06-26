/*
 * ShopController.cs
 * Script Author: Charles d'Ansembourg
 * Creation Date: 25/06/2024
 * Contact: c.dansembourg@icloud.com
 */

using Brotato_Clone.Models;
using UnityEngine;

namespace Brotato_Clone
{
    public class ShopController : MonoBehaviour
    {
        private ShopView _shopView;

        public void Initialize()
        {
            _shopView = GetComponent<ShopView>();

            _shopView.Initialize(this);

            EventManager.Subscribe(GameEvent.EnterShop, OnEnterShop);
        }

        public void Reroll()
        {
            LoadItems();
        }

        public void OnEnterShop()
        {
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