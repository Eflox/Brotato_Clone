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

        private Transform _player;

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
            _player = player;
            gameObject.name = $"{mobData.Name}_Mob";
            _currentHP = MobData.HP;

            _mobView.SetSpawnSprite(Resources.Load<Sprite>("Symbols/SpawnCross"));

            Invoke("Spawn", 1f);

            _initialized = true;
        }

        private void Spawn()
        {
            gameObject.tag = "Mob";
            _mobView.SetSprite(MobData.Sprite);
            int speed = Random.Range(MobData.SpeedRange[0], MobData.SpeedRange[1]);
            _mobMovementController.Initialize(_player, speed);
        }

        private void Update()
        {
            if (_initialized)
                return;
        }

        public void GetHit(int damage, int knockback, Vector2 direction)
        {
            _currentHP -= damage;
            _mobMovementController.ApplyKnockback(knockback / 7, direction);

            Debug.Log("Got hit");
        }
    }
}