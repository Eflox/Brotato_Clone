/*
 * ItemsData.cs
 * Script Author: Charles d'Ansembourg
 * Creation Date: 05/06/2024
 * Contact: c.dansembourg@icloud.com
 */

using System.Collections.Generic;
using System.Linq;
using UnityEngine;

namespace Brotato_Clone.Models
{
    public static class ItemsData
    {
        public static readonly IReadOnlyDictionary<string, NItem> Items;

        static ItemsData()
        {
            Items = new Dictionary<string, NItem>
            {
                {
                    "WellRounded", new NItem
                    {
                        Name = "WellRounded",
                        Description = "[g]+5[c] Max Hp[nl][g]+5%[c] Speed[nl][g]+8[c] Harvesting",
                        Icon = Resources.Load<Sprite>("Characters/Well_Rounded"),
                        Rarity = Rarity.Common,
                        Classes = new Class[] { Class.Character },
                        Attribute = new WellRoundedAttributeData()
                    }
                },
                {
                    "Brawler", new NItem
                    {
                        Name = "Brawler",
                        Description = "[g]+50%[c] Attack Speed with [g]Unarmed[c] weapons [nl]You start with [g]1 Fist[c] [nl][g]+15%[c] Dodge [nl][r]-50[c] Range [nl][r]-50[c] Ranged Damage",
                        Icon = Resources.Load<Sprite>("Characters/Brawler"),
                        Rarity = Rarity.Common,
                        Classes = new Class[] { Class.Character },
                        Attribute = new BrawlerAttributeData()
                    }
                },
            };
        }

        public static NItem[] GetItemsByClass(Class itemClass)
        {
            return Items.Values.Where(item => item.Classes.Contains(itemClass)).ToArray();
        }
    }
}