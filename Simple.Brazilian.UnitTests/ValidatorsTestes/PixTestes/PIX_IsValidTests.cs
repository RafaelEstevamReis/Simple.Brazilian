using Simple.Brazilian.Validators;
using Xunit;

namespace Simple.Brazilian.UnitTests.ValidatorsTestes.PixTestes
{
    public class PIX_IsValidTests
    {
        // Testa exemplos do Manual PIX
        // https://www.bcb.gov.br/content/estabilidadefinanceira/pix/Regulamento_Pix/II_ManualdePadroesparaIniciacaodoPix.pdf

        [Fact]
        public void ChavePIX_CPF()
        {
            // Gerado no 4Devs
            Assert.True(Pix.IsValid_CPF("21930608004")); // Específico
            Assert.True(Pix.IsValid("21930608004")); // Genérico

            // O Exmeplo do manual, NÃO É VÁLIDO
            Assert.False(Pix.IsValid_CPF("12345678900")); // Específico
            Assert.False(Pix.IsValid("12345678900")); // Genérico
        }
        [Fact]
        public void ChavePIX_CNPJ()
        {
            Assert.True(Pix.IsValid_CNPJ("00038166000105")); // Específico
            Assert.True(Pix.IsValid("00038166000105")); // Genérico
        }
        [Fact]
        public void ChavePIX_Celular()
        {
            Assert.True(Pix.IsValid_Celular("+5561912345678")); // Específico
            Assert.True(Pix.IsValid("+5561912345678")); // Genérico
        }
        [Fact]
        public void ChavePIX_EMail()
        {
            Assert.True(Pix.IsValid_Email("fulano_da_silva.recebedor@example.com")); // Específico
            Assert.True(Pix.IsValid("fulano_da_silva.recebedor@example.com")); // Genérico
        }
        [Fact]
        public void ChavePIX_Aleatorio()
        {
            Assert.True(Pix.IsValid_Aleatoria("123e4567-e12b-12d1-a456-426655440000")); // Específico
            Assert.True(Pix.IsValid("123e4567-e12b-12d1-a456-426655440000")); // Genérico
        }
    }
}
