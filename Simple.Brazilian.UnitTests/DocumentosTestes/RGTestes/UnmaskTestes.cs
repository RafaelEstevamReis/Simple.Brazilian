using Simple.Brazilian.Documents;
using Xunit;

namespace Simple.Brazilian.UnitTests.DocumentosTestes.RGTestes
{
    public class UnmaskTestes
    {
        [Theory]
        [InlineData("000.000.000", "000000000")]
        [InlineData("000.000.000-0", "0000000000")]
        [InlineData("000.000.00-0", "000000000")]
        public void IE_Unmask(string entrada, string saida)
        {
            Assert.Equal(saida, RG.Unmask(entrada));
        }
    }
}
