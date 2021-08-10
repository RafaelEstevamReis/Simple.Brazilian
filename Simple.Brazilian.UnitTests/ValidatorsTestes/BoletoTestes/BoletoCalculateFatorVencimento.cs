using System;
using Simple.Brazilian.Validators;
using Xunit;

namespace Simple.Brazilian.UnitTests.ValidatorsTestes.BoletoTestes
{
    public class BoletoCalculateFatorVencimento
    {
        [Theory]
        [InlineData("07/10/1997", 0)]
        [InlineData("03/07/2000", 1000)]
        [InlineData("01/12/2002", 1881)]
        [InlineData("29/03/2007", 3460)]
        [InlineData("21/02/2025", 9999)]
        public void CalculaFatorVencimento_Text(string data, int valorDias)
        {
            Assert.Equal(valorDias, Boleto.CalculateDueDateFactor(data));
        }

        [Theory]
        [InlineData("06/10/1997", -1)]
        [InlineData("22/02/2025", 10_000)]
        public void CalculaFatorVencimento_InvalidosNumérico(string data, int valorDias)
        {
            Assert.Equal(valorDias, Boleto.CalculateDueDateFactor(data));
        }

        [Theory]
        [InlineData("43/07/2000")] // dia inválido
        [InlineData("01/13/2002")] // mês inválido (formato US)
        [InlineData("29/03/07")] // ano abreviado
        [InlineData("2020/01/01")] // formato INT
        public void CalculaFatorVencimento_InvalidosParse(string data)
        {
            Assert.Throws<FormatException>(() => Boleto.CalculateDueDateFactor(data));
        }
    }
}