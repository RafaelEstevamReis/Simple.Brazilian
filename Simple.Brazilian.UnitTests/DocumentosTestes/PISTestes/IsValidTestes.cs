using Simple.Brazilian.Documents;
using Xunit;

namespace Simple.Brazilian.UnitTests.DocumentosTestes.PISTestes
{
    public class IsValidTestes
    {
        [Theory]
        [InlineData("311.34504.38-0")]
        [InlineData("396.39967.28-6")]
        [InlineData("872.27074.55-1")]
        public void CPF_IsValid_ComMascara(string cpf)
        {
            Assert.True(PIS.IsValid(cpf));
        }

        [Theory]
        // Precisa checar qual caminho foi tomado para
        // chegar em resultado zero
        [InlineData("97001249730")]
        [InlineData("33527025760")] // Resto 10 => 0
        [InlineData("36919166130")]
        [InlineData("61000496989")]
        [InlineData("57038599841")]
        [InlineData("01035078292")]
        public void CPF_IsValid_SemMascara(string cpf)
        {
            Assert.True(PIS.IsValid(cpf));
        }

        [Theory]
        [InlineData(null)]
        [InlineData("")]
        [InlineData("311.3454.38-0")]
        [InlineData("311.34504.38-00")]
        [InlineData("13063422282")]
        [InlineData("5874367497")]
        [InlineData("A3449332943")]
        [InlineData("!3449332943")]
        public void CPF_IsValid_Errados(string cpf)
        {
            Assert.False(PIS.IsValid(cpf));
        }
    }
}
