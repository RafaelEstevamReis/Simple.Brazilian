using Xunit;

namespace Simple.Brazilian.UnitTests.FormattersTestes.TextTestes
{
    /// <summary>
    /// Testes de remoção de espaços
    /// </summary>
    public class RemoveEspacos
    {
        [Theory]
        [InlineData("0 123 456 789", "  0  123  456  789  ")]
        [InlineData("testando teste\r\n\r\nteste 123", "testando      teste\r\n\r\nteste 123")]
        [InlineData("123\r\n456", " 123 \r\n 456 ")]
        [InlineData("0000 123\r\n456", "\r\n\r\n    0000   123\r\n456")]
        [InlineData("0000 123\n456", "\n\n    0000   123\n456")]
        [InlineData("0000 123\n456", "\r\n    0000   123\n456")]
        [InlineData("", "        ")]
        [InlineData("-", "     -   ")]
        [InlineData("", "     \n   ")]
        [InlineData("", "     \n\r   ")]
        [InlineData("", "     \n\r\n   ")]
        [InlineData("", "     \n\r\r   ")]
        [InlineData("", "     \n\r \n\r   ")]

        public void RemoveUnnecessarySpaces(string esperado, string valor)
        {
            var resultado = Formatters.Text.RemoveEspacosDesnecessarios(valor);
            Assert.Equal(esperado, resultado);
        }
    }
}
