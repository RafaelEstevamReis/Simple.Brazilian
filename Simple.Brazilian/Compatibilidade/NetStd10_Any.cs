#if NETSTANDARD1_0
using System;

namespace Simple.Brazilian
{
    internal static class NetStd10_Any
    {
        public static bool Any(this string text, Func<char, bool> predicate)
        {
            foreach(char c in text)
            {
                if(!predicate(c)) return false;
            }
            return true;
        }
    }
}
#endif
