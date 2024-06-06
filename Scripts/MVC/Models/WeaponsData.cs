/*
 * WeaponsData.cs
 * Script Author: Charles d'Ansembourg
 * Creation Date: 06/06/2024
 * Contact: c.dansembourg@icloud.com
 */

using System.Collections.Generic;
using UnityEngine;

namespace Brotato_Clone.Models
{
    public static class WeaponsData
    {
        public static readonly IReadOnlyDictionary<string, NItem> Weapons;

        static WeaponsData()
        {
            Weapons = new Dictionary<string, NItem>
            {
                {
                    "Fist", new Weapon
                    {
                        Name = "Fist",
                        Description = "",
                        Icon = Resources.Load<Sprite>("Weapons/Fist"),
                        Rarity = Rarity.Common,
                        Classes = new Class[] { Class.Unarmed },
                        Attribute = null,
                    }
                }
            };
        }
    }
}