using Simple.Brazilian.Formatters;
using Xunit;

namespace Simple.Brazilian.UnitTests.FormatedoresTestes.TextoTestes
{
    public class RemoveMascaraTestes
    {
        /// <summary>
        /// Certifica que entrada NULL, retorna NULL
        /// </summary>
        [Fact]
        public void Texto_RemoveMascara_CertificaNullRetornaNull()
        {
            Assert.Null(Text.RemoveMascara(null));
        }
        /// <summary>
        /// Certifica que entrada Vazio, retorna Vazio
        /// </summary>
        [Fact]
        public void Texto_RemoveMascara_CertificaVazioRetornaVazio()
        {
            Assert.Equal(string.Empty, Text.RemoveMascara(string.Empty));
        }

        /// <summary>
        /// Certifica que números não são alterados
        /// </summary>
        [Fact]
        public void Texto_RemoveMascara_CertificaNumerosRetornaNumeros()
        {
            // Números do teclado ABNT2
            string testeEntrada = "1234567890";
            Assert.Equal(testeEntrada, Text.RemoveMascara(testeEntrada));
        }
        /// <summary>
        /// Certifica que letras não são alteradas
        /// </summary>
        [Fact]
        public void Texto_RemoveMascara_CertificaLetrasRetornaLetras()
        {
            // Letras do teclado ABNT2
            string testeEntrada = "qwertyuiopasdfghjklzxcvbnmQWERTYUIOPASDFGHJKLZXCVBNM";
            Assert.Equal(testeEntrada, Text.RemoveMascara(testeEntrada));
        }

        [Theory]
        [InlineData("(11) 1234-5678", "1112345678")]
        [InlineData("(11) 9.1234-5678", "11912345678")]
        [InlineData("(11)9.1234-5678", "11912345678")]
        [InlineData("+55 11 9.1234-5678", "5511912345678")]
        [InlineData("+55(11)9.1234-5678", "5511912345678")]
        public void Texto_RemoveMascara_Telefone(string entrada, string saida)
        {
            Assert.Equal(saida, Text.RemoveMascara(entrada));
        }

        [Theory]
        [InlineData("#123.456.789", "123456789")]
        [InlineData("123.456/789.1", "1234567891")]
        public void Texto_RemoveMascara_Ticket(string entrada, string saida)
        {
            Assert.Equal(saida, Text.RemoveMascara(entrada));
        }
    }
}
