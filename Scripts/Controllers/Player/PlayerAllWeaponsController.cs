/*
 * PlayerAllWeaponsController.cs
 * Script Author: Charles d'Ansembourg
 * Creation Date: 06/06/2024
 * Contact: c.dansembourg@icloud.com
 */

using Brotato_Clone.Models;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;

namespace Brotato_Clone.Controllers
{
    public class PlayerAllWeaponsController : MonoBehaviour
    {
        private Transform _playerTransform;

        [SerializeField]
        private GameObject _weaponPrefab;

        [SerializeField]
        private List<WeaponController> _weaponControllers = new List<WeaponController>();

        private List<Transform> _weaponContainers = new List<Transform>();

        public void LoadWeapons(List<Weapon> weapons, Transform playerTransform)
        {
            _playerTransform = playerTransform;

            Weapon[] weaponsTest = new Weapon[]
            {
                WeaponsData.Weapons["Fist"],
                WeaponsData.Weapons["Knife"],
            };

            CreateWeaponContainers(weaponsTest.ToList());
            SpawnWeapons(weaponsTest.ToList());
        }

        public void FlipWeapons(bool right)
        {
            foreach (var weaponController in _weaponControllers)
                weaponController.Flip(right);
        }

        private void SpawnWeapons(List<Weapon> weapons)
        {
            for (int i = 0; i < weapons.Count; i++)
            {
                var newWeaponObject = Instantiate(_weaponPrefab, _weaponContainers[i].position, Quaternion.identity, _weaponContainers[i]);
                var weaponController = newWeaponObject.GetComponent<WeaponController>();
                weaponController.Initialize(weapons[i], this);
                _weaponControllers.Add(weaponController);
            }
        }

        private void CreateWeaponContainers(List<Weapon> weapons)
        {
            float baseRadius = 0.7f;
            //float radiusIncrement = 0f;
            //float radius = baseRadius + (weapons.Length - 1) * radiusIncrement;

            for (int i = 0; i < weapons.Count; i++)
            {
                float angle = i * Mathf.PI * 2 / weapons.Count;

                var yOffset = weapons.Count <= 2 ? 0.5f : 0;
                Vector2 position = new Vector2(Mathf.Cos(angle), (Mathf.Sin(angle)) - yOffset) * baseRadius;

                Transform newPosition = new GameObject($"{weapons[i].Name}_Container").transform;
                newPosition.position = position;
                newPosition.SetParent(_playerTransform.transform);

                _weaponContainers.Add(newPosition);
            }
        }

        //public void CheckDirection() => _playerMovementController.CheckDirection(true);

        private void OnDestroy()
        {
            foreach (var weapon in _weaponControllers)
                Destroy(weapon);
        }
    }
}