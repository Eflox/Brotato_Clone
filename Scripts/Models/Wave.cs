/*
 * Wave.cs
 * Script Author: Charles d'Ansembourg
 * Creation Date: 05/06/2024
 * Contact: c.dansembourg@icloud.com
 */

namespace Brotato_Clone.Models
{
    /// <summary>
    /// Represents a wave in the game.
    /// </summary>
    public class Wave
    {
        /// <summary>
        /// The wave count.
        /// </summary>
        public int Count;

        /// <summary>
        /// The duration of the wave.
        /// </summary>
        public int Duration;

        /// <summary>
        /// The number of enemies in the wave.
        /// </summary>
        public int EnemyCount;

        /// <summary>
        /// The damage increase for the enemies in the wave.
        /// </summary>
        public int DamageIncrease;

        /// <summary>
        /// The maximum HP increase for the enemies in the wave.
        /// </summary>
        public int MaxHPIncrease;

        /// <summary>
        /// The speed increase for the enemies in the wave.
        /// </summary>
        public int SpeedIncrease;

        /// <summary>
        /// The item prices increase during the wave.
        /// </summary>
        public int ItemPricesIncrease;

        ///// <summary>
        ///// Initializes a new instance of the Wave class.
        ///// </summary>
        //public Wave(int count, int duration, int enemyCount, int damageIncrease, int maxHPIncrease, int speedIncrease, int itemPricesIncrease)
        //{
        //    Count = count;
        //    Duration = duration;
        //    EnemyCount = enemyCount;
        //    DamageIncrease = damageIncrease;
        //    MaxHPIncrease = maxHPIncrease;
        //    SpeedIncrease = speedIncrease;
        //    ItemPricesIncrease = itemPricesIncrease;
        //}
    }
}