using Simple.Brazilian.Documents;
using System;
using Xunit;

namespace Simple.Brazilian.UnitTests.DocumentosTestes.CNPJTestes
{
    public class GetCnpjMatrizTestes
    {

        [Theory]
        [InlineData("12345678000276", "12345678000195")]
        [InlineData("12345678000195", "12345678000195")]
        [InlineData("12345678000199", "12345678000199")] // Matriz presume correto e preserva
        [InlineData("12345678000282", "12345678000195")]
        public void CNPJ_GetCnpjMatriz_ConveteSucesso(string source, string expected)
        {
            var matriz = CNPJ.GetCnpjMatriz(source);
            Assert.Equal(expected, matriz);
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
