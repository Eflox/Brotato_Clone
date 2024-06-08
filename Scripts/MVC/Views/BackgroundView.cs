/*
 * BackgroundView.cs
 * Script Author: Charles d'Ansembourg
 * Creation Date: 08/06/2024
 * Contact: c.dansembourg@icloud.com
 */

using DG.Tweening;
using UnityEngine;

namespace Brotato_Clone.Views
{
    public class BackgroundView : MonoBehaviour
    {
        [SerializeField]
        private Transform _characterObject;

        private float AnimationWidthChange = 0.05f;
        private float AnimationHeightChange = 0.05f;

        private void Start()
        {
            SetupBounceAnimation();
        }

        public void SetupBounceAnimation()
        {
            _characterObject.localScale = new Vector3(1 - AnimationWidthChange, 1 + AnimationHeightChange, 1f);
            _characterObject.DOScale(new Vector3(1 + AnimationWidthChange, 1 - AnimationHeightChange, 1f), 0.9f).SetLoops(-1, LoopType.Yoyo);
        }
    }
}