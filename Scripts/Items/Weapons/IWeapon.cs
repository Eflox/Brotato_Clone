﻿/*
 * Script Author: Charles d'Ansembourg
 * Creation Date: 29/05/2024
 * Contact: c.dansembourg@icloud.com
 */

using Brotato_Clone.Models;

public interface IWeapon
{
    void InitWeaponStats(PlayerStats playerStats);

    int CalculateHit(PlayerStats playerStats);

    float AttackSpeed { get; set; }
}