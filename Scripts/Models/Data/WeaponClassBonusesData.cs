/*
 * WeaponClassBonusesData.cs
 * Script Author: Charles d'Ansembourg
 * Creation Date: 29/05/2024
 * Contact: c.dansembourg@icloud.com
 */

using System.Collections.Generic;

namespace Brotato_Clone.Models
{
    public static class WeaponClassBonusesData
    {
        public static int CalculateBonus(int weaponCount, Dictionary<int, int> bonusMap)
        {
            return bonusMap.TryGetValue(weaponCount, out int bonus) ? bonus : 0;
        }

        public static readonly Dictionary<int, int> LegendaryWeaponsBonusMap = new Dictionary<int, int>
        {
            {2, -20}, {3, -40}, {4, -60}, {5, -80}, {6, -100}
        };

        public static readonly Dictionary<int, int> PrimitiveWeaponsBonusMap = new Dictionary<int, int>
        {
            {2, 3}, {3, 6}, {4, 9}, {5, 12}, {6, 15}
        };

        public static readonly Dictionary<int, int> BluntWeaponsBonusMap = new Dictionary<int, int>
        {
            {3, 3}, {4, 3}, {5, 6}, {6, 6}
        };

        public static readonly Dictionary<int, int> HeavyWeaponsBonusMap = new Dictionary<int, int>
        {
            {2, 5}, {3, 10}, {4, 15}, {5, 20}, {6, 25}
        };

        public static readonly Dictionary<int, int> BladeWeaponsBonusMap = new Dictionary<int, int>
        {
            {2, 1}, {3, 2}, {4, 3}, {5, 4}, {6, 5}
        };

        public static readonly Dictionary<int, int> MedicalWeaponsBonusMap = new Dictionary<int, int>
        {
            {2, 1}, {3, 2}, {4, 3}, {5, 4}, {6, 5}
        };

        public static readonly Dictionary<int, int> UnarmedWeaponsBonusMap = new Dictionary<int, int>
        {
            {2, 3}, {3, 6}, {4, 9}, {5, 12}, {6, 15}
        };

        public static readonly Dictionary<int, int> MedievalWeaponsBonusMap = new Dictionary<int, int>
        {
            {3, 3}, {4, 3}, {5, 6}, {6, 6}
        };

        public static readonly Dictionary<int, int> EtherealWeaponsBonusMap = new Dictionary<int, int>
        {
            {2, 6}, {3, 12}, {4, 18}, {5, 24}, {6, 30}
        };

        public static readonly Dictionary<int, int> PreciseWeaponsBonusMap = new Dictionary<int, int>
        {
            {2, 3}, {3, 6}, {4, 9}, {5, 12}, {6, 15}
        };

        public static readonly Dictionary<int, int> ElementalWeaponsBonusMap = new Dictionary<int, int>
        {
            {2, 1}, {3, 2}, {4, 3}, {5, 4}, {6, 5}
        };

        public static readonly Dictionary<int, int> SupportWeaponsBonusMap = new Dictionary<int, int>
        {
            {2, 5}, {3, 10}, {4, 15}, {5, 20}, {6, 25}
        };

        public static readonly Dictionary<int, int> ExplosiveWeaponsBonusMap = new Dictionary<int, int>
        {
            {2, 5}, {3, 10}, {4, 15}, {5, 20}, {6, 25}
        };

        public static readonly Dictionary<int, int> ToolWeaponsBonusMap = new Dictionary<int, int>
        {
            {2, 5}, {3, 10}, {4, 15}, {5, 20}, {6, 25}
        };
    }
}