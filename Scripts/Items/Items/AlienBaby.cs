/*
 * Script Author: Charles d'Ansembourg
 * Creation Date: 28/05/2024
 * Contact: c.dansembourg@icloud.com
 */

using UnityEngine;

[CreateAssetMenu(fileName = "AlienBaby", menuName = "Game/Item/AlienBaby")]
public class AlienBaby : ItemBase, IItem, IBuyable
{
    [Stat]
    public readonly int EnemySpeed = 8;

    [Stat]
    public readonly int MaxHP = 15;

    public int BasePrice => 80;

    public int Limit => 0;
}