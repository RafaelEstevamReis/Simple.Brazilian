#if NETSTANDARD1_0
using System.Globalization;

namespace Simple.Brazilian
{
    public static class NetStd10_ResourceGetObject
    {
        public static object GetObject(this System.Resources.ResourceManager manager, string name, CultureInfo info) { return null; }
    }
}
#endif
