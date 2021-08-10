using Simple.Brazilian.Validators;
using Xunit;

namespace Simple.Brazilian.UnitTests.ValidatorsTestes.BoletoTestes
{
    public class BoletoCalculateDAC
    {
        [Theory]
        [InlineData("3419166700000123451101234567880057123457000", 6)]
        [InlineData("3419814800000151961575692889300666063334000", 5)]
        [InlineData("3419157569928893006686063334000981480000015196", 5)]

        public void CalculaDAC(string valor, int inum)
        {
            Assert.Equal(inum, Boleto.CalculateCodebarDV(valor));
        }
    }
}