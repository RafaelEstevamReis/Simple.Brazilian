using System;
using Simple.Brazilian.Validators;
using Xunit;

namespace Simple.Brazilian.UnitTests.ValidatorsTestes.ModValitationTestes
{
    public class Calculate2121
    {
        [Fact]
        public void Calculate2121Mod10IndividualDigits_Exemplo1Manual_Itau()
        {
            string exemploManual = "1108954";
            Assert.Equal(7, ModValidation.Calculate2121Mod10IndividualDigits(exemploManual));
        }
        [Fact]
        public void Calculate2121Mod10IndividualDigitsChar_Exemplo1Manual_Itau()
        {
            string exemploManual = "1108954";
            Assert.Equal('7', ModValidation.Calculate2121Mod10IndividualDigitsChar(exemploManual));
        }
        [Fact]
        public void Calculate2121Mod10IndividualDigits_Exemplo2Manual_Itau()
        {
            string exemploManual = "0057"+ "72192" + "198"+ "98712345";
            Assert.Equal(1, ModValidation.Calculate2121Mod10IndividualDigits(exemploManual));
        }

        [Theory]
        [InlineData("123 456")]
        [InlineData("123-456")]
        [InlineData("1A2B")]
        [InlineData("1234 ")]
        [InlineData(" 1234")]
        public void Calculate2121Mod10IndividualDigits_FormatException(string texto)
        {
            Assert.Throws<FormatException>(() => ModValidation.Calculate2121Mod10IndividualDigits(texto));
        }

        [Theory]
        [InlineData("")]
        [InlineData(null)]
        public void Calculate2121Mod10IndividualDigits_Empty(string texto)
        {
            Assert.Throws<ArgumentException>(() => ModValidation.Calculate2121Mod10IndividualDigits(texto));
        }
    }
}
