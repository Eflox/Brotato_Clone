/*
 * Script Author: Charles d'Ansembourg
 * Creation Date: 28/05/2024
 * Contact: c.dansembourg@icloud.com
 */

using System.Collections.Generic;

[System.Serializable]
public class Player
{
    public PlayerStats Stats = new PlayerStats();

    public List<IItem> Items = new List<IItem>();
    public List<IWeapon> Weapons = new List<IWeapon>();
}