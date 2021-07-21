using Simple.Brazilian.Validators;
using Xunit;

namespace Simple.Brazilian.UnitTests.ValidatorsTestes.ModValitationTestes
{
    public class BoletoCalculateMod10
    {
        [Theory]
        [InlineData("001905009", 5)]
        [InlineData("4014481606", 9)]
        [InlineData("0680935031", 4)]
        [InlineData("033991234", 7)]
        [InlineData("341910901", 6)]
        [InlineData("0419793456", 7)]
        [InlineData("00190500940144816060680935031", 5)]

        public void CalculateMod10(string text, int inum)
        {
            Assert.Equal(inum, Boleto.Mod10(text));
        }
    }
}
