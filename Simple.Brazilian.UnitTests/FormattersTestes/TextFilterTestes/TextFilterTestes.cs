using Simple.Brazilian.Formatters;
using System;
using Xunit;

namespace Simple.Brazilian.UnitTests.FormattersTestes.TextFilterTestes
{
    public class TextFilterTestes
    {
        [Fact]
        public void TextFilter_Base_Null()
        {
            Assert.Throws<ArgumentNullException>(() => TextFilter.Filter(null));
        }

        [Fact]
        public void TextFilter_Base_Vazio()
        {
            Assert.Equal("", TextFilter.Filter("").Execute());
        }

        [Fact]
        public void TextFilter_Base_Extensions()
        {
            Assert.Equal("", "".Filter().Execute());
            Assert.Equal("", "abc".Filter().Execute());
        }
    }
}
