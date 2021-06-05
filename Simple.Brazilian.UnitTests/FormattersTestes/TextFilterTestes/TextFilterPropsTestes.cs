using Simple.Brazilian.Formatters;
using Xunit;

namespace Simple.Brazilian.UnitTests.FormattersTestes.TextFilterTestes
{
    public class TextFilterPropsTestes
    {
        [Fact]
        public void TextFilter_Props_DenyAll_AllowProps_Padrao()
        {
            var filter = TextFilter.Filter("");

            Assert.False(filter.AllowsNumbers);
            Assert.False(filter.AllowsUppercaseLetters);
            Assert.False(filter.AllowsLowercaseLetters);
            Assert.False(filter.AllowsSymbols);
            Assert.False(filter.AllowsWhitespace);
        }

        [Fact]
        public void TextFilter_Props_AllowAll_AllowProps()
        {
            var filter = TextFilter.Filter("")
                                   .AllowAll();

            Assert.True(filter.AllowsNumbers);
            Assert.True(filter.AllowsUppercaseLetters);
            Assert.True(filter.AllowsLowercaseLetters);
            Assert.True(filter.AllowsSymbols);
            Assert.True(filter.AllowsWhitespace);
        }

        [Fact]
        public void TextFilter_Props_DenyAll_AllowProps()
        {
            var filter = TextFilter.Filter("")
            // Como Deny é o Padrão, precisa fazer a inversão antes
                                   .AllowAll()
                                   .DenyAll();

            Assert.False(filter.AllowsNumbers);
            Assert.False(filter.AllowsUppercaseLetters);
            Assert.False(filter.AllowsLowercaseLetters);
            Assert.False(filter.AllowsSymbols);
            Assert.False(filter.AllowsWhitespace);
        }
    }
}
