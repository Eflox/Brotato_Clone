/*
 * Script Author: Charles d'Ansembourg
 * Creation Date: 28/05/2024
 * Contact: c.dansembourg@icloud.com
 */

using UnityEngine;

[CreateAssetMenu(fileName = "Adreneline", menuName = "Game/Item/Adreneline")]
public class Adreneline : ItemBase, IItem, IOnDodged
{
    [Effect]
    public int Dodge = 5;

    public void OnDodged()
    {
        throw new System.NotImplementedException();
    }
}