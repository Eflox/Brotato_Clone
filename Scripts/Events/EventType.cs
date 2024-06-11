/*
 * EventType.cs
 * Script Author: Charles d'Ansembourg
 * Creation Date: 11/06/2024
 * Contact: c.dansembourg@icloud.com

 */

public enum PlayerEvent
{
    PlayerDead,
    PlayerMoving,
    PlayerIdle,
    PlayerDie,
    FlipPlayer,
    PlayerDealDamage,
    PlayerTakeDamage,
    PlayerAddItem,
    PlayerItemsChanged,
    PlayerStatsChanged
}

public enum WaveEvent
{
    WaveStart,
    WaveMiddle,
    WaveEnd
}

public enum GameEvent
{
    GameStart,
    GameEnd,
}