using System;
using System.Globalization;
using Simple.Brazilian.Validators;
using Xunit;

namespace Simple.Brazilian.UnitTests.ValidatorsTestes.BoletoTestes
{
    public class CalculateDueDateFactorTests
    {
        [Theory]
        [InlineData("07/10/1997", 0)]
        [InlineData("03/07/2000", 1000)]
        [InlineData("01/12/2002", 1881)]
        [InlineData("29/03/2007", 3460)]
        [InlineData("21/02/2025", 9999)]
        public void CalculaFatorVencimento(string strData, int valorDias)
        {
            var data = DateTime.ParseExact(strData, "dd/MM/yyyy", CultureInfo.InvariantCulture);
            Assert.Equal(valorDias, Boleto.CalculateDueDateFactor(data));
        }

        [Theory]
        [InlineData("07/10/1997", "0000")]
        [InlineData("03/07/2000", "1000")]
        [InlineData("01/12/2002", "1881")]
        [InlineData("29/03/2007", "3460")]
        [InlineData("21/02/2025", "9999")]
        public void CalculaFatorVencimento_Text(string strData, string valorDiasTexto)
        {
            var data = DateTime.ParseExact(strData, "dd/MM/yyyy", CultureInfo.InvariantCulture);
            Assert.Equal(valorDiasTexto, Boleto.CalculateDueDateFactor_Text(data));
        }

        [Theory]
        [InlineData("06/10/1997", -1)]
        [InlineData("22/02/2025", 10_000)]
        public void CalculaFatorVencimento_InvalidosNumérico(string strData, int valorDias)
        {
            var data = DateTime.ParseExact(strData, "dd/MM/yyyy", CultureInfo.InvariantCulture);
            Assert.Equal(valorDias, Boleto.CalculateDueDateFactor(data));
        }

        [Theory]
        [InlineData("06/10/1997")]
        [InlineData("22/02/2025")]
        public void CalculaFatorVencimento_InvalidosNuméricoTexto(string strData)
        {
            var data = DateTime.ParseExact(strData, "dd/MM/yyyy", CultureInfo.InvariantCulture);
            Assert.Throws<FormatException>(() => Boleto.CalculateDueDateFactor_Text(data));
        }

    }
}