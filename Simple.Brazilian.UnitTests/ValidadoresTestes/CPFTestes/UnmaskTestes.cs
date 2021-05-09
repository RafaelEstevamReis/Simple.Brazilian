using Simple.Brazilian.Validadores;
using Xunit;

namespace Simple.Brazilian.UnitTests.ValidadoresTestes.CPFTestes
{
    public class UnmaskTestes
    {
        [Theory]
        [InlineData("123.456.789-01", "12345678901")]
        [InlineData("123.456.789/01", "12345678901")]
        public void CPF_Unmask(string entrada, string saida)
        {
            Assert.Equal(saida, CPF.Unmask(entrada));
        }
    }
}
