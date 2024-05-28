/*
 * Script Author: Charles d'Ansembourg
 * Creation Date: 28/05/2024
 * Contact: c.dansembourg@icloud.com
 */

using UnityEngine;

[CreateAssetMenu(fileName = "Acid", menuName = "Game/Item/Acid")]
public class Acid : ItemBase, IItem
{
    [Effect]
    public int MaxHP = 8;

    [Effect]
    public int Dodge = -4;
}