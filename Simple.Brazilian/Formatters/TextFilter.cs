using System;

namespace Simple.Brazilian.Formatters
{
    internal class TextFilter
    {
        public bool AllowsNumbers { get; set; } = false;
        public bool AllowsUppercaseLetters { get; set; } = false;
        public bool AllowsLowercaseLetters { get; set; } = false;
        public bool AllowsSymbols { get; set; } = false;
        public bool AllowsWhitespace { get; set; } = false;

        private TextFilter(string text) { }

        public TextFilter Configure(Action<TextFilter> options) => throw new NotImplementedException();

        public TextFilter DenyAll() => throw new NotImplementedException();
        public TextFilter AllowAll() => throw new NotImplementedException();

        public TextFilter AllowNumbers() => throw new NotImplementedException();
        public TextFilter AllowUppercaseLetters() => throw new NotImplementedException();
        public TextFilter AllowLowercaseLetters() => throw new NotImplementedException();
        public TextFilter AllowSymbols() => throw new NotImplementedException();
        public TextFilter AllowWhitespace() => throw new NotImplementedException();

        public TextFilter DenyNumbers() => throw new NotImplementedException();
        public TextFilter DenyUppercaseLetters() => throw new NotImplementedException();
        public TextFilter DenyLowercaseLetters() => throw new NotImplementedException();
        public TextFilter DenySymbols() => throw new NotImplementedException();
        public TextFilter DenyWhitespace() => throw new NotImplementedException();

        public string Execute() => throw new NotImplementedException();

        public static TextFilter Filter(string text) => new TextFilter(text);
    }
    internal static class TextFilterExtension
    {
        public static TextFilter Filter(this string text) => TextFilter.Filter(text);
    }
}
