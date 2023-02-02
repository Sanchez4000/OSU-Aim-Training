using System.Collections.Generic;

namespace Code.Extensions
{
    public static class ListExtensions
    {
        public static T First<T>(this List<T> list)
        {
            return list[0];
        }
        public static T FirstOrDefault<T>(this List<T> list)
        {
            return list.Count > 0 ? list[0] : default;
        }
        public static T Last<T>(this List<T> list)
        {
            var index = list.Count - 1;
            return list[index];
        }
        public static T LastOrDefault<T>(this List<T> list)
        {
            var index = list.Count - 1;
            return index >= 0 ? list[index] : default;
        }
    }
}