using Xunit;

namespace Simple.Brazilian.UnitTests.ValidatorsTestes.EMailTestes
{
    public class IsValidTests
    {
        [Theory]
        [InlineData("abc-d@mail.com")]
        [InlineData("abc.def@mail.com")]
        [InlineData("abc@mail.com")]
        [InlineData("abc_def@mail.com")]
        [InlineData("abc.def@mail.cc")]
        [InlineData("abc.def@mail-archive.com")]
        [InlineData("abc.def@mail.archive.com")]
        [InlineData("abc.def@mail.org")]
        public void Email_IsValid_CasosSimples(string email)
        {
            Assert.True(Validators.EMail.IsValid(email));
        }

        [Theory]
        //[InlineData("abc-@mail.com")] // HTML5 aceita
        //[InlineData("abc..def@mail.com")] // HTML5 aceita
        //[InlineData(".abc@mail.com")] // HTML5 aceita
        //[InlineData("abc#def@mail.com")] // HTML5 aceita
        [InlineData("abc.def@mail#archive.com")]
        //[InlineData("abc.def@mail")] // HTML5 aceita
        [InlineData("abc.def@mail..com")]
        public void Email_IsValid_Violacoes(string email)
        {
            Assert.False(Validators.EMail.IsValid(email));
        }

        [Theory]
        [InlineData("simple@example.com")]
        [InlineData("very.common@example.com")]
        [InlineData("abc@example.co.uk")]
        [InlineData("disposable.style.email.with+symbol@example.com")]
        [InlineData("other.email-with-hyphen@example.com")]
        [InlineData("fully-qualified-domain@example.com")]
        [InlineData("user.name+tag+sorting@example.com")]
        [InlineData("example-indeed@strange-example.com")]
        [InlineData("example-indeed@strange-example.inininini")]
        public void Email_IsValid_Exemplo(string email)
        {
            Assert.True(Validators.EMail.IsValid(email));
        }

    }
}
