/*
 * IWeaponMechanic.cs
 * Script Author: Charles d'Ansembourg
 * Creation Date: 06/06/2024
 * Contact: c.dansembourg@icloud.com
 */

using Brotato_Clone.Controllers;
using Brotato_Clone.Models;

namespace Brotato_Clone.Interfaces
{
    public interface IWeaponMechanic
    {
        void Initialize(WeaponController weaponController, Weapon weapon);

        void Attack();

        void AttackFinish();
    }
}