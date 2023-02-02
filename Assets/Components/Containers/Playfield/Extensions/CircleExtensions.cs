using Components.Objects.HitCircle;
using UnityEngine;

namespace Components.Containers.Playfield.Extensions
{
    public static class CircleExtensions
    {
        public static void SetPosition(this Circle circle, float x, float y, float z)
        {
            var position = new Vector3(x, y, z);
            circle.transform.localPosition = position;
        }
    }
}
