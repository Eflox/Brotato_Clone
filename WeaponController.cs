/*
 * WeaponController.cs
 * Script Author: Charles d'Ansembourg
 * Creation Date: 06/06/2024
 * Contact: c.dansembourg@icloud.com
 */

using Brotato_Clone.Views;
using UnityEngine;

namespace Brotato_Clone.Controllers
{
    public class WeaponController : MonoBehaviour
    {
        [SerializeField]
        private WeaponView _weaponView;

        public void Initialize(Weapon weapon)
        {
            _weaponView.SetSprite(weapon.Sprite);
        }

        public void FlipWeapon()
        {
            _weaponView.Flip();
        }
    }
}