/*
 * WeaponAttackStylesData.cs
 * Script Author: Charles d'Ansembourg
 * Creation Date: 14/06/2024
 * Contact: c.dansembourg@icloud.com
 */

using System;
using System.Collections.Generic;

namespace Brotato_Clone.Models
{
    public static class WeaponAttackStylesData
    {
        public static readonly IReadOnlyDictionary<AttackType, Type> StyleControllers;

        static WeaponAttackStylesData()
        {
            StyleControllers = new Dictionary<AttackType, Type>
            {
                { AttackType.Thrust, typeof(ThrustAttackController) },
            };
        }
    }
}