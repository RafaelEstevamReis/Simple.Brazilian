using Simple.Brazilian.Documentos;
using Xunit;

namespace Simple.Brazilian.UnitTests.DocumentosTestes.CEPTestes
{
    public class UnmaskTestes
    {
        [Theory]
        [InlineData("12.345-678", "12345678")]
        [InlineData("12345-678", "12345678")]
        public void CEP_Unmask(string entrada, string saida)
        {
            Assert.Equal(saida, CEP.Unmask(entrada));
        }
    }
}
