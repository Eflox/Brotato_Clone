/*
 * Script Author: Charles d'Ansembourg
 * Creation Date: 28/05/2024
 * Contact: c.dansembourg@icloud.com
 */

using UnityEngine;

[CreateAssetMenu(fileName = "AlienBaby", menuName = "Game/Item/AlienBaby")]
public class AlienBaby : ItemBase, IItem
{
    [Effect]
    public int MaxHP = 15;

    [Effect]
    public int EnemySpeed = 8;
}