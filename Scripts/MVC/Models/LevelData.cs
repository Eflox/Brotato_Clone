/*
 * LevelData.cs
 * Script Author: Charles d'Ansembourg
 * Creation Date: 05/06/2024
 * Contact: c.dansembourg@icloud.com
 */

using System.Collections.Generic;
using UnityEngine;

namespace Brotato_Clone.Models
{
    public class LevelData : MonoBehaviour
    {
        public static readonly IReadOnlyDictionary<int, int> LevelsXP;

        static LevelData()
        {
            LevelsXP = new Dictionary<int, int>
            {
                { 0, 16 },
                { 1, 25 },
                { 2, 36 },
                { 3, 49 },
                { 4, 64 },
                { 5, 81 },
                { 6, 100 },
                { 7, 121 },
                { 8, 144 },
                { 9, 169 },
                { 10, 196 },
                { 11, 225 },
                { 12, 256 },
                { 13, 289 },
                { 14, 324 },
                { 15, 361 },
                { 16, 400 },
                { 17, 441 },
                { 18, 484 },
                { 19, 529 },
                { 20, 576 },
                { 21, 625 },
                { 22, 676 },
                { 23, 729 },
                { 24, 784 },
            };
        }
    }
}