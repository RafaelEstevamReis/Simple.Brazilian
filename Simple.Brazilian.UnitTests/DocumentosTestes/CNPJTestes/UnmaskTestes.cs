using Simple.Brazilian.Documentos;
using Xunit;

namespace Simple.Brazilian.UnitTests.DocumentosTestes.CNPJTestes
{
    public class UnmaskTestes
    {
        [Theory]
        [InlineData("12.345.678/0001-90", "12345678000190")]
        [InlineData("12.345.678.0001.90", "12345678000190")]
        public void CNPJ_Unmask(string entrada, string saida)
        {
            Assert.Equal(saida, CNPJ.Unmask(entrada));
        }
    }
}
