/*
 * EventType.cs
 * Script Author: Charles d'Ansembourg
 * Creation Date: 11/06/2024
 * Contact: c.dansembourg@icloud.com

 */

public enum PlayerEvent
{
    PlayerDead,
    PlayerMoveChange,
    PlayerDie,
    PlayerFlipPlayer,
    PlayerDealDamage,
    PlayerTakeDamage,
    PlayerSelectItem,
    PlayerStatsChanged,
    PlayerPickupDrop,
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
    GamePaused,
}