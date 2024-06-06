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

        public void Initialize(Mob mobData, Transform player)
        {
            MobData = mobData;

            gameObject.name = $"{mobData.Name}_Mob";
            _currentHP = MobData.HP;
            _mobView.SetSprite(mobData.Sprite);

            int speed = Random.Range(mobData.SpeedRange[0], mobData.SpeedRange[1]);
            _mobMovementController.Initialize(player, speed);

            _initialized = true;
        }

        private void Update()
        {
            if (_initialized)
                return;
        }
    }
}