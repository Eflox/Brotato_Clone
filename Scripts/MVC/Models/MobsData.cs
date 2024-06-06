/*
 * MobsData.cs
 * Script Author: Charles d'Ansembourg
 * Creation Date: 05/06/2024
 * Contact: c.dansembourg@icloud.com
 */

using System.Collections.Generic;
using UnityEngine;

namespace Brotato_Clone.Models
{
    public static class MobsData
    {
        public static readonly IReadOnlyDictionary<string, Mob> Mobs;

        static MobsData()
        {
            Mobs = new Dictionary<string, Mob>
            {
                {
                    "BabyAlien", new Mob
                    {
                        Name = "BabyAlien",
                        Description = "Chases the character, deals damage on touch.",
                        Sprite = Resources.Load<Sprite>("Mobs/Common/Baby_Alien"),
                        HP = 3,
                        AddedHPPerWave = 2.0f,
                        SpeedRange = new int[] { 200, 300 },
                        Damage = 1,
                        AddedDamagePerWave = 0.6f,
                        MaterialsDropped = 1,
                        ConsumableDropRate = 1,
                        LootCrateDropRate = 1,
                        WaveAppearance = 1,
                    }
                },
            };
        }
    }
}