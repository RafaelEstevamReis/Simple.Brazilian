using System;
using System.Text;

namespace Simple.Brazilian.Formatters
{
    public class TextFilter
    {
        private readonly string text;

        public bool AllowsNumbers { get; set; } = false;
        public bool AllowsUppercaseLetters { get; set; } = false;
        public bool AllowsLowercaseLetters { get; set; } = false;
        public bool AllowsSymbols { get; set; } = false;
        public bool AllowsPunctuation { get; set; } = false;
        public bool AllowsWhitespace { get; set; } = false;

        private TextFilter(string text)
        {
            if (text is null)
            {
                throw new ArgumentNullException(nameof(text));
            }

            this.text = text;
        }

        internal TextFilter Configure(Action<TextFilter> options) => throw new NotImplementedException();

        public TextFilter DenyAll()
        {
            AllowsNumbers =
                AllowsUppercaseLetters =
                AllowsLowercaseLetters =
                AllowsSymbols =
                AllowsPunctuation = 
                AllowsWhitespace = false;
            return this;
        }
        public TextFilter AllowAll()
        {
            AllowsNumbers =
                AllowsUppercaseLetters =
                AllowsLowercaseLetters =
                AllowsSymbols =
                AllowsPunctuation =
                AllowsWhitespace = true;
            return this;
        }

        public TextFilter AllowNumbers()
        {
            AllowsNumbers = true;
            return this;
        }
        public TextFilter AllowUppercaseLetters()
        {
            AllowsUppercaseLetters = true;
            return this;
        }
        public TextFilter AllowLowercaseLetters()
        {
            AllowsLowercaseLetters = true;
            return this;
        }
        public TextFilter AllowSymbols()
        {
            AllowsSymbols = true;
            return this;
        }
        public TextFilter AllowPunctuation()
        {
            AllowsPunctuation= true;
            return this;
        }
        public TextFilter AllowWhitespace()
        {
            AllowsWhitespace = true;
            return this;
        }

        public TextFilter DenyNumbers()
        {
            AllowsNumbers = false;
            return this;
        }
        public TextFilter DenyUppercaseLetters()
        {
            AllowsUppercaseLetters = false;
            return this;
        }
        public TextFilter DenyLowercaseLetters()
        {
            AllowsLowercaseLetters = false;
            return this;
        }
        public TextFilter DenySymbols()
        {
            AllowsSymbols = false;
            return this;
        }
        public TextFilter DenyPunctuation()
        {
            AllowsPunctuation = false;
            return this;
        }
        public TextFilter DenyWhitespace()
        {
            AllowsWhitespace = false;
            return this;
        }

        public string Execute()
        {
            StringBuilder sb = new StringBuilder(text.Length);

            for (int i = 0; i < text.Length; i++)
            {
                char c = text[i];

                if (!AllowsNumbers && char.IsNumber(c)) continue;
                if (!AllowsUppercaseLetters && char.IsUpper(c)) continue;
                if (!AllowsLowercaseLetters && char.IsLower(c)) continue;
                if (!AllowsSymbols && char.IsSymbol(c)) continue;
                if (!AllowsPunctuation && char.IsPunctuation(c)) continue;
                if (!AllowsWhitespace && char.IsWhiteSpace(c)) continue;

                sb.Append(c);
            }

            return sb.ToString();
        }

        public static TextFilter Filter(string text) => new TextFilter(text);
    }


    public static class TextFilterExtension
    {
        public static TextFilter Filter(this string text) => TextFilter.Filter(text);
    }
}
