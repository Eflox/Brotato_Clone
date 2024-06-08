/*
 * HitEffectController.cs
 * Script Author: Charles d'Ansembourg
 * Creation Date: 08/06/2024
 * Contact: c.dansembourg@icloud.com
 */

using UnityEngine;

namespace Brotato_Clone.Controllers
{
    public class HitEffectController : MonoBehaviour
    {
        [SerializeField]
        private Transform _bloodSplatPrefab;

        [SerializeField]
        private Transform _hitSparks;

        private void Start()
        {
            _hitSparks.rotation = Quaternion.Euler(0, 0, Random.Range(0f, 360f));

            for (int i = 0; i < Random.Range(5, 8); ++i)
            {
                Instantiate(_bloodSplatPrefab, this.transform.position, Quaternion.identity);
            }

            Destroy(gameObject, 0.2f);
        }
    }
}