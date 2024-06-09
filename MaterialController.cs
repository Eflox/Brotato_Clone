/*
 * MaterialController.cs
 * Script Author: Charles d'Ansembourg
 * Creation Date: 09/06/2024
 * Contact: c.dansembourg@icloud.com
 */

using Brotato_Clone.Views;
using DG.Tweening;
using UnityEngine;

namespace Brotato_Clone.Controllers
{
    public class MaterialController : MonoBehaviour
    {
        [SerializeField]
        private MaterialView _materialView;

        [SerializeField]
        private CircleCollider2D _circleCollider;

        private int _value;

        private void Start()
        {
            _value = 1;
            _materialView.SetSprite();

            Invoke(nameof(EnableMaterial), 0.3f);
        }

        private void EnableMaterial()
        {
            _circleCollider.enabled = true;
        }

        public void PickUp(PlayerController playerController)
        {
            transform.DOMove(playerController.PlayerObject.transform.position, 0.3f)
                     .OnComplete(() => ReachedPlayer(playerController));
        }

        private void ReachedPlayer(PlayerController playerController)
        {
            playerController.AddMaterial(_value);
            Destroy(this.gameObject);
        }
    }
}