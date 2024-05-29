/*
 * Script Author: Charles d'Ansembourg
 * Creation Date: 28/05/2024
 * Contact: c.dansembourg@icloud.com
 */

using UnityEngine;

public abstract class ItemBase : ScriptableObject
{
    public string Name;
    public string Description;
    public Sprite Icon;
    public Rarity Rarity;
    public Class[] classes;
}