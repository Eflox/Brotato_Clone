/*
 * MobController.cs
 * Script Author: Charles d'Ansembourg
 * Creation Date: 06/06/2024
 * Contact: c.dansembourg@icloud.com
 */

using Brotato_Clone.Models;
using Brotato_Clone.Views;
using UnityEngine;

namespace Brotato_Clone.Controllers
{
    public class MobController : MonoBehaviour
    {
        public Mob MobData;

        [SerializeField]
        private int _currentHP;

        private bool _initialized = false;

        [SerializeField]
        private MobView _mobView;

        [SerializeField]
        private MobMovementController _mobMovementController;

        private void Update()
        {
            if (_initialized)
                return;
        }

        private void Initialize(Mob mobData, Transform player)
        {
            MobData = mobData;

            _currentHP = MobData.HP;
            _mobView.SetSprite(mobData.Sprite);
            _mobMovementController.Initialize(player);

            _initialized = true;
        }
    }
}