/*
 * WeaponController.cs
 * Script Author: Charles d'Ansembourg
 * Creation Date: 06/06/2024
 * Contact: c.dansembourg@icloud.com
 */

using Brotato_Clone.Interfaces;
using Brotato_Clone.Views;
using UnityEngine;

namespace Brotato_Clone.Controllers
{
    public class WeaponController : MonoBehaviour
    {
        [SerializeField]
        private WeaponView _weaponView;

        private IWeaponMechanic _weaponMechanic;

        private void Update()
        {
            if (Input.GetKeyDown(KeyCode.Space))
            {
                _weaponMechanic.Attack();
            }
        }

        public void Initialize(Weapon weapon)
        {
            _weaponView.SetSprite(weapon.Sprite);
            _weaponMechanic = gameObject.AddComponent(weapon.WeaponMechanic) as IWeaponMechanic;
        }

        public void FlipWeapon()
        {
            _weaponView.Flip();
        }
    }
}