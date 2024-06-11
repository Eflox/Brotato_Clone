/*
 * PlayerVisualsController.cs
 * Script Author: Charles d'Ansembourg
 * Creation Date: 29/05/2024
 * Contact: c.dansembourg@icloud.com
 */

using Brotato_Clone.Views;
using UnityEngine;

namespace Brotato_Clone.Controllers
{
    public class PlayerVisualsController : MonoBehaviour
    {
        [SerializeField]
        private PlayerView _playerView;

        [SerializeField]
        private PlayerController _playerController;

        public void Initialize()
        {
            foreach (var item in _playerController.Items)
                foreach (var itemClass in item.Classes)
                    if (itemClass == Class.Character)
                        _playerView.SetCharacter(item.Icon);
        }
    }
}