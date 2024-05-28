/*
 * Script Author: Charles d'Ansembourg
 * Creation Date: 28/05/2024
 * Contact: c.dansembourg@icloud.com
 */

using UnityEngine;

[CreateAssetMenu(fileName = "AlienBaby", menuName = "Game/Item/AlienBaby")]
public class AlienBaby : ItemBase, IItem, IBuyable
{
    public int BasePrice => 80;
    public int Limit => 0;

    [Effect]
    public readonly int MaxHP = 15;

    [Effect]
    public readonly int EnemySpeed = 8;

}