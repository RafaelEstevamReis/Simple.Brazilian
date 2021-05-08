#if NETSTANDARD1_0
using System;

namespace Simple.Brazilian
{
    public class DescriptionAttribute : Attribute
    {
        public string Description { get; }
        public DescriptionAttribute(string description)
        {
            Description = description;
        }
    }
}
#endif
