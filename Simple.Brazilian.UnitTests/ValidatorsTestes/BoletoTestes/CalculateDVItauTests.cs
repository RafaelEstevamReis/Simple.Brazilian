using Simple.Brazilian.Validators;
using Xunit;

namespace Simple.Brazilian.UnitTests.ValidatorsTestes.BoletoTestes
{
    public class CalculateDVItauTests
    {
        [Theory]
        [InlineData("001905009",  '5')]
        [InlineData("4014481606", '9')]
        [InlineData("0680935031", '4')]
        [InlineData("033991234",  '7')]
        [InlineData("341910901",  '6')]
        [InlineData("0419793456", '7')]
        [InlineData("2553067000", '6')]
        [InlineData("341915756",  '9')]
        [InlineData("9288930066", '8')]
        [InlineData("6063334000", '9')]
        [InlineData("341911012",  '1')]
        [InlineData("3456788005", '8')]
        [InlineData("7123457000", '1')]
        public void CalculaDV(string text, char inum)
        {
            Assert.Equal(inum, Boleto.CalculateDV_Itau(text));
        }
    }
}
