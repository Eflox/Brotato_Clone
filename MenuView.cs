/*
 * MenuView.cs
 * Script Author: Charles d'Ansembourg
 * Creation Date: 07/06/2024
 * Contact: c.dansembourg@icloud.com
 */

using Brotato_Clone.Controllers;
using UnityEngine;
using UnityEngine.UI;

namespace Brotato_Clone.Views
{
    public class MenuView : MonoBehaviour
    {
        [SerializeField]
        private MenuController _menuController;

        [SerializeField]
        private Button _startButton;

        public void Initialize()
        {
            _startButton.onClick.AddListener(_menuController.CharacterLoadScene);
        }
    }
}