/*
 * ShopController.cs
 * Script Author: Charles d'Ansembourg
 * Creation Date: 25/06/2024
 * Contact: c.dansembourg@icloud.com
 */

using Brotato_Clone.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;
using UnityEngine.SceneManagement;

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
            if (PlayerPrefs.GetInt("Materials") < _rerollPrice)
                return;

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

        public void StartWave()
        {
            int nextWave = PlayerPrefs.GetInt("Wave") + 1;
            PlayerPrefs.SetInt("Wave", nextWave);

            SceneManager.LoadScene("GameScene");
        }

        private void LoadItems()
        {
            //Item[] shopItems = new Item[]
            //{
            //    ItemsData.Items["AlienBaby"],
            //    ItemsData.Items["AlienBaby"],
            //    ItemsData.Items["AlienBaby"],
            //    ItemsData.Items["AlienBaby"]
            //};

            _shopView.LoadShop(GetRandomItems(4));
        }

        private Item[] GetRandomItems(int count)
        {
            var items = ItemsData.Items.Values.ToList();
            var weightedItems = new List<Item>();

            foreach (var item in items)
            {
                int weight = GetWeight(item.Rarity);
                for (int i = 0; i < weight; i++)
                {
                    weightedItems.Add(item);
                }
            }

            return weightedItems.OrderBy(x => UnityEngine.Random.value).Take(count).ToArray();
        }

        private int GetWeight(Rarity tier)
        {
            switch (tier)
            {
                case Rarity.Tier1: return 1;
                case Rarity.Tier2: return 2;
                case Rarity.Tier3: return 3;
                case Rarity.Tier4: return 4;
                default: throw new ArgumentOutOfRangeException();
            }
        }
    }
}