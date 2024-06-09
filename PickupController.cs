/*
 * PickupController.cs
 * Script Author: Charles d'Ansembourg
 * Creation Date: 09/06/2024
 * Contact: c.dansembourg@icloud.com
 */

using Brotato_Clone.Models;
using UnityEngine;

namespace Brotato_Clone.Controllers
{
    public class PickupController : MonoBehaviour
    {
        private int _range;

        public void Initialize(PlayerStats stats)
        {
            _range = stats.PickupRange;
        }
    }
}