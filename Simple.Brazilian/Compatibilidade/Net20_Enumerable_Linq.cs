#if NET20
using System.Collections.Generic;

namespace System.Linq
{
    /// <summary>
    /// Classe para dar compatibilidade à NET20
    /// </summary>
    internal static class Enumerable
    {
        internal static IEnumerable<T> Where<T>(this IEnumerable<T> source, Func<T, bool> filter)
        {
            foreach (var v in source)
            {
                if (filter(v)) yield return v;
            }
        }
        internal static IEnumerable<TResult> Select<TSource, TResult>(this IEnumerable<TSource> source, Func<TSource, TResult> selector)
        {
            foreach (var v in source)
            {
                yield return selector(v);
            }
        }
        internal static TSource FirstOrDefault<TSource>(this IEnumerable<TSource> source)
        {
            foreach (var v in source)
            {
                return v;
            }
            return default;
        }
        internal static bool Any<TSource>(this IEnumerable<TSource> source, Func<TSource, bool> predicate)
        {
            foreach (var v in source)
            {
                if (predicate(v)) return true;
            }
            return false;
        }
        internal static IEnumerable<T> Union<T>(this IEnumerable<T> first, IEnumerable<T> second)
        {
            foreach (var v in first) yield return v;
            foreach (var v in second) yield return v;
        }
        internal static IList<T> ToList<T>(this IEnumerable<T> source)
        {
            return new List<T>(source);
        }
        internal static T[] ToArray<T>(this IEnumerable<T> source)
        {
            return new List<T>(source).ToArray();
        }

        internal static Dictionary<TKey, TSource> ToDictionary<TSource, TKey>(this IEnumerable<TSource> source, Func<TSource, TKey> keySelector) where TKey : notnull
        {
            var dic = new Dictionary<TKey, TSource>();

            foreach(var  v in source)
            {
                var key = keySelector(v);
                dic[key] = v;
            }

            return dic;
        }
    }
}

#endif