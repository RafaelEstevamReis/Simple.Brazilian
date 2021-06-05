using Simple.Brazilian.Formatters;
using Xunit;

namespace Simple.Brazilian.UnitTests.FormattersTestes.TextFilterTestes
{
    public class TextFilterKeyboardKeysTestes
    {
        [Fact]
        public void TextFilter_KeyboardKeys_TopLine()
        {
            string line = "'\"!@#$%¨&*()_+-=§¹²³£¢¬";

            string numbers = "¹²³";
            string upper = "";
            string lower = "";
            string symbols = "$¨+=£¢¬";
            string ponctuation = "'\"!@#%&*()_-§";
            string whitespaces = "";

            Assert.Equal(numbers, TextFilter.Filter(line).AllowNumbers().Execute());
            Assert.Equal(upper, TextFilter.Filter(line).AllowUppercaseLetters().Execute());
            Assert.Equal(lower, TextFilter.Filter(line).AllowLowercaseLetters().Execute());
            Assert.Equal(symbols, TextFilter.Filter(line).AllowSymbols().Execute());
            Assert.Equal(ponctuation, TextFilter.Filter(line).AllowPunctuation().Execute());
            Assert.Equal(whitespaces, TextFilter.Filter(line).AllowWhitespace().Execute());
        }
        [Fact]
        public void TextFilter_KeyboardKeys_Side()
        {
            string line = "`´[{ªçÇ~^]}º,.<>;:/?\\|/";

            string numbers = "ªº";
            string upper = "ªÇº";
            string lower = "ªçº";
            string symbols = "`´ª~^º<>|";
            string ponctuation = "[{ª]}º,.;:/?\\/";
            string whitespaces = "ªº";

            Assert.Equal(numbers, TextFilter.Filter(line).AllowNumbers().Execute());
            Assert.Equal(upper, TextFilter.Filter(line).AllowUppercaseLetters().Execute());
            Assert.Equal(lower, TextFilter.Filter(line).AllowLowercaseLetters().Execute());
            Assert.Equal(symbols, TextFilter.Filter(line).AllowSymbols().Execute());
            Assert.Equal(ponctuation, TextFilter.Filter(line).AllowPunctuation().Execute());
            Assert.Equal(whitespaces, TextFilter.Filter(line).AllowWhitespace().Execute());
        }
        [Fact]
        public void TextFilter_KeyboardKeys_Outros()
        {
            string line = "¡¢£¤¥¦¨©«¬®¯°±´µ¶·¸»¼½¾¿ÀÁÂÃÄÅÆÇÈÉÊËÌÍÎÏÐÑÒÓÔÕÖ×ØÙÚÜÝÞßàáâãäåæçèéêëìíîïðñòóôö÷øùúûüýþÿ";

            string numbers = "¼½¾";
            string upper = "ÀÁÂÃÄÅÆÇÈÉÊËÌÍÎÏÐÑÒÓÔÕÖØÙÚÜÝÞ";
            string lower = "µßàáâãäåæçèéêëìíîïðñòóôöøùúûüýþÿ";
            string symbols = "¢£¤¥¦¨©¬®¯°±´¸×÷";
            string ponctuation = "¡«¶·»¿";
            string whitespaces = "";

            Assert.Equal(numbers, TextFilter.Filter(line).AllowNumbers().Execute());
            Assert.Equal(upper, TextFilter.Filter(line).AllowUppercaseLetters().Execute());
            Assert.Equal(lower, TextFilter.Filter(line).AllowLowercaseLetters().Execute());
            Assert.Equal(symbols, TextFilter.Filter(line).AllowSymbols().Execute());
            Assert.Equal(ponctuation, TextFilter.Filter(line).AllowPunctuation().Execute());
            Assert.Equal(whitespaces, TextFilter.Filter(line).AllowWhitespace().Execute());
        }
    }
}
