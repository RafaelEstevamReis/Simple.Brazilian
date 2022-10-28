using Simple.Brazilian.Documents;
using Xunit;

namespace Simple.Brazilian.UnitTests.DocumentosTestes.CNPJTestes
{
    public class CompleteWithDigitsTestes
    {
        [Theory]
        [InlineData("16553608000183")]
        [InlineData("67406732000157")]
        [InlineData("02361553000103")] // primeiro dígito == 10
        [InlineData("34534876000130")] // Segundo dígito == 10
        [InlineData("37238174000105")]
        [InlineData("39365864000142")]
        [InlineData("34742750000150")]
        [InlineData("17189722000139")] // SHARP Sistemas
        public void CNPJ_CompleteWithDigitsCNPJ(string cnpjCompleto)
        {
            string cnpjParcial = cnpjCompleto[..12];
            var result = CNPJ.CompleteWithDigitsCNPJ(cnpjParcial);

            Assert.Equal(cnpjCompleto, result);
        }
    }
}
