/*
 * ItemView.cs
 * Script Author: Charles d'Ansembourg
 * Creation Date: 26/06/2024
 * Contact: c.dansembourg@icloud.com
 */

using Brotato_Clone.Models;
using UnityEngine;
using UnityEngine.UI;

namespace Brotato_Clone.Views
{
    public class ItemView : MonoBehaviour
    {
        [SerializeField]
        private Image _icon;

        public void Initialize(Item item)
        {
            _icon.sprite = Resources.Load<Sprite>(item.SpritePath);
        }
    }
}