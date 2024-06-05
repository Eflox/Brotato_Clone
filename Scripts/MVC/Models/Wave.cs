/*
 * Script Author: Charles d'Ansembourg
 * Creation Date: 04/06/2024
 * Contact: c.dansembourg@icloud.com
 */


namespace Brotato.Models
{
    /// <summary>
    /// Represents a wave in the game.
    /// </summary>
    public class Wave
    {
        /// <summary>
        /// The wave count.
        /// </summary>
        public int Count { get; }

        /// <summary>
        /// The duration of the wave.
        /// </summary>
        public int Duration { get; }

        /// <summary>
        /// The number of enemies in the wave.
        /// </summary>
        public int EnemyCount { get; }

        /// <summary>
        /// The damage increase for the enemies in the wave.
        /// </summary>
        public int DamageIncrease { get; }

        /// <summary>
        /// The maximum HP increase for the enemies in the wave.
        /// </summary>
        public int MaxHPIncrease { get; }

        /// <summary>
        /// The speed increase for the enemies in the wave.
        /// </summary>
        public int SpeedIncrease { get; }

        /// <summary>
        /// The item prices increase during the wave.
        /// </summary>
        public int ItemPricesIncrease { get; }

        /// <summary>
        /// Initializes a new instance of the Wave class.
        /// </summary>
        public Wave(int count, int duration, int enemyCount, int damageIncrease, int maxHPIncrease, int speedIncrease, int itemPricesIncrease)
        {
            Count = count;
            Duration = duration;
            EnemyCount = enemyCount;
            DamageIncrease = damageIncrease;
            MaxHPIncrease = maxHPIncrease;
            SpeedIncrease = speedIncrease;
            ItemPricesIncrease = itemPricesIncrease;
        }
    }
}