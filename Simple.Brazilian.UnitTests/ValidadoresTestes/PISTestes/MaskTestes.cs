using Simple.Brazilian.Validadores;
using Xunit;

namespace Simple.Brazilian.UnitTests.ValidadoresTestes.PISTestes
{
    public class MaskTestes
    {
        [Theory]
        [InlineData("12345678900", "123.45678.90.0")]
        [InlineData("00000000000", "000.00000.00.0")]
        public void PIS_Unmask(string entrada, string saida)
        {
            Assert.Equal(saida, PIS.Mask(entrada));
        }
    }
}
