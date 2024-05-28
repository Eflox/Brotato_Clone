/*
 * Script Author: Charles d'Ansembourg
 * Creation Date: 28/05/2024
 * Contact: c.dansembourg@icloud.com
 */

using UnityEngine;

public abstract class ItemBase : ScriptableObject
{
    public string Description;

    public Sprite Icon;

    public string Name;

    public Rarity Rarity;
}