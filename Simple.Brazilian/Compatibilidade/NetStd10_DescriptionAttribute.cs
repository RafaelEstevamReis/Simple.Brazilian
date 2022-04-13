#if NETSTANDARD1_0
using System;

namespace Simple.Brazilian
{
    internal class DescriptionAttribute : Attribute
    {
        public string Description { get; }
        public DescriptionAttribute(string description)
        {
            Description = description;
        }
    }
}
#endif
