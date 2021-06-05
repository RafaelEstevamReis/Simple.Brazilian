using Simple.Brazilian.Formatters;
using Xunit;

namespace Simple.Brazilian.UnitTests.FormattersTestes.TextFilterTestes
{
    public class TextFilterSymbolsTestes
    {
        [Theory]
        [InlineData("", "")]
        [InlineData("a", "")]
        [InlineData("A", "")]
        [InlineData("1", "")]
        [InlineData("$", "$")]
        [InlineData("!", "")] // Pontauação
        [InlineData("aAbB12$!@# ,.", "$")]
        public void TextFilter_Symbols_Allow(string teste, string esperado)
        {
            var result = TextFilter.Filter(teste)
                                   .AllowSymbols()
                                   .Execute();
            Assert.Equal(esperado, result);
        }
        [Theory]
        [InlineData("", "")]
        [InlineData("a", "a")]
        [InlineData("A", "A")]
        [InlineData("1", "1")]
        [InlineData("$", "")]
        [InlineData("!", "!")] // Pontauação
        [InlineData("aAbB12$!$@# ,.", "aAbB12!@# ,.")]
        public void TextFilter_Symbols_Deny(string teste, string esperado)
        {
            var result = TextFilter.Filter(teste)
                                   .AllowAll()
                                   .DenySymbols()
                                   .Execute();
            Assert.Equal(esperado, result);
        }
    }
}
