using Simple.Brazilian.Validators;
using Xunit;

namespace Simple.Brazilian.UnitTests.ValidatorsTestes.BankTestes
{
    public class IsAgencyValidTest
    {
        [Theory]
        [InlineData("1")]
        [InlineData("12")]
        [InlineData("123")]
        [InlineData("1234")]
        [InlineData("12345")]
        public void IsAgencyValid_Valid(string actual)
        {
            Assert.True(Bank.IsAgencyValid(actual));
        }

        [Theory]
        [InlineData(null)]
        [InlineData("")]
        [InlineData(" 2")]
        [InlineData("12 ")]
        [InlineData("1234A")]
        [InlineData("12-45")]
        [InlineData("123456")]
        public void IsAgencyValid_Invalid(string actual)
        {
            Assert.False(Bank.IsAgencyValid(actual));
        }

    }
}
