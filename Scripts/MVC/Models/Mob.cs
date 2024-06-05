/*
 * Mob.cs
 * Script Author: Charles d'Ansembourg
 * Creation Date: 05/06/2024
 * Contact: c.dansembourg@icloud.com
 */

using UnityEngine;

namespace Brotato_Clone.Models
{
    [System.Serializable]
    public class Mob
    {
        public string Name;
        public string Description;
        public Sprite Sprite;
        public int HP;
        public float AddedHPPerWave;
        public int[] SpeedRange = new int[2];
        public int Damage;
        public float AddedDamagePerWave;
        public int MaterialsDropped;
        public int ConsumableDropRate;
        public int LootCrateDropRate;
        public int WaveAppearance;
    }
}