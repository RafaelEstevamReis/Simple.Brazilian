using Simple.Brazilian.Documents;
using Xunit;

namespace Simple.Brazilian.UnitTests.DocumentosTestes.CNPJTestes
{
    public class IsValidTestes
    {
        [Theory]
        [InlineData("16.553.608/0001-83")]
        [InlineData("74.346.180/0001-02")]
        [InlineData("87.219.712/0001-84")]
        [InlineData("77.439.239/0001-97")]
        [InlineData("95.749.912/0001-77")]
        [InlineData("96.040.168/0001-08")]
        [InlineData("17.189.722/0001-39")] // SHARP Sistemas

        public void CNPJ_IsValid_ChecaCNPJsComMascara(string entrada)
        {
            Assert.True(CNPJ.IsValid(entrada));
        }

        [Theory]
        [InlineData("16553608000183")]
        [InlineData("67406732000157")]
        [InlineData("02361553000103")]
        [InlineData("37238174000105")]
        [InlineData("39365864000142")]  
        [InlineData("34742750000150")]
        [InlineData("17189722000139")] // SHARP Sistemas

        public void CNPJ_IsValid_ChecaCNPJsSemMascara(string entrada)
        {
            Assert.True(CNPJ.IsValid(entrada));
        }


        [Theory]
        [InlineData("00550608000083")]
        [InlineData("16553608000184")]
        [InlineData("26553608000183")]
        [InlineData("43598463732675")]
        [InlineData("17189452000139")]
        [InlineData("17189722000138")]
        [InlineData("00000000000123")]

        public void CNPJ_IsValid_ChecaCNPJsErrados(string entrada)
        {
            Assert.False(CNPJ.IsValid(entrada));
        }
    }
}
