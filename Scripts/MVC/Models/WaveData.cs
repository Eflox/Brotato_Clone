/*
 * Script Author: Charles d'Ansembourg
 * Creation Date: 05/06/2024
 * Contact: c.dansembourg@icloud.com
 */

using System.Collections.Generic;

namespace Brotato_Clone.Models
{
    /// <summary>
    /// Holds predefined wave data for the game.
    /// </summary>
    public static class WaveData
    {
        /// <summary>
        /// A dictionary containing wave information indexed by wave number.
        /// </summary>
        public static readonly IReadOnlyDictionary<int, Wave> Waves;

        static WaveData()
        {
            Waves = new Dictionary<int, Wave>
            {
                { 1, new Wave(count: 1, duration: 20, enemyCount: 15, damageIncrease: 1, maxHPIncrease: 5, speedIncrease: 1, itemPricesIncrease: 2) },
                { 2, new Wave(count: 2, duration: 25, enemyCount: 25, damageIncrease: 2, maxHPIncrease: 10, speedIncrease: 2, itemPricesIncrease: 4) },
                { 3, new Wave(count: 3, duration: 30, enemyCount: 35, damageIncrease: 3, maxHPIncrease: 15, speedIncrease: 3, itemPricesIncrease: 6) },
                { 4, new Wave(count: 4, duration: 35, enemyCount: 45, damageIncrease: 4, maxHPIncrease: 20, speedIncrease: 4, itemPricesIncrease: 8) },
                { 5, new Wave(count: 5, duration: 40, enemyCount: 55, damageIncrease: 5, maxHPIncrease: 25, speedIncrease: 5, itemPricesIncrease: 10) },
                { 6, new Wave(count: 6, duration: 45, enemyCount: 65, damageIncrease: 6, maxHPIncrease: 30, speedIncrease: 6, itemPricesIncrease: 12) },
                { 7, new Wave(count: 7, duration: 50, enemyCount: 75, damageIncrease: 7, maxHPIncrease: 35, speedIncrease: 7, itemPricesIncrease: 14) },
                { 8, new Wave(count: 8, duration: 55, enemyCount: 85, damageIncrease: 8, maxHPIncrease: 40, speedIncrease: 8, itemPricesIncrease: 16) },
                { 9, new Wave(count: 9, duration: 60, enemyCount: 95, damageIncrease: 9, maxHPIncrease: 45, speedIncrease: 9, itemPricesIncrease: 18) },
                { 10, new Wave(count : 10, duration: 60, enemyCount: 105, damageIncrease: 10, maxHPIncrease: 50, speedIncrease: 10, itemPricesIncrease: 20) },
                { 11, new Wave(count : 11, duration: 60, enemyCount: 120, damageIncrease: 11, maxHPIncrease: 55, speedIncrease: 11, itemPricesIncrease: 22) },
                { 12, new Wave(count : 12, duration: 60, enemyCount: 135, damageIncrease: 12, maxHPIncrease: 60, speedIncrease: 12, itemPricesIncrease: 24) },
                { 13, new Wave(count : 13, duration: 60, enemyCount: 150, damageIncrease: 13, maxHPIncrease: 65, speedIncrease: 13, itemPricesIncrease: 26) },
                { 14, new Wave(count : 14, duration: 60, enemyCount: 165, damageIncrease: 14, maxHPIncrease: 70, speedIncrease: 14, itemPricesIncrease: 28) },
                { 15, new Wave(count : 15, duration: 60, enemyCount: 180, damageIncrease: 15, maxHPIncrease: 75, speedIncrease: 15, itemPricesIncrease: 30) },
                { 16, new Wave(count : 16, duration: 60, enemyCount: 195, damageIncrease: 16, maxHPIncrease: 80, speedIncrease: 16, itemPricesIncrease: 32) },
                { 17, new Wave(count : 17, duration: 60, enemyCount: 210, damageIncrease: 17, maxHPIncrease: 85, speedIncrease: 17, itemPricesIncrease: 34) },
                { 18, new Wave(count : 18, duration: 60, enemyCount: 225, damageIncrease: 18, maxHPIncrease: 90, speedIncrease: 18, itemPricesIncrease: 36) },
                { 19, new Wave(count : 19, duration: 60, enemyCount: 240, damageIncrease: 19, maxHPIncrease: 95, speedIncrease: 19, itemPricesIncrease: 38) },
                { 20, new Wave(count : 20, duration: 90, enemyCount: 255, damageIncrease: 20, maxHPIncrease: 100, speedIncrease: 20, itemPricesIncrease: 40) }
            };
        }
    }
}