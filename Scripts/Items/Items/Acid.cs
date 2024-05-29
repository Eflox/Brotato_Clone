/*
 * Script Author: Charles d'Ansembourg
 * Creation Date: 28/05/2024
 * Contact: c.dansembourg@icloud.com
 */

using UnityEngine;

[CreateAssetMenu(fileName = "Acid", menuName = "Game/Item/Acid")]
public class Acid : ItemBase, IItem, IBuyable
{
    [Stat]
    public readonly int Dodge = -4;

    [Stat]
    public readonly int MaxHP = 8;

    public int BasePrice => 65;

    public int Limit => 0;
}