using Simple.Brazilian.Formatters;
using System;
using Xunit;

namespace Simple.Brazilian.UnitTests.FormatedoresTestes.NumerosTestes
{
    public class NumeroIntTestes
    {
        [Theory]
        [InlineData(0, "0")]
        [InlineData(1, "1")]
        [InlineData(2, "2")]
        [InlineData(10, "10")]
        [InlineData(100, "100")]
        [InlineData(250, "250")]
        public void Numero_ToInt_Base(int expected, string test)
        {
            Assert.Equal(expected, Numero.ToInt(test));
        }

        [Theory]
        [InlineData(0, "0", 0)]
        [InlineData(0, "0", null)]
        [InlineData(1, "1", 0)]
        [InlineData(1, "1", null)]
        [InlineData(250, "250", 0)]
        [InlineData(250, "250", null)]
        public void Numero_ToInt_BaseOnError(int expected, string test, int? onError)
        {
            Assert.Equal(expected, Numero.ToInt(test, onError));
        }

        [Theory]
        [InlineData(0, "a", 0)]
        [InlineData(1, "b", 1)]
        [InlineData(-2, "a250", -2)]
        [InlineData(-1, "250a", -1)]
        public void Numero_ToInt_ErrorHandled(int expected, string test, int? onError)
        {
            Assert.Equal(expected, Numero.ToInt(test, onError));
        }

        [Theory]
        [InlineData("a")]
        [InlineData("b")]
        [InlineData("a250")]
        [InlineData("250a")]
        public void Numero_ToInt_ErrorThrown(string test)
        {
            Assert.Throws<FormatException>(() => Numero.ToInt(test, null));
        }


        [Theory]
        [InlineData(0, "0  ")]
        [InlineData(1, "   1")]
        [InlineData(2, "\r\n2")]
        [InlineData(10, "10\r\n")]
        [InlineData(100, "\t100")]
        [InlineData(250, "250\t")]
        [InlineData(250, "\t250\t")]
        public void Numero_ToInt_Whitespace(int expected, string test)
        {
            Assert.Equal(expected, Numero.ToInt(test));
        }

        [Theory]
        [InlineData("0", 0)]
        [InlineData("1", 1)]
        [InlineData("2", 2)]
        [InlineData("10", 10)]
        [InlineData("100", 100)]
        [InlineData("250", 250)]
        public void Numero_ToText_Base(string expected, int test)
        {
            Assert.Equal(expected, Numero.ToText(test));
        }
    }
}
