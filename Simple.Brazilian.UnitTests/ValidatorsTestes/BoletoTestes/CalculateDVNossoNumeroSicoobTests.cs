using Simple.Brazilian.Validators;
using Xunit;

namespace Simple.Brazilian.UnitTests.ValidatorsTestes.BoletoTestes
{
    public class CalculateDVNossoNumeroSicoobTests
    {
        [Theory]
        [InlineData("4423", "531413", 7630, '0')]
        [InlineData("4423", "531413", 8115, '0')]
        [InlineData("4423", "531413", 7772, '1')]
        [InlineData("4423", "531413", 8040, '2')]
        [InlineData("4423", "531413", 8066, '3')]
        [InlineData("4423", "531413", 7499, '4')]
        [InlineData("4423", "531413", 7666, '5')]
        [InlineData("4423", "531413", 8139, '6')]
        [InlineData("4423", "531413", 8135, '7')]
        [InlineData("4423", "531413", 7568, '8')]
        [InlineData("4423", "531413", 7773, '9')]
        public void CalculaDV(string numCooperativa, string numCliente, int nossoNumeroBase, char expected)
        {
            Assert.Equal(expected, Boleto.CalculateDV_NossoNumero_Sicoob(numCooperativa, numCliente, nossoNumeroBase));
        }
    }
}
