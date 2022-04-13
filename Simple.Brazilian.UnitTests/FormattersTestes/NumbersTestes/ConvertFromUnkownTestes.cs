using Simple.Brazilian.Formatters;
using Xunit;

namespace Simple.Brazilian.UnitTests.FormattersTestes.NumbersTestes
{
    public class ConvertFromUnkownTestes
    {
        [Theory]
        [InlineData("0", 0)]
        [InlineData("1", 1)]
        [InlineData("-2", -2)]
        [InlineData("1.0", 1)]
        [InlineData("2.3", 2.3)]
        [InlineData("2,3", 2.3)]
        public void Numero_ConvertFromUnkown_BaseCases(string input, decimal expected)
        {
            decimal actual = Numbers.ConvertFromUnkown(input);
            Assert.Equal(expected, actual);
        }

        [Theory]
        [InlineData("R$ 1,23", 1.23)]
        [InlineData("R$ 1.234,56", 1234.56)]
        [InlineData("$1,900.00", 1900)]
        public void Numero_ConvertFromUnkown_MoneyCases(string input, decimal expected)
        {
            decimal actual = Numbers.ConvertFromUnkown(input);
            Assert.Equal(expected, actual);
        }

        [Theory]
        [InlineData("R$ 1.23", 1.23)]
        [InlineData("R$ 1,234.56", 1234.56)]
        [InlineData("$1.900,00", 1900)]
        public void Numero_ConvertFromUnkown_Swapped(string input, decimal expected)
        {
            decimal actual = Numbers.ConvertFromUnkown(input);
            Assert.Equal(expected, actual);
        }

        [Theory]
        [InlineData("\r\nR$\t1.23\r\n", 1.23)]
        [InlineData("\r\nR$\t1,23\r\n", 1.23)]
        [InlineData("a R$ 1.23\r\n", 1.23)]
        [InlineData("a R$ 1,23\r\n", 1.23)]
        public void Numero_ConvertFromUnkown_Dirty(string input, decimal expected)
        {
            decimal actual = Numbers.ConvertFromUnkown(input);
            Assert.Equal(expected, actual);
        }

        [Theory]
        [InlineData("$1,900", 1900)]
        public void Numero_ConvertFromUnkown_SpecialCases(string input, decimal expected)
        {
            decimal actual = Numbers.ConvertFromUnkown(input);
            Assert.Equal(expected, actual);
        }
    }
}
