/*
 * Script Author: Charles d'Ansembourg
 * Creation Date: #CREATIONDATE#
 * Contact: c.dansembourg@icloud.com
 */

using System;
using UnityEngine;
using Random = UnityEngine.Random;

[CreateAssetMenu(fileName = "Fist", menuName = "Game/Weapon/Fist")]
public class Fist : ItemBase, IItem, IBuyable, IWeapon
{
    [Stat(operation: StatOperation.Add)]
    public readonly int UnarmedWeapons = 1;

    [Stat(operation: StatOperation.Set)]
    public readonly int UnarmedAttackSpeed = 50;

    public readonly int BaseDamage = 8;
    public readonly int MeleeDamagePrecentage = 100;
    public readonly float BaseAttackSpeed = 0.78f;
    public readonly int BaseCritChance = 1;
    public readonly float BaseCritMultiplier = 1.5f;
    public readonly int BaseRange = 150;

    public int BasePrice => 10;
    public int Limit => 0;

    float IWeapon.AttackSpeed { get; set; }

    public int CalculateAttackSpeed(PlayerStats playerStats)
    {
        IWeapon.AttackSpeed = BaseAttackSpeed * (playerStats.UnarmedAttackSpeed / 100 + 1);
    }

    public int CalculateHit(PlayerStats playerStats)
    {

        Debug.Log(AttackSpeed);

        int damage = BaseDamage + playerStats.MeleeDmg[StatType.TotalVisible];
        damage += (int)Math.Ceiling(damage * (playerStats.Damage[StatType.TotalVisible] / 100.0));

        if (Random.Range(0, 100) <= BaseCritChance + playerStats.CritChance[StatType.TotalVisible])
            damage = (int)Math.Ceiling(damage * BaseCritMultiplier);

        return damage;
    }
}