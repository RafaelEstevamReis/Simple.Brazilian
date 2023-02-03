using Simple.Brazilian.Validators;
using Xunit;

namespace Simple.Brazilian.UnitTests.ValidatorsTestes.BankTestes
{
    public class IsBankNumberValidTest
    {
        [Theory]
        [InlineData("000")]
        [InlineData("123")]
        public void IsBankNumberValid_Valid(string strBanco)
        {
            Assert.True(Bank.IsBankNumberValid(strBanco));
        }

        [Theory]
        [InlineData(null)]
        [InlineData("")]
        [InlineData("12")]
        [InlineData("1")]
        [InlineData("1234")]
        [InlineData(" 12")]
        [InlineData(" 123")]
        [InlineData("1A3")]
        [InlineData("1-3")]
        public void IsBankNumberValid_Invalid(string strBanco)
        {
            Assert.False(Bank.IsBankNumberValid(strBanco));
        }
    }
}
