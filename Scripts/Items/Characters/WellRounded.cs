/*
 * Script Author: Charles d'Ansembourg
 * Creation Date: 28/05/2024
 * Contact: c.dansembourg@icloud.com
 */

using UnityEngine;

[CreateAssetMenu(fileName = "Well Rounded", menuName = "Game/Characters/Well Rounded")]
public class WellRounded : ItemBase, IItem
{
    [Effect]
    public readonly int Harvesting = 8;

    [Effect]
    public readonly int MaxHP = 5; [Effect] public readonly int Speed = 5;
}