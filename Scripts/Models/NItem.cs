/*
 * NItem.cs
 * Script Author: Charles d'Ansembourg
 * Creation Date: 05/06/2024
 * Contact: c.dansembourg@icloud.com
 */

using Brotato_Clone.Interfaces;
using UnityEngine;

namespace Brotato_Clone.Models
{
    [System.Serializable]
    public class NItem
    {
        public string Name;
        public string Description;
        public Sprite Icon;
        public Rarity Rarity;
        public Class[] Classes;
        public IAttribute Attribute;
    }
}