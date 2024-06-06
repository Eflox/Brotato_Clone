/*
 * GameController.cs
 * Script Author: Charles d'Ansembourg
 * Creation Date: 06/06/2024
 * Contact: c.dansembourg@icloud.com
 */

using UnityEngine;

namespace Brotato_Clone.Controllers
{
    public class GameController : MonoBehaviour
    {
        private void Awake()
        {
            Application.targetFrameRate = 60;

            if (QualitySettings.vSyncCount != 0)
                QualitySettings.vSyncCount = 0;
        }
    }
}