/*
 * MobController.cs
 * Script Author: Charles d'Ansembourg
 * Creation Date: 06/06/2024
 * Contact: c.dansembourg@icloud.com
 */

using Brotato_Clone.Models;
using Brotato_Clone.Views;
using DamageNumbersPro;
using System.Collections;
using UnityEngine;

namespace Brotato_Clone.Controllers
{
    public class MobController : MonoBehaviour
    {
        public Mob MobData;

        private Transform _player;

        [SerializeField]
        private int _currentHP;

        [SerializeField]
        private MobView _mobView;

        [SerializeField]
        private MobMovementController _mobMovementController;

        [SerializeField]
        private CircleCollider2D _circleCollider2D;

        [SerializeField]
        private GameObject _materialPrefab;

        private DamageNumber _damageNumber;

        private MobsController _mobsController;

        public void Initialize(Mob mobData, Transform player, DamageNumber damageNumber, MobsController mobsController)
        {
            _mobsController = mobsController;
            MobData = mobData;
            _player = player;
            _damageNumber = damageNumber;
            gameObject.name = $"{mobData.Name}_Mob";
            _currentHP = MobData.HP;
            _circleCollider2D.enabled = false;

            _mobView.SetSpawnSprite(MobData.SpawnSprite);

            EventManager.Subscribe(WaveEvent.WaveEnd, OnWaveEnd);

            Invoke("Spawn", 1f);
        }

        private bool _isPlayerInRange = false;

        private void Update()
        {
            float distanceToPlayer = Vector2.Distance(_player.position, transform.position);

            if (distanceToPlayer < 0.2f && !_isPlayerInRange)
            {
                _isPlayerInRange = true;
                StartCoroutine(TriggerDamageEvent());
            }
            else if (distanceToPlayer >= 0.2f && _isPlayerInRange)
            {
                _isPlayerInRange = false;
                StopCoroutine(TriggerDamageEvent());
            }
        }

        private IEnumerator TriggerDamageEvent()
        {
            while (_isPlayerInRange)
            {
                EventManager.TriggerEvent(PlayerEvent.PlayerTakeDamage, 3);
                yield return new WaitForSeconds(0.8f);
            }
        }

        private void OnWaveEnd()
        {
            Die(Vector2.zero, false);
        }

        private void Spawn()
        {
            _circleCollider2D.enabled = true;
            gameObject.tag = "Mob";
            _mobView.SetSprite(MobData.Sprite);
            int speed = Random.Range(MobData.SpeedRange[0], MobData.SpeedRange[1]);
            _mobMovementController.Initialize(_player, speed);
        }

        public void GetHit(int damage, int knockback, Vector2 direction)
        {
            _currentHP -= damage;

            if (_currentHP <= 0)
                Die(direction, true);
            else
                _mobMovementController.ApplyKnockback(knockback / 7, direction);

            _damageNumber.Spawn(transform.position, damage);

            _mobView.GetHit();
        }

        public void Die(Vector2 direction, bool spawnMaterial)
        {
            if (gameObject.tag != "Mob")
            {
                Destroy(gameObject);
                return;
            }

            if (spawnMaterial)
                Instantiate(_materialPrefab, this.transform.position, Quaternion.identity);

            gameObject.tag = "Untagged";
            _circleCollider2D.enabled = false;
            _mobView.Die(direction);
            _mobMovementController.StopMovement();
        }

        public void Dead()
        {
            Destroy(gameObject);
        }
    }
}