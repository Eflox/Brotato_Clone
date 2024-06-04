/*
 * Script Author: Charles d'Ansembourg
 * Creation Date: 04/06/2024
 * Contact: c.dansembourg@icloud.com
 */

public class Wave
{
    public int Count;
    public int Duration;
    public int EnemyCount;
    public int DamageIncrease;
    public int MaxHPIncrease;
    public int SpeedIncrease;
    public int ItemPricesIncrease;

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