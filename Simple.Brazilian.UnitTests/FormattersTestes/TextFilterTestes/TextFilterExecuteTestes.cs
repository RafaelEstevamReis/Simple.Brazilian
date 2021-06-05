using Simple.Brazilian.Formatters;
using Xunit;

namespace Simple.Brazilian.UnitTests.FormattersTestes.TextFilterTestes
{
    public class TextFilterExecuteTestes
    {
        [Theory]
        [InlineData("")]
        [InlineData("a")]
        [InlineData("A")]
        [InlineData("1")]
        [InlineData("!")]
        [InlineData("aAbB12!@# ,.")]
        public void TextFilter_Execute_PadraoDenyAll(string teste)
        {
            var result = TextFilter.Filter(teste)
                                   .Execute();
            Assert.Equal("", result);
        }
        [Theory]
        [InlineData("")]
        [InlineData("a")]
        [InlineData("A")]
        [InlineData("1")]
        [InlineData("!")]
        [InlineData("aAbB12!@# ,.")]
        public void TextFilter_Execute_DenyAll_Result(string teste)
        {
            var result = TextFilter.Filter(teste)
                                   .DenyAll()
                                   .Execute();
            Assert.Equal("", result);
        }
        [Theory]
        [InlineData("")]
        [InlineData("a")]
        [InlineData("A")]
        [InlineData("1")]
        [InlineData("!")]
        [InlineData("aAbB12!@# ,.")]
        public void TextFilter_Execute_AllowAll_Result(string teste)
        {
            var result = TextFilter.Filter(teste)
                                   .AllowAll()
                                   .Execute();
            Assert.Equal(teste, result);
        }

    }
}
