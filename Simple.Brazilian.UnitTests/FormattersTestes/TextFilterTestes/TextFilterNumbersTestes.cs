using Simple.Brazilian.Formatters;
using System;
using Xunit;

namespace Simple.Brazilian.UnitTests.FormattersTestes.TextFilterTestes
{
    public class TextFilterNumbersTestes
    {
        [Theory]
        [InlineData("", "")]
        [InlineData("a", "")]
        [InlineData("A", "")]
        [InlineData("1", "1")]
        [InlineData("!", "")]
        [InlineData("aAbB12!@# ,.", "12")]
        public void TextFilter_Numbers_Allow(string teste, string esperado)
        {
            var result = TextFilter.Filter(teste)
                                   .AllowNumbers()
                                   .Execute();
            Assert.Equal(esperado, result);
        }
        [Theory]
        [InlineData("", "")]
        [InlineData("a", "a")]
        [InlineData("A", "A")]
        [InlineData("1", "")]
        [InlineData("!", "!")]
        [InlineData("aAbB12!@# ,.", "aAbB!@# ,.")]
        public void TextFilter_Numbers_Deny(string teste, string esperado)
        {
            var result = TextFilter.Filter(teste)
                                   .AllowAll()
                                   .DenyNumbers()
                                   .Execute();
            Assert.Equal(esperado, result);
        }
    }
}
