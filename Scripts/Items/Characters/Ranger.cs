/*
 * Script Author: Charles d'Ansembourg
 * Creation Date: 28/05/2024
 * Contact: c.dansembourg@icloud.com
 */

using UnityEngine;

[CreateAssetMenu(fileName = "Ranger", menuName = "Game/Characters/Ranger")]
public class Ranger : ItemBase, IItem
{
    [Stat(operation: StatOperation.Add)]
    public readonly int Range = 100;

    [Stat(isMultiplier: true)]
    public readonly int RangedDmgMultiplier = 50;

    [Stat(isMultiplier: true)]
    public readonly int MaxHPMultiplier = -25;

    [Item]
    public ScriptableObject[] Item;
}