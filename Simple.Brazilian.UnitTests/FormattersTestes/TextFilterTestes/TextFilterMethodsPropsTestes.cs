using Simple.Brazilian.Formatters;
using Xunit;

namespace Simple.Brazilian.UnitTests.FormattersTestes.TextFilterTestes
{
    public class TextFilterMethodsPropsTestes
    {
        [Fact]
        public void TextFilter_Methods_Numbers()
        {
            var filter = TextFilter.Filter("");

            filter.AllowNumbers();
            Assert.True(filter.AllowsNumbers);

            filter.DenyNumbers();
            Assert.False(filter.AllowsNumbers);
        }
        [Fact]
        public void TextFilter_Methods_Upper()
        {
            var filter = TextFilter.Filter("");

            filter.AllowUppercaseLetters();
            Assert.True(filter.AllowsUppercaseLetters);

            filter.DenyUppercaseLetters();
            Assert.False(filter.AllowsUppercaseLetters);
        }
        [Fact]
        public void TextFilter_Methods_Lower()
        {
            var filter = TextFilter.Filter("");

            filter.AllowLowercaseLetters();
            Assert.True(filter.AllowsLowercaseLetters);

            filter.DenyLowercaseLetters();
            Assert.False(filter.AllowsLowercaseLetters);
        }
        [Fact]
        public void TextFilter_Methods_Symbols()
        {
            var filter = TextFilter.Filter("");

            filter.AllowSymbols();
            Assert.True(filter.AllowsSymbols);

            filter.DenySymbols();
            Assert.False(filter.AllowsSymbols);
        }
        [Fact]
        public void TextFilter_Methods_Punctuations()
        {
            var filter = TextFilter.Filter("");

            filter.AllowPunctuation();
            Assert.True(filter.AllowsPunctuation);

            filter.DenyPunctuation();
            Assert.False(filter.AllowsPunctuation);
        }
        [Fact]
        public void TextFilter_Methods_Whitespace()
        {
            var filter = TextFilter.Filter("");

            filter.AllowWhitespace();
            Assert.True(filter.AllowsWhitespace);

            filter.DenyWhitespace();
            Assert.False(filter.AllowsWhitespace);
        }
    }
}
