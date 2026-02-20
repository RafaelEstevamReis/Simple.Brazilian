using Simple.Brazilian.Documents;
using System;
using Xunit;

namespace Simple.Brazilian.UnitTests.DocumentosTestes.CNPJTestes
{
    public class GetCnpjMatrizTestes
    {

        [Fact]
        public void CNPJ_GetCnpjMatriz_ConveteSucesso()
        {
            var filial = "12345678000276";

            var matriz = CNPJ.GetCnpjMatriz(filial);

            Assert.Equal("12345678000195", matriz);
        }


        [Fact]
        public void CNPJ_GetCnpjMatriz_ConveteSucessoMascara()
        {
            var filial = CNPJ.Mask("12345678000276");

            var matriz = CNPJ.GetCnpjMatriz(filial);

            Assert.Equal("12345678000195", matriz);
        }


        [Theory]
        [InlineData("123456780002760")] // 1 a mais
        [InlineData("1234567800027")] // 1 a menos
        public void CNPJ_GetCnpjMatriz_LenIncorreto(string filial)
        {
            Assert.Throws<InvalidOperationException>(() => CNPJ.GetCnpjMatriz(filial));
        }

    }

}
