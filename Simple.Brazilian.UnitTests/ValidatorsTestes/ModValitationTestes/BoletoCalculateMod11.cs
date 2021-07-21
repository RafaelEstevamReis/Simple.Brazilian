using Simple.Brazilian.Validators;
using Xunit;

namespace Simple.Brazilian.UnitTests.ValidatorsTestes.ModValitationTestes
{
    public class BoletoCalculateMod11
    {
        [Theory]
        [InlineData("0019050095", "40144816069", "06809350314", 3)]

        public void CalculateMod11(string campo1, string campo2, string campo3, int inum)
        {
            Assert.Equal(inum, Boleto.Mod11(campo1, campo2, campo3));
        }
    }
}
