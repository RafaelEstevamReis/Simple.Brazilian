using Simple.Brazilian.Formatadores;
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
            Assert.Null(Texto.RemoveMascara(null));
        }
        /// <summary>
        /// Certifica que entrada Vazio, retorna Vazio
        /// </summary>
        [Fact]
        public void Texto_RemoveMascara_CertificaVazioRetornaVazio()
        {
            Assert.Equal(string.Empty, Texto.RemoveMascara(string.Empty));
        }

        /// <summary>
        /// Certifica que números não são alterados
        /// </summary>
        [Fact]
        public void Texto_RemoveMascara_CertificaNumerosRetornaNumeros()
        {
            // Números do teclado ABNT2
            string testeEntrada = "1234567890";
            Assert.Equal(testeEntrada, Texto.RemoveMascara(testeEntrada));
        }
        /// <summary>
        /// Certifica que letras não são alteradas
        /// </summary>
        [Fact]
        public void Texto_RemoveMascara_CertificaLetrasRetornaLetras()
        {
            // Letras do teclado ABNT2
            string testeEntrada = "qwertyuiopasdfghjklzxcvbnmQWERTYUIOPASDFGHJKLZXCVBNM";
            Assert.Equal(testeEntrada, Texto.RemoveMascara(testeEntrada));
        }

        [Theory]
        [InlineData("(11) 1234-5678", "1112345678")]
        [InlineData("(11) 9.1234-5678", "11912345678")]
        [InlineData("(11)9.1234-5678", "11912345678")]
        [InlineData("+55 11 9.1234-5678", "5511912345678")]
        [InlineData("+55(11)9.1234-5678", "5511912345678")]
        public void Texto_RemoveMascara_Telefone(string entrada, string saida)
        {
            Assert.Equal(saida, Texto.RemoveMascara(entrada));
        }

        [Theory]
        [InlineData("12.345-678", "12345678")]
        [InlineData("12345-678", "12345678")]
        public void Texto_RemoveMascara_CEP(string entrada, string saida)
        {
            Assert.Equal(saida, Texto.RemoveMascara(entrada));
        }

        [Theory]
        [InlineData("123.456.789-01", "12345678901")]
        [InlineData("123.456.789/01", "12345678901")]
        public void Texto_RemoveMascara_CPF(string entrada, string saida)
        {
            Assert.Equal(saida, Texto.RemoveMascara(entrada));
        }

        [Theory]
        [InlineData("12.345.678/0001-90", "12345678000190")]
        [InlineData("12.345.678.0001.90", "12345678000190")]
        public void Texto_RemoveMascara_CNPJ(string entrada, string saida)
        {
            Assert.Equal(saida, Texto.RemoveMascara(entrada));
        }

        [Theory]
        [InlineData("#123.456.789", "123456789")]
        [InlineData("123.456/789.1", "1234567891")]
        public void Texto_RemoveMascara_Ticket(string entrada, string saida)
        {
            Assert.Equal(saida, Texto.RemoveMascara(entrada));
        }
    }
}
