#if NET20
namespace System.Collections.Generic;
internal class HashSet<T>
{
    Dictionary<T, bool> dicData;
    public HashSet(IEnumerable<T> init)
    {
        dicData = new Dictionary<T, bool>();
        foreach(var i in init) dicData.Add(i, false);
    }

    public int Count => dicData.Count;

    internal bool Contains(T c)
        => dicData.ContainsKey(c);
}
#endif