/*
 * Script Author: Charles d'Ansembourg
 * Creation Date: 28/05/2024
 * Contact: c.dansembourg@icloud.com
 */

using UnityEngine;

[CreateAssetMenu(fileName = "Brawler", menuName = "Game/Characters/Brawler")]
public class Brawler : ItemBase, IItem
{
    [Stat]
    public readonly int Dodge = 15;

    [Stat]
    public readonly int Range = -50;

    [Stat]
    public readonly int RangeDmg = -50;

}