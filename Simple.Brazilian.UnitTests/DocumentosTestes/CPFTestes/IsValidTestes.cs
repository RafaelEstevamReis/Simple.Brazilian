using Simple.Brazilian.Documents;
using Xunit;

namespace Simple.Brazilian.UnitTests.DocumentosTestes.CPFTestes
{
    public class IsValidTestes
    {

        [Theory]
        [InlineData("554.875.650-82")]
        [InlineData("858.572.670-99")]
        [InlineData("588.019.800-60")]
        public void CPF_IsValid_ComMascara(string cpf)
        {
            Assert.True(CPF.IsValid(cpf));
        }


        [Theory]
        [InlineData("55487565082")]
        [InlineData("27419682097")]
        [InlineData("43364585024")]
        public void CPF_IsValid_SemMascara(string cpf)
        {
            Assert.True(CPF.IsValid(cpf));
        }


        [Theory]
        [InlineData(null)]
        [InlineData("")]
        [InlineData("00000000000")]
        [InlineData("11111111111")]
        [InlineData("22222222222")]
        [InlineData("33333333333")]
        [InlineData("44444444444")]
        [InlineData("55555555555")]
        [InlineData("66666666666")]
        [InlineData("77777777777")]
        [InlineData("88888888888")]
        [InlineData("99999999999")]
        [InlineData("554.875.650-820")]
        [InlineData("554.875.65O-82")]
        public void CPF_IsValid_Errados(string cpf)
        {
            Assert.False(CPF.IsValid(cpf));
        }

    }
}
