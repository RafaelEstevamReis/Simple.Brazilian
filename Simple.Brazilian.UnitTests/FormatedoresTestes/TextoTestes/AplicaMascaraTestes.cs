using Simple.Brazilian.Formatters;
using System;
using Xunit;

namespace Simple.Brazilian.UnitTests.FormatedoresTestes.TextoTestes
{
    public class AplicaMascaraTestes
    {
        /// <summary>
        /// Certifica que NULLs não são aceitos
        /// </summary>
        [Theory]
        [InlineData("123", null)]
        [InlineData(null, "321")]
        [InlineData(null, null)]
        public void Texto_AplicaMascara_CertificaNullRetornamException(string valor, string mascara)
        {
            Assert.Throws<ArgumentNullException>(() => Text.ApplyMask(valor, mascara));
        }

        /// <summary>
        /// Certifica que vazios não são aceitos
        /// </summary>
        [Theory]
        [InlineData("123", "")]
        //[InlineData("", "")] // Texto VAZIO deve retornar VAZIO
        public void Texto_AplicaMascara_CertificaVaziosRetornamException(string valor, string mascara)
        {
            Assert.Throws<ArgumentException>(() => Text.ApplyMask(valor, mascara));
        }

        /// <summary>
        /// Máscara em sem inserções retorna igual
        /// </summary>
        [Theory]
        [InlineData("123", "___")]
        [InlineData("1a2", "___")]
        [InlineData("abc", "___")]
        public void Texto_AplicaMascara_CertificaMascaraLimpa(string valor, string mascara)
        {
            Assert.Equal(valor, Text.ApplyMask(valor, mascara));
        }

        /// <summary>
        /// Máscara que simula um ticket
        /// </summary>
        /// <param name="valor"></param>
        /// <param name="esperado"></param>
        [Theory]
        [InlineData("", "")]
        [InlineData("1", "#1")]
        [InlineData("12", "#12")]
        [InlineData("123", "#12.3")]
        [InlineData("1234", "#12.34")]
        [InlineData("12345", "#12.34.5")]
        [InlineData("123456", "#12.34.56")]
        [InlineData("1234567", "#12.34.56-7")]
        [InlineData("12345678", "#12.34.56-78")]
        [InlineData("123456789", "#12.34.56-789")]
        [InlineData("1234567890", "#12.34.56-789/0")]
        [InlineData("12345678901", "#12.34.56-789/01")]
        [InlineData("123456789012", "#12.34.56-789/01")] // Maior que a máscara
        public void Texto_AplicaMascara_Ticket(string valor, string esperado)
        {
            string mascara = "#__.__.__-___/__";
            Assert.Equal(esperado, Text.ApplyMask(valor, mascara));
        }

        /// <summary>
        /// Máscaras comuns
        /// </summary>
        [Theory]
        [InlineData("11912345678", "(__) _.____-____", "(11) 9.1234-5678")]
        [InlineData("12345678901", "___.___.___-__", "123.456.789-01")]
        [InlineData("12345678000190", "__.___.___/____-__", "12.345.678/0001-90")]
        public void Texto_AplicaMascara_CertificaMascarasComuns(string valor, string mascara, string esperado)
        {
            Assert.Equal(esperado, Text.ApplyMask(valor, mascara));
        }

    }
}
