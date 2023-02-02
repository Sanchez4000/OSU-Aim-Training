using System;
using UnityEngine;

namespace Components.Objects.HitCircle
{
    [Serializable] public class CircleSize
    {
        private const float BASE_HEIGHT = 768F;
        private const int IMAGE_SIZE = 128;

        private Transform _transform { get; set; }

        public CircleSize(Transform transform)
        {
            _transform = transform;
        }
        public void Set(float size)
        {
            float scaleFactor = Screen.height / BASE_HEIGHT;
            float osuPixels = (54.4f - 4.48f * size) * 2;
            var scale = osuPixels / IMAGE_SIZE * scaleFactor;

            _transform.localScale = new Vector3(scale, scale, 1);
        }
    }
}
