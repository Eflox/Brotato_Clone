/*
 * MenuController.cs
 * Script Author: Charles d'Ansembourg
 * Creation Date: 28/05/2024
 * Contact: c.dansembourg@icloud.com
 */

using UnityEngine;
using UnityEngine.SceneManagement;

namespace Brotato_Clone.Controllers
{
    public class MenuController : MonoBehaviour
    {
        private void Awake()
        {
            Application.targetFrameRate = 60;

            if (QualitySettings.vSyncCount != 0)
                QualitySettings.vSyncCount = 0;
        }

        public void LoadScene(string scene)
        {
            SceneManager.LoadScene(scene);
        }
    }
}