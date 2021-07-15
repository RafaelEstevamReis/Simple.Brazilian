using Simple.Brazilian.Validators;
using Xunit;

namespace Simple.Brazilian.UnitTests.ValidatorsTestes.ModValitationTestes
{
    public class CalculateMult10Mod11Testes
    {
        [Theory]
        [InlineData("0318556006", 0, '0')] // resto 10
        [InlineData("1453822062", 0, '0')] // resto  0
        [InlineData("520684780", 1, '1')]
        [InlineData("145382206", 2, '2')]
        [InlineData("5206847801", 3, '3')]
        [InlineData("256379520", 6, '6')]
        [InlineData("558004250", 7, '7')]
        [InlineData("5580042507", 8, '8')]
        [InlineData("847122540", 9, '9')]
        public void CalculateMod11_11_2(string text, int inum, char cnum)
        {
            Assert.Equal(inum, ModValidation.CalculateMult10Mod11(text, 2, 11));
            Assert.Equal(cnum, ModValidation.CalculateMult10Mod11Char(text, 2, 11));
        }
    }
}
