using Xunit;

namespace Simple.Brazilian.UnitTests.FormattersTestes.TextTestes
{
    public class TruncateTestes
    {
        [Theory]
        [InlineData(null, null, 1)]
        [InlineData("", "", 1)]
        [InlineData("A", "AA", 1)]
        [InlineData("AA", "AA", 2)]
        [InlineData("AA", "AA", 3)]
        public void TruncateText(string esperado, string valor, int comprimento)
        {
            var resultado = Formatters.Text.TruncateText(valor, comprimento);
            Assert.Equal(esperado, resultado);
        }
    }
}
