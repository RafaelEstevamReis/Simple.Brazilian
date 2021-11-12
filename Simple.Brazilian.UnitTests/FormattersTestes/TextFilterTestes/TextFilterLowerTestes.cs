using Simple.Brazilian.Formatters;
using Xunit;

namespace Simple.Brazilian.UnitTests.FormattersTestes.TextFilterTestes
{
    public  class TextFilterLowerTestes
    {
        [Theory]
        [InlineData("", "")]
        [InlineData("a", "a")]
        [InlineData("A", "")]
        [InlineData("1", "")]
        [InlineData("!", "")]
        [InlineData("aAbB12!@# ,.", "ab")]
        public void TextFilter_Lower_Allow(string teste, string esperado)
        {
            var result = TextFilter.Filter(teste)
                                   .AllowLowercaseLetters()
                                   .Execute();
            Assert.Equal(esperado, result);
        }
        [Theory]
        [InlineData("", "")]
        [InlineData("a","")]
        [InlineData("A", "A")]
        [InlineData("1", "1")]
        [InlineData("!","!")]
        [InlineData("aAbB12!@# ,.", "AB12!@# ,.")]
        public void TextFilter_Lower_Deny(string teste, string esperado)
        {
            var result = TextFilter.Filter(teste)
                                   .AllowAll()
                                   .DenyLowercaseLetters()
                                   .Execute();
            Assert.Equal(esperado, result);
        }
    }
}
