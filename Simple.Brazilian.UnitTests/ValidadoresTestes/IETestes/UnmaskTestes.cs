using Simple.Brazilian.Validadores;
using Xunit;

namespace Simple.Brazilian.UnitTests.ValidadoresTestes.IETestes
{
    public class UnmaskTestes
    {
        [Theory]
        [InlineData("00.000.000/000-00", "0000000000000")]
        [InlineData("00.000.000-0", "000000000")]
        [InlineData("000000-00",  "00000000")]
        [InlineData("00000000-0", "000000000")]
        [InlineData("00000000000-00", "0000000000000")]
        [InlineData("0000000000-0",   "00000000000")]
        [InlineData("000.000.000-0000", "0000000000000")]
        [InlineData("00-000000-0", "000000000")]
        [InlineData("00000000-00", "0000000000")]
        [InlineData("00.0.000.0000000-0", "00000000000000")]
        [InlineData("00.000.00-0", "00000000")]
        [InlineData("000/0000000", "0000000000")]
        [InlineData("000.00000-0", "000000000")]
        [InlineData("000.000.000", "000000000")]
        [InlineData("000.000.000.000", "000000000000")]
        [InlineData("000000000-0", "0000000000")]
        public void IE_Unmask(string entrada, string saida)
        {
            Assert.Equal(saida, IE.Unmask(entrada));
        }
    }
}
