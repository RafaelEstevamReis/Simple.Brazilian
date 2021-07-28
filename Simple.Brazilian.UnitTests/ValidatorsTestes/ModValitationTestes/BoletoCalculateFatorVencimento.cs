﻿using Simple.Brazilian.Validators;
using Xunit;

namespace Simple.Brazilian.UnitTests.ValidatorsTestes.ModValitationTestes
{
    public class BoletoCalculateFatorVencimento
    {
        [Theory]
        [InlineData("03/07/2000", 1000)]
        [InlineData("01/12/2002", 1881)]
        [InlineData("29/03/2007", 3460)]
        [InlineData("21/02/2025", 9999)]

        public void CalculaFatorVencimento_Raw(string data, int inum)
        {
            Assert.Equal(inum, Boleto.FatorVencimento(data));
        }
    }
}