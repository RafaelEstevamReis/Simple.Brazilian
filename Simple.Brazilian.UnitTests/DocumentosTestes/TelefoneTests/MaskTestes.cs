using Simple.Brazilian.Documents;
using System;
using Xunit;

namespace Simple.Brazilian.UnitTests.DocumentosTestes.TelefoneTests
{
    public class MaskTestes
    {
        [Theory]
        [InlineData("", "")]
        [InlineData("1", "(1")]
        [InlineData("12", "(12")]
        [InlineData("123", "(12) 3")]
        [InlineData("1245", "(12) 45")]
        [InlineData("12456", "(12) 456")]
        [InlineData("124567", "(12) 4567")]
        [InlineData("1245678", "(12) 4567-8")]
        [InlineData("12456789", "(12) 4567-89")]
        [InlineData("124567890", "(12) 4567-890")]
        [InlineData("1245678901", "(12) 4567-8901")]
        [InlineData("12345678901", "(12)3.4567-8901")]
        public void Telefone_Mask(string entrada, string saida)
        {
            Assert.Equal(saida, Telefone.Mask(entrada));
        }
        [Fact]
        public void Telefone_MaskNull()
        {
            Assert.Throws<ArgumentNullException>(() => Telefone.Mask(null));
        }
    }
}
