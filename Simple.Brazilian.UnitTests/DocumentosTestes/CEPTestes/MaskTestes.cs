using Simple.Brazilian.Documentos;
using Xunit;

namespace Simple.Brazilian.UnitTests.DocumentosTestes.CEPTestes
{
    public class MaskTestes
    {
        [Theory]
        [InlineData("", "")]
        [InlineData("1", "1")]
        [InlineData("12", "12")]
        [InlineData("123", "12.3")]
        [InlineData("1234", "12.34")]
        [InlineData("12345", "12.345")]
        [InlineData("123456", "12.345-6")]
        [InlineData("1234567", "12.345-67")]
        [InlineData("12345678", "12.345-678")]
        public void CEP_Unmask(string entrada, string saida)
        {
            Assert.Equal(saida, CEP.Mask(entrada));
        }
    }
}
