using Simple.Brazilian.Formatadores;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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
            Assert.Throws<ArgumentNullException>(() => Texto.AplicaMascara(valor, mascara));
        }

        /// <summary>
        /// Certifica que vazios não são aceitos
        /// </summary>
        [Theory]
        [InlineData("123", "")]
        [InlineData("", "321")]
        [InlineData("", "")]
        public void Texto_AplicaMascara_CertificaVaziosRetornamException(string valor, string mascara)
        {
            Assert.Throws<ArgumentException>(() => Texto.AplicaMascara(valor, mascara));
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
            Assert.Equal(valor, Texto.AplicaMascara(valor, mascara));
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
            Assert.Equal(esperado, Texto.AplicaMascara(valor, mascara));
        }

    }
}
