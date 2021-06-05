using Simple.Brazilian.Formatters;
using Xunit;

namespace Simple.Brazilian.UnitTests.FormattersTestes.TextFilterTestes
{
    public class TextFilterUpperTestes
    {
        [Theory]
        [InlineData("", "")]
        [InlineData("a", "")]
        [InlineData("A", "A")]
        [InlineData("1", "")]
        [InlineData("$", "")]
        [InlineData("aAbB12$@# ,.", "AB")]
        public void TextFilter_Upper_Allow(string teste, string esperado)
        {
            var result = TextFilter.Filter(teste)
                                   .AllowUppercaseLetters()
                                   .Execute();
            Assert.Equal(esperado, result);
        }
        [Theory]
        [InlineData("", "")]
        [InlineData("a", "a")]
        [InlineData("A", "")]
        [InlineData("1", "1")]
        [InlineData("$", "$")]
        [InlineData("aAbB12$@# ,.", "ab12$@# ,.")]
        public void TextFilter_Upper_Deny(string teste, string esperado)
        {
            var result = TextFilter.Filter(teste)
                                   .AllowAll()
                                   .DenyUppercaseLetters()
                                   .Execute();
            Assert.Equal(esperado, result);
        }
    }
}
