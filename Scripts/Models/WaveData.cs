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
                {
                    1, new Wave
                    {
                        Count = 1,
                        Duration = 3 /*20*/,
                        EnemyCount = 15,
                        DamageIncrease = 1,
                        MaxHPIncrease = 5,
                        SpeedIncrease = 1,
                        ItemPricesIncrease = 2
                    }
                },
                {
                    2, new Wave
                    {
                        Count = 2,
                        Duration = 25,
                        EnemyCount = 25,
                        DamageIncrease = 2,
                        MaxHPIncrease = 10,
                        SpeedIncrease = 2,
                        ItemPricesIncrease = 4
                    }
                },
                {
                    3, new Wave
                    {
                        Count = 3,
                        Duration = 30,
                        EnemyCount = 35,
                        DamageIncrease = 3,
                        MaxHPIncrease = 15,
                        SpeedIncrease = 3,
                        ItemPricesIncrease = 6
                    }
                },
                {
                    4, new Wave
                    {
                        Count = 4,
                        Duration = 35,
                        EnemyCount = 45,
                        DamageIncrease = 4,
                        MaxHPIncrease = 20,
                        SpeedIncrease = 4,
                        ItemPricesIncrease = 8
                    }
                },
                {
                    5, new Wave
                    {
                        Count = 5,
                        Duration = 40,
                        EnemyCount = 55,
                        DamageIncrease = 5,
                        MaxHPIncrease = 25,
                        SpeedIncrease = 5,
                        ItemPricesIncrease = 10
                    }
                },
                {
                    6, new Wave
                    {
                        Count = 6,
                        Duration = 45,
                        EnemyCount = 65,
                        DamageIncrease = 6,
                        MaxHPIncrease = 30,
                        SpeedIncrease = 6,
                        ItemPricesIncrease = 12
                    }
                },
                {
                    7, new Wave
                    {
                        Count = 7,
                        Duration = 50,
                        EnemyCount = 75,
                        DamageIncrease = 7,
                        MaxHPIncrease = 35,
                        SpeedIncrease = 7,
                        ItemPricesIncrease = 14
                    }
                },
                {
                    8, new Wave
                    {
                        Count = 8,
                        Duration = 55,
                        EnemyCount = 85,
                        DamageIncrease = 8,
                        MaxHPIncrease = 40,
                        SpeedIncrease = 8,
                        ItemPricesIncrease = 16
                    }
                },
                {
                    9, new Wave
                    {
                        Count = 9,
                        Duration = 60,
                        EnemyCount = 95,
                        DamageIncrease = 9,
                        MaxHPIncrease = 45,
                        SpeedIncrease = 9,
                        ItemPricesIncrease = 18
                    }
                },
                {
                    10, new Wave
                    {
                        Count = 10,
                        Duration = 60,
                        EnemyCount = 105,
                        DamageIncrease = 10,
                        MaxHPIncrease = 50,
                        SpeedIncrease = 10,
                        ItemPricesIncrease = 20
                    }
                },
                {
                    11, new Wave
                    {
                        Count = 11,
                        Duration = 60,
                        EnemyCount = 120,
                        DamageIncrease = 11,
                        MaxHPIncrease = 55,
                        SpeedIncrease = 11,
                        ItemPricesIncrease = 22
                    }
                },
                {
                    12, new Wave
                    {
                        Count = 12,
                        Duration = 60,
                        EnemyCount = 135,
                        DamageIncrease = 12,
                        MaxHPIncrease = 60,
                        SpeedIncrease = 12,
                        ItemPricesIncrease = 24
                    }
                },
                {
                    13, new Wave
                    {
                        Count = 13,
                        Duration = 60,
                        EnemyCount = 150,
                        DamageIncrease = 13,
                        MaxHPIncrease = 65,
                        SpeedIncrease = 13,
                        ItemPricesIncrease = 26
                    }
                },
                {
                    14, new Wave
                    {
                        Count = 14,
                        Duration = 60,
                        EnemyCount = 165,
                        DamageIncrease = 14,
                        MaxHPIncrease = 70,
                        SpeedIncrease = 14,
                        ItemPricesIncrease = 28
                    }
                },
                {
                    15, new Wave
                    {
                        Count = 15,
                        Duration = 60,
                        EnemyCount = 180,
                        DamageIncrease = 15,
                        MaxHPIncrease = 75,
                        SpeedIncrease = 15,
                        ItemPricesIncrease = 30
                    }
                },
                {
                    16, new Wave
                    {
                        Count = 16,
                        Duration = 60,
                        EnemyCount = 195,
                        DamageIncrease = 16,
                        MaxHPIncrease = 80,
                        SpeedIncrease = 16,
                        ItemPricesIncrease = 32
                    }
                },
                {
                    17, new Wave
                    {
                        Count = 17,
                        Duration = 60,
                        EnemyCount = 210,
                        DamageIncrease = 17,
                        MaxHPIncrease = 85,
                        SpeedIncrease = 17,
                        ItemPricesIncrease = 34
                    }
                },
                {
                    18, new Wave
                    {
                        Count = 18,
                        Duration = 60,
                        EnemyCount = 225,
                        DamageIncrease = 18,
                        MaxHPIncrease = 90,
                        SpeedIncrease = 18,
                        ItemPricesIncrease = 36
                    }
                },
                {
                    19, new Wave
                    {
                        Count = 19,
                        Duration = 60,
                        EnemyCount = 240,
                        DamageIncrease = 19,
                        MaxHPIncrease = 95,
                        SpeedIncrease = 19,
                        ItemPricesIncrease = 38
                    }
                },
                {
                    20, new Wave
                    {
                        Count = 20,
                        Duration = 90,
                        EnemyCount = 255,
                        DamageIncrease = 20,
                        MaxHPIncrease = 100,
                        SpeedIncrease = 20,
                        ItemPricesIncrease = 40
                    }
                }
            };
        }
    }
}