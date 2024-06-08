/*
 * MenuController.cs
 * Script Author: Charles d'Ansembourg
 * Creation Date: 28/05/2024
 * Contact: c.dansembourg@icloud.com
 */

using Brotato_Clone.Views;
using UnityEngine;
using UnityEngine.SceneManagement;

namespace Brotato_Clone.Controllers
{
    public class MenuController : MonoBehaviour
    {
        [SerializeField]
        private MenuView _menuView;

        private void Start()
        {
            _menuView.Initialize();
        }

        public void CharacterLoadScene()
        {
            SceneManager.LoadScene("CharacterSelectionScene");
        }
    }
}