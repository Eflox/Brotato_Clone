/*
 * WeaponsController.cs
 * Script Author: Charles d'Ansembourg
 * Creation Date: 06/06/2024
 * Contact: c.dansembourg@icloud.com
 */

using Brotato_Clone.Models;
using System.Collections.Generic;
using UnityEngine;

namespace Brotato_Clone.Controllers
{
    public class WeaponsController : MonoBehaviour
    {
        [SerializeField]
        private PlayerController _playerController;

        private List<Transform> _weaponContainers = new List<Transform>();

        [SerializeField]
        private GameObject _weaponPrefab;

        [SerializeField]
        private List<WeaponController> _weaponControllers = new List<WeaponController>();

        private void Start()
        {
            Weapon[] weaponsTest = new Weapon[]
            {
                WeaponsData.Weapons["Fist"],
                WeaponsData.Weapons["Fist"],
                WeaponsData.Weapons["Fist"],
                WeaponsData.Weapons["Fist"],
            };

            Initialize(weaponsTest);
        }

        public void Initialize(Weapon[] weapons)
        {
            CreateWeaponContainers(weapons);
            SpawnWeapons(weapons);
        }

        public void FlipWeapons()
        {
            foreach (var weapon in _weaponControllers)
            {
                weapon.FlipWeapon();
            }
        }

        private void SpawnWeapons(Weapon[] weapons)
        {
            for (int i = 0; i < weapons.Length; i++)
            {
                var newWeapon = Instantiate(_weaponPrefab, _weaponContainers[i].position, Quaternion.identity, _weaponContainers[i]);
                newWeapon.GetComponent<WeaponController>().Initialize(weapons[i]);
            }
        }

        private void CreateWeaponContainers(Weapon[] weapons)
        {
            float baseRadius = 0.6f;
            float radiusIncrement = 0.1f;
            float radius = baseRadius + (weapons.Length - 1) * radiusIncrement;

            for (int i = 0; i < weapons.Length; i++)
            {
                float angle = i * Mathf.PI * 2 / weapons.Length;
                Vector2 position = new Vector2(Mathf.Cos(angle), Mathf.Sin(angle)) * radius;

                Transform newPosition = new GameObject($"{weapons[i].Name}_Container").transform;
                newPosition.position = position;
                newPosition.SetParent(_playerController.PlayerObject.transform);

                _weaponContainers.Add(newPosition);
            }
        }
    }
}