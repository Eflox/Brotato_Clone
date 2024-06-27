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
        private float _luck;

        public void Initialize()
        {
            _shopView = GetComponent<ShopView>();

            _shopView.Initialize(this);

            EventManager.Subscribe(GameEvent.EnterShop, OnEnterShop);
            EventManager.Subscribe<PlayerStats>(PlayerEvent.PlayerStatsChanged, OnPlayerStatsChanged);
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
            int wave = PlayerPrefs.GetInt("Wave");
            float baseChance, chancePerWave, maxChance;
            int minWave;

            switch (tier)
            {
                case Rarity.Tier1:
                    baseChance = 1f;
                    chancePerWave = 0f;
                    maxChance = 1f;
                    minWave = 1;
                    break;

                case Rarity.Tier2:
                    baseChance = 0.06f; // Changed base chance to be non-zero for initial waves
                    chancePerWave = 0.06f;
                    maxChance = 0.6f;
                    minWave = 2;
                    break;

                case Rarity.Tier3:
                    baseChance = 0.02f; // Changed base chance to be non-zero for initial waves
                    chancePerWave = 0.02f;
                    maxChance = 0.25f;
                    minWave = 4;
                    break;

                case Rarity.Tier4:
                    baseChance = 0.0023f; // Changed base chance to be non-zero for initial waves
                    chancePerWave = 0.0023f;
                    maxChance = 0.08f;
                    minWave = 8;
                    break;

                default:
                    throw new ArgumentOutOfRangeException();
            }

            float chance = ((chancePerWave * (wave - minWave + 1)) + baseChance) * (1 + _luck);
            chance = Mathf.Clamp(chance, 0f, maxChance);

            int weight = Mathf.RoundToInt(chance * 100);

            return weight;
        }

        private void OnPlayerStatsChanged(PlayerStats playerStats)
        {
            _luck = playerStats.Luck[StatType.TotalVisible];
        }
    }
}