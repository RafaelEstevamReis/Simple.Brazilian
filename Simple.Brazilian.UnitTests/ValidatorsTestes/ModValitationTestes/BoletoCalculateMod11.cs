using Simple.Brazilian.Validators;
using Xunit;

namespace Simple.Brazilian.UnitTests.ValidatorsTestes.ModValitationTestes
{
    public class BoletoCalculateMod11
    {
        [Theory]
        // BB: Boleto Banco do Brasil
        [InlineData("0019050095", "40144816069", "06809350314", 3)]
        // Itau: Boleto ex "como identificar boletos falsos.pdf"
        [InlineData("3419109016", "04197934567", "25530670006", 1)]
        // Itau: Boleto real do cliente Itau
        [InlineData("3419157569", "92889300668", "60633340009", 5)]
        // Itau: Boleto ex Itau
        [InlineData("3419110121", "34567880058", "71234570001", 6)]

        public void CalculateMod11(string campo1, string campo2, string campo3, int inum)
        {
            Assert.Equal(inum, Boleto.Mod11(campo1, campo2, campo3));
        }
    }
}
