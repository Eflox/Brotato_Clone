/*
 * PlayerAllWeaponsController.cs
 * Script Author: Charles d'Ansembourg
 * Creation Date: 06/06/2024
 * Contact: c.dansembourg@icloud.com
 */

using Brotato_Clone.Models;
using System.Collections.Generic;
using UnityEngine;

namespace Brotato_Clone.Controllers
{
    /// <summary>
    /// Controls all weapons of the player, including loading, creating containers, and spawning weapons.
    /// </summary>
    public class PlayerAllWeaponsController : MonoBehaviour
    {
        #region Fields

        [SerializeField]
        private GameObject _weaponPrefab;

        private Transform _playerTransform;
        private List<Transform> _weaponContainers = new List<Transform>();

        #endregion Fields

        #region Public Methods

        /// <summary>
        /// Loads the player's weapons and creates containers for them.
        /// </summary>
        public void LoadWeapons(List<Weapon> weapons, Transform playerTransform)
        {
            _playerTransform = playerTransform;

            CreateWeaponContainers(weapons);
            SpawnWeapons(weapons);
        }

        #endregion Public Methods

        #region Private Methods

        private void SpawnWeapons(List<Weapon> weapons)
        {
            for (int i = 0; i < weapons.Count; i++)
            {
                var newWeaponObject = Instantiate(_weaponPrefab, _weaponContainers[i].position, Quaternion.identity, _weaponContainers[i]);
                var weaponController = newWeaponObject.GetComponent<WeaponController>();
                weaponController.Initialize();
                weaponController.LoadWeapon(weapons[i]);
            }
        }

        private void CreateWeaponContainers(List<Weapon> weapons)
        {
            float baseRadius = 0.7f;

            for (int i = 0; i < weapons.Count; i++)
            {
                float angle = i * Mathf.PI * 2 / weapons.Count;

                var yOffset = weapons.Count <= 2 ? 0.5f : 0;
                Vector2 position = new Vector2(Mathf.Cos(angle), (Mathf.Sin(angle)) - yOffset) * baseRadius;

                Transform newPosition = new GameObject($"{weapons[i].Name}_Container").transform;
                newPosition.position = position;
                newPosition.SetParent(_playerTransform);

                _weaponContainers.Add(newPosition);
            }
        }

        #endregion Private Methods
    }
}