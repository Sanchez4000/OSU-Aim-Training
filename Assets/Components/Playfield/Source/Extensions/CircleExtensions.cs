using Assets.Components.Circle.Source;
using UnityEngine;

namespace Assets.Components.Playfield.Source.Extensions
{
    public static class CircleExtensions
    {
        public static void SetPosition(this HitCircle circle, float x, float y, float z)
        {
            var position = new Vector3(x, y, z);
            circle.transform.localPosition = position;
        }
    }
}
