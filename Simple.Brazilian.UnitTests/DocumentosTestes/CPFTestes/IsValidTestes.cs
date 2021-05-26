using Simple.Brazilian.Documents;
using Xunit;

namespace Simple.Brazilian.UnitTests.DocumentosTestes.CPFTestes
{
    public class IsValidTestes
    {

        [Theory]
        [InlineData(null, false)]
        [InlineData("", false)]
        [InlineData("00000000000", false)]
        [InlineData("11111111111", false)]
        [InlineData("22222222222", false)]
        [InlineData("33333333333", false)]
        [InlineData("44444444444", false)]
        [InlineData("55555555555", false)]
        [InlineData("66666666666", false)]
        [InlineData("77777777777", false)]
        [InlineData("88888888888", false)]
        [InlineData("99999999999", false)]
        [InlineData("554.875.650-82", false)]
        [InlineData("554875650820", false)]
        [InlineData("55487565O82", false)]
        [InlineData("55487565082", true)]
        public void CPF_IsValid(string cpf, bool resultado)
        {
            Assert.Equal(resultado, CPF.IsValid(cpf));
        }

    }
}
