using Simple.Brazilian.Documentos;
using Xunit;

namespace Simple.Brazilian.UnitTests.DocumentosTestes.PISTestes
{
    public class UnmaskTestes
    {
        [Theory]
        [InlineData("000.00000.00.0", "00000000000")]
        public void PIS_Unmask(string entrada, string saida)
        {
            Assert.Equal(saida, PIS.Unmask(entrada));
        }
    }
}
