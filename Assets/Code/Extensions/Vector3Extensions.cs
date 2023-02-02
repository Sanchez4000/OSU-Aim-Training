using UnityEngine;

namespace Code.Extensions
{
    public static class Vector3Extensions
    {
        public static Vector3 SetX(this Vector3 source, float x)
        {
            return new Vector3(x, source.y, source.z);
        }
        public static Vector3 SetY(this Vector3 source, float y)
        {
            return new Vector3(source.x, y, source.z);
        }
        public static Vector3 SetZ(this Vector3 source, float z)
        {
            return new Vector3(source.x, source.y, z);
        }
    }
}
