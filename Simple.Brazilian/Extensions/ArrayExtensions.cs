using System;

namespace Simple.Brazilian
{
    internal static class ArrayExtensions
    {
        public static int IndexOf(this string[] array, string search, StringComparison stringComparison)
        {
            if (array is null) throw new ArgumentNullException(nameof(array));

            for (int i = 0; i < array.Length; i++)
            {
                if (array[i].Equals(search, stringComparison)) return i;
            }

            return -1;
        }
        public static int IndexOf<T>(this T[] array, T search)
        {
            if (array is null) throw new ArgumentNullException(nameof(array));

            for (int i = 0; i < array.Length; i++)
            {
                if (array[i].Equals(search)) return i;
            }

            return -1;
        }
    }
}
