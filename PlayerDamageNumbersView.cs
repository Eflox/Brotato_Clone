/*
 * PlayerDamageNumbersView.cs
 * Script Author: Charles d'Ansembourg
 * Creation Date: 22/07/2024
 * Contact: c.dansembourg@icloud.com
 */

using DamageNumbersPro;
using UnityEngine;

namespace Brotato_Clone.Player.Views
{
    public class PlayerDamageNumbersView : MonoBehaviour
    {
        [SerializeField]
        private DamageNumber _takeDamageNumber;

        [SerializeField]
        private DamageNumber _healDamageNumber;

        [SerializeField]
        private DamageNumber _dealDamageNumber;

        [SerializeField]
        private DamageNumber _dealCritDamageNumber;

        [SerializeField]
        private Transform _playerTransform;

        public void Initialize()
        {
            EventManager.Subscribe<int>(PlayerEvent.PlayerTakeDamage, OnPlayerTakeDamage);
            EventManager.Subscribe<int>(PlayerEvent.PlayerHeal, OnPlayerHeal);
        }

        private void OnPlayerTakeDamage(int damage)
        {
            _takeDamageNumber.Spawn(_playerTransform.position + new Vector3(Random.Range(-0.3f, 0.3f), Random.Range(-0.6f, 0.0f)), -damage);
        }

        private void OnPlayerHeal(int amount)
        {
            _healDamageNumber.Spawn(_playerTransform.position + new Vector3(Random.Range(-0.3f, 0.3f), Random.Range(-0.6f, 0.0f)), amount);
        }
    }
}