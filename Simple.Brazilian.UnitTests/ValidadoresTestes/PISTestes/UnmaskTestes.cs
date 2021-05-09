using Simple.Brazilian.Validadores;
using Xunit;

namespace Simple.Brazilian.UnitTests.ValidadoresTestes.PISTestes
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
