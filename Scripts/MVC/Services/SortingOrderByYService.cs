/*
 * SortingOrderByY.cs
 * Script Author: Charles d'Ansembourg
 * Creation Date: 06/06/2024
 * Contact: c.dansembourg@icloud.com
 */

using UnityEngine;

namespace Brotato_Clone.Services
{
    [RequireComponent(typeof(SpriteRenderer))]
    public class SortingOrderByYService : MonoBehaviour
    {
        private SpriteRenderer _spriteRenderer;
        private float _lastYPosition;

        [SerializeField]
        private int sortingOrderBase = 5000;

        [SerializeField]
        private int offset = 0;

        private void Awake()
        {
            _spriteRenderer = GetComponent<SpriteRenderer>();
            _lastYPosition = transform.position.y;
            UpdateSortingOrder();
        }

        private void Update()
        {
            if (Mathf.Abs(transform.position.y - _lastYPosition) > Mathf.Epsilon)
            {
                _lastYPosition = transform.position.y;
                UpdateSortingOrder();
            }
        }

        private void UpdateSortingOrder()
        {
            _spriteRenderer.sortingOrder = (int)(sortingOrderBase - transform.position.y * 100) + offset;
        }
    }
}