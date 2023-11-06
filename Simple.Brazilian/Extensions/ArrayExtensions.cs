namespace Simple.Brazilian;

using System;

/// <summary>
/// Extensão interna para Arrays
/// </summary>
public static class ArrayExtensions
{
    /// <summary>
    /// Localiza índice do Array
    /// </summary>
    public static int IndexOf(this string[] array, string search, StringComparison stringComparison)
    {
        if (array is null) throw new ArgumentNullException(nameof(array));

        for (int i = 0; i < array.Length; i++)
        {
            if (array[i].Equals(search, stringComparison)) return i;
        }

        return -1;
    }
    /// <summary>
    /// Localiza índice do Array
    /// </summary>
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
