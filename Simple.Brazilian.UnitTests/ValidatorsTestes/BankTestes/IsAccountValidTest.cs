using Simple.Brazilian.Validators;
using Xunit;

namespace Simple.Brazilian.UnitTests.ValidatorsTestes.BankTestes
{
    public class IsAccountValidTest
    {
        [Theory]
        [InlineData("1")]
        [InlineData("12")]
        [InlineData("123")]
        [InlineData("1234")]
        [InlineData("12345")]
        [InlineData("123456789012")]
        public void IsAccountValid_Valid(string actual)
        {
            Assert.True(Bank.IsAccountValid(actual));
        }

        [Theory]
        [InlineData(null)]
        [InlineData("")]
        [InlineData(" 2")]
        [InlineData("12 ")]
        [InlineData("1234A")]
        [InlineData("12-45")]
        [InlineData("1234567890123")]
        public void IsAccountValid_Invalid(string actual)
        {
            Assert.False(Bank.IsAccountValid(actual));
        }
    }
}
