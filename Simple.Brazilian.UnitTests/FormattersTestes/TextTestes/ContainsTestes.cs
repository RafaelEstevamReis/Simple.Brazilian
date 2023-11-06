namespace Simple.Brazilian.UnitTests.FormattersTestes.TextTestes;
using Xunit;

public class ContainsTestes
{
    [Theory]
    [InlineData("Hello123", Formatters.Text.CharacterType.UppercaseLetters, true)]
    [InlineData("Hello123", Formatters.Text.CharacterType.Numbers, true)]
    [InlineData("Hello123", Formatters.Text.CharacterType.Symbols, false)]
    [InlineData("Hello123", Formatters.Text.CharacterType.Whitespace, false)]
    [InlineData("Hello123", Formatters.Text.CharacterType.Punctuation, false)]
    [InlineData("Hello, World!", Formatters.Text.CharacterType.Symbols, false)]
    [InlineData("Hello, World+", Formatters.Text.CharacterType.Symbols, true)]
    [InlineData("Hello, World!", Formatters.Text.CharacterType.Punctuation, true)]
    [InlineData("Hello, World!", Formatters.Text.CharacterType.Whitespace, true)]
    [InlineData(" ", Formatters.Text.CharacterType.Symbols, false)]
    [InlineData(" ", Formatters.Text.CharacterType.Punctuation, false)]
    [InlineData(" ", Formatters.Text.CharacterType.Whitespace, true)]
    public void Texto_ContainsAny(string text, Formatters.Text.CharacterType type, bool expected)
    {
        bool result = Formatters.Text.ContainsAny(text, type);
        Assert.Equal(expected, result);
    }

    [Theory]
    [InlineData("Hello123", Formatters.Text.CharacterType.UppercaseLetters, false)]
    [InlineData("Hello123", Formatters.Text.CharacterType.Numbers, false)]
    [InlineData("Hello123", Formatters.Text.CharacterType.Symbols, false)]
    [InlineData("Hello123", Formatters.Text.CharacterType.LowercaseLetters, false)]
    [InlineData("hello", Formatters.Text.CharacterType.LowercaseLetters, true)]
    [InlineData("Hello123", Formatters.Text.CharacterType.Punctuation, false)]
    [InlineData("Hello123", Formatters.Text.CharacterType.Whitespace, false)]
    [InlineData("Hello, World!", Formatters.Text.CharacterType.Symbols, false)]
    [InlineData("$¨", Formatters.Text.CharacterType.Symbols, true)]
    [InlineData("Hello, World!", Formatters.Text.CharacterType.Punctuation, false)]
    [InlineData("Hello, World!", Formatters.Text.CharacterType.Whitespace, false)]
    [InlineData(" ", Formatters.Text.CharacterType.Symbols, false)]
    [InlineData(" ", Formatters.Text.CharacterType.Punctuation, false)]
    [InlineData(" ", Formatters.Text.CharacterType.Whitespace, true)]
    public void Texto_ContainsOnly(string text, Formatters.Text.CharacterType type, bool expected)
    {
        bool result = Formatters.Text.ContainsOnly(text, type);
        Assert.Equal(expected, result);
    }
}
