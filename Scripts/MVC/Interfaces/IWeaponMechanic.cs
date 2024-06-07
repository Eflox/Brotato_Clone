/*
 * IWeaponMechanic.cs
 * Script Author: Charles d'Ansembourg
 * Creation Date: 06/06/2024
 * Contact: c.dansembourg@icloud.com
 */

using Brotato_Clone.Controllers;

namespace Brotato_Clone.Interfaces
{
    public interface IWeaponMechanic
    {
        void Initialize(WeaponController weaponController);

        void Attack();

        void AttackFinish();
    }
}