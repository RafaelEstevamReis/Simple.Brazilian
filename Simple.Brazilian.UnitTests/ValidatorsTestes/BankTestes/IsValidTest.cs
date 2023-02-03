using Simple.Brazilian.Validators;
using Xunit;

namespace Simple.Brazilian.UnitTests.ValidatorsTestes.BankTestes
{
    public class IsValidTest
    {
        [Theory]
        [InlineData("123", "1", "1")]
        [InlineData("123", "1-1", "1")]
        [InlineData("123", "1", "1-1")]
        public void IsAccountValid_Valid(string bank, string agency, string account)
        {
            Assert.True(Bank.IsValid(bank, agency, account));
        }

        [Theory]
        [InlineData(null, "1", "1")]
        [InlineData("123", null, "1")]
        [InlineData("123", "1", null)]
        [InlineData("", "1", "1")]
        [InlineData("123", "", "1")]
        [InlineData("123", "1", "")]
        [InlineData("123", "X-1", "1")]
        [InlineData("123", "1", "X-1")]
        public void IsAccountValid_Invalid(string bank, string agency, string account)
        {
            Assert.False(Bank.IsValid(bank, agency, account));
        }
    }
}
