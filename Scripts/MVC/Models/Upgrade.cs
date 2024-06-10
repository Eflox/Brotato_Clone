/*
 * Upgrade.cs
 * Script Author: Charles d'Ansembourg
 * Creation Date: 10/06/2024
 * Contact: c.dansembourg@icloud.com
 */

using Brotato_Clone.Interfaces;
using UnityEngine;

namespace Brotato_Clone
{
    public class Upgrade
    {
        public string Name;
        public string Description;
        public Sprite Icon;
        public Rarity Rarity;
        public IAttribute Attribute;
    }
}