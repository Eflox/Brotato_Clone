/*
 * ItemsData.cs
 * Script Author: Charles d'Ansembourg
 * Creation Date: 05/06/2024
 * Contact: c.dansembourg@icloud.com
 */

using Brotato_Clone.Interfaces;
using System.Collections.Generic;

namespace Brotato_Clone.Models
{
    public static class ItemsData
    {
        public static readonly IReadOnlyDictionary<string, Item> Items;
        public static readonly IReadOnlyDictionary<string, IAttribute> Attributes;

        private static readonly string _assetSource = "Brotato";
        private static readonly string _path = "Sprites/Items";

        static ItemsData()
        {
            Attributes = new Dictionary<string, IAttribute>
            {
                { "WellRounded", new WellRoundedAttribute() },
                { "Brawler", new BrawlerAttributeData() },

                { "Heart", new HeartAttribute() },
                { "Lungs", new LungsAttribute() },
                { "Teeth", new TeethAttribute() },

                { "AlienBaby", new AlienBabyAttribute() }
            };

            string fullPath = $"{_assetSource}/{_path}/";

            Items = new Dictionary<string, Item>
            {
                {
                "AlienBaby", new Item
                    {
                        Name = "AlienBaby",
                        Description = "[g]+5[c] Max Hp[nl][r]+8%[c] Enemy Speed",
                        SpritePath = $"{fullPath}Alien_Baby",
                        Rarity = Rarity.Common,
                        Classes = new Class[] { Class.Item },
                        BasePrice = 80,
                        Limit = 0
                    }
                },
            };
        }
    }
}