using Simple.Brazilian.Documentos;
using Xunit;

namespace Simple.Brazilian.UnitTests.DocumentosTestes.CEPTestes
{
    public class MaskTestes
    {
        [Theory]
        [InlineData("12345678", "12.345-678")]
        public void CEP_Unmask(string entrada, string saida)
        {
            Assert.Equal(saida, CEP.Mask(entrada));
        }
    }
}
