﻿/*
 * Script Author: Charles d'Ansembourg
 * Creation Date: 29/05/2024
 * Contact: c.dansembourg@icloud.com
 */

public interface IWeapon
{
    int CalculateHit(PlayerStats playerStats);

    float AttackSpeed { get; set; }
}