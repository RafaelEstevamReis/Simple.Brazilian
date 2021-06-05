using Simple.Brazilian.Formatters;
using Xunit;

namespace Simple.Brazilian.UnitTests.FormattersTestes.TextFilterTestes
{
    public class TextFilterWhitespacesTestes
    {
        [Theory]
        [InlineData("", "")]
        [InlineData(" ", " ")]
        [InlineData("a", "")]
        [InlineData("A", "")]
        [InlineData("1", "")]
        [InlineData("$", "")]
        [InlineData("!", "")]
        [InlineData("a \r\n\t1", " \r\n\t")]
        [InlineData("aAbB12$@# ,.", " ")]
        public void TextFilter_Whitespaces_Allow(string teste, string esperado)
        {
            var result = TextFilter.Filter(teste)
                                   .AllowWhitespace()
                                   .Execute();
            Assert.Equal(esperado, result);
        }
        [Theory]
        [InlineData("", "")]
        [InlineData(" ", "")]
        [InlineData("a", "a")]
        [InlineData("A", "A")]
        [InlineData("1", "1")]
        [InlineData("$", "$")]
        [InlineData("!", "!")]
        [InlineData("a \r\n\t1", "a1")]
        [InlineData("aAbB12$@# ,.", "aAbB12$@#,.")]
        public void TextFilter_Whitespaces_Deny(string teste, string esperado)
        {
            var result = TextFilter.Filter(teste)
                                   .AllowAll()
                                   .DenyWhitespace()
                                   .Execute();
            Assert.Equal(esperado, result);
        }
    }
}
