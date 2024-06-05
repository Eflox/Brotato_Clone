/*
 * Script Author: Charles d'Ansembourg
 * Creation Date: 28/05/2024
 * Contact: c.dansembourg@icloud.com
 */

using Brotato_Clone.Models;
using UnityEngine;

[CreateAssetMenu(fileName = "Lucky", menuName = "Game/Characters/Lucky")]
public class Lucky : ItemBase, IItem, IOnMaterialPickup
{
    [Stat(operation: StatOperation.Add)]
    public readonly int Luck = 100;

    [Stat(isMultiplier: true)]
    public readonly int LuckMultiplier = 25;

    [Stat(operation: StatOperation.Add)]
    public readonly int AttackSpeed = -60;

    [Stat(operation: StatOperation.Add)]
    public readonly int XPGain = -50;

    public void OnMaterialPickup(PlayerStats stats)
    {
        if (Random.Range(0, 100) <= 75)
        {
            int dmg = stats.Luck[StatType.Base].MultiplyAndRoundUp(0.15f);

            //Deal dmg to random enemy
        }
    }
}