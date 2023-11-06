using Simple.Brazilian.Formatters;
using System;
using System.Collections.Generic;
using Xunit;

namespace Simple.Brazilian.UnitTests.FormattersTestes.TextTestes
{
    public class Filtrar
    {
        [Theory]
        [InlineData("123", null)]
        public void Texto_Filtrar_ValidaNulos(string valor, string permitidos)
        {
            Assert.Throws<NullReferenceException>(() => Text.Filter(valor, permitidos));
        }

        [Theory]
        [InlineData("321", "", "")]
        [InlineData("321", "1", "1")]
        [InlineData("321", "12", "21")]
        [InlineData("", "12", "")]
        [InlineData(null, "12", null)]
        public void Texto_Filtrar(string valor, string permitidos, string retorno)
        {
            // Garante que todas as sobrecargas estão testando os mesmos dados

            // Base test
            Assert.Equal(retorno, Text.Filter(valor, permitidos));
            // Char test
            Assert.Equal(retorno, Text.Filter(valor, permitidos.ToCharArray()));
            // Hashset test
            Assert.Equal(retorno, Text.Filter(valor, new HashSet<char>(permitidos.ToCharArray())));
        }
    }
}
