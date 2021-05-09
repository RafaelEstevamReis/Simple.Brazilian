using Simple.Brazilian.Validadores;
using Xunit;

namespace Simple.Brazilian.UnitTests.ValidadoresTestes.CPFTestes
{
    public class MaskTestes
    {
        [Theory]
        [InlineData("12345678900", "123.456.789-00")]
        public void CPF_Unmask(string entrada, string saida)
        {
            Assert.Equal(saida, CPF.Mask(entrada));
        }
    }
}
