using Simple.Brazilian.Validators;
using Xunit;

namespace Simple.Brazilian.UnitTests.ValidatorsTestes.ModValitationTestes
{
    public class CalculateMod11Testes
    {
        [Theory]
        [InlineData("1453822062", 0, '0')]
        [InlineData("520684780", 0, '0')] // Resto 10
        [InlineData("847122540", 2, '2')]
        [InlineData("0318556006", 1, '1')]
        [InlineData("5580042507", 3, '3')]
        [InlineData("558004250", 4, '4')]
        [InlineData("256379520", 5, '5')]
        [InlineData("5206847801", 8, '8')]
        [InlineData("145382206", 9, '9')]
        public void CalculateMod11_11_2(string text, int inum, char cnum)
        {
            Assert.Equal(inum, ModValidation.CalculateMod11(text, 2, 11));
            Assert.Equal(cnum, ModValidation.CalculateMod11Char(text, 2, 11));
        }
    }
}
