using Simple.Brazilian.Validators;
using Xunit;

namespace Simple.Brazilian.UnitTests.ValidatorsTestes.ModValitationTestes
{
    public class BoletoCalculateMod10
    {
        [Theory]
        // Boleto Banco do Brasil
        [InlineData("001905009", 5)]
        [InlineData("4014481606", 9)]
        [InlineData("0680935031", 4)]
        // ???
        [InlineData("033991234", 7)]
        // Boleto ex "como identificar boletos falsos.pdf"
        [InlineData("341910901", 6)]
        [InlineData("0419793456", 7)]
        [InlineData("2553067000", 6)]
        // Boleto real do cliente Itau
        [InlineData("341915756", 9)]
        [InlineData("9288930066", 8)]
        [InlineData("6063334000", 9)]
        // Boleto ex Itau
        [InlineData("341911012", 1)]
        [InlineData("3456788005", 8)]
        [InlineData("7123457000", 1)]
        public void CalculateMod10(string text, int inum)
        {
            Assert.Equal(inum, Boleto.Mod10(text));
        }
    }
}
