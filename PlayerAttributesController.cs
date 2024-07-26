/*
 * PlayerAttributesController.cs
 * Script Author: Charles d'Ansembourg
 * Creation Date: 26/07/2024
 * Contact: c.dansembourg@icloud.com
 */

using Brotato_Clone.Models;
using System.Collections.Generic;
using UnityEngine;

namespace Brotato_Clone.Controllers
{
    public class PlayerAttributesController : MonoBehaviour
    {
        private List<Item> _items = new List<Item>();

        private bool _ingame = false;

        private float _timer1 = 0;
        private float _timer3 = 0;
        private float _timer5 = 0;

        public void WaveStart(List<Item> items)
        {
            _items = items;
            _ingame = true;
        }

        public void WaveEnd()
        {
            _ingame = false;
        }

        private void Update()
        {
            if (!_ingame)
                return;

            _timer1 += Time.deltaTime;
            _timer3 += Time.deltaTime;
            _timer5 += Time.deltaTime;

            if (_timer1 >= 1.0f)
            {
                OnTimer1();
                _timer1 = 0f;
            }

            if (_timer3 >= 3.0f)
            {
                OnTimer3();
                _timer3 = 0f;
            }

            if (_timer5 >= 5.0f)
            {
                OnTimer5();
                _timer5 = 0f;
            }
        }

        private void OnTimer1()
        {
            Debug.Log("Calling timer 1");
            foreach (var item in _items)
            {
                if (ItemsData.Attributes[item.Name] is IOnTimer1 attribute)
                {
                    Debug.Log($"{item.Name} called OnTimer3");
                    attribute.OnTimer1();
                }
            }
        }

        private void OnTimer3()
        {
            foreach (var item in _items)
            {
                if (item is IOnTimer3 attribute)
                {
                    Debug.Log($"{item.Name} called OnTimer3");
                    attribute.OnTimer3();
                }
            }
        }

        private void OnTimer5()
        {
            foreach (var item in _items)
            {
                if (item is IOnTimer5 attribute)
                {
                    Debug.Log($"{item.Name} called OnTimer3");
                    attribute.OnTimer5();
                }
            }
        }
    }
}