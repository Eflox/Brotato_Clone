/*
 * NItem.cs
 * Script Author: Charles d'Ansembourg
 * Creation Date: 05/06/2024
 * Contact: c.dansembourg@icloud.com
 */

using Brotato_Clone.Interfaces;

namespace Brotato_Clone.Models
{
    [System.Serializable]
    public class Item
    {
        public string Name;
        public string Description;
        public string SpritePath;
        public Rarity Rarity;
        public Class[] Classes;
        public IAttribute Attribute;

        public void SelectItem() => EventManager.TriggerEvent(PlayerEvent.PlayerSelectItem, this);
    }
}