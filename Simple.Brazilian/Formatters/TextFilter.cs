using System;
using System.Text;

namespace Simple.Brazilian.Formatters
{
    /// <summary>
    /// Executa filtragem de textos
    /// </summary>
    public class TextFilter
    {
        private readonly string text;
        /// <summary>
        /// Define se números são permitidos durante a filtragem
        /// </summary>
        public bool AllowsNumbers { get; set; } = false;
        /// <summary>
        /// Define se letras maiúsculas são permitidas durante a filtragem
        /// </summary>
        public bool AllowsUppercaseLetters { get; set; } = false;
        /// <summary>
        /// Define se letras minúsculas são permitidas durante a filtragem
        /// </summary>
        public bool AllowsLowercaseLetters { get; set; } = false;
        /// <summary>
        /// Define se símbolos são permitidos durante a filtragem
        /// </summary>
        public bool AllowsSymbols { get; set; } = false;
        /// <summary>
        /// Define se pontuações são permitidas durante a filtragem
        /// </summary>
        public bool AllowsPunctuation { get; set; } = false;
        /// <summary>
        /// Define se espaços e whitespaces são permitidos durante a filtragem
        /// </summary>
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

        /// <summary>
        /// Remove todos os caracteres
        /// </summary>
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
        /// <summary>
        /// Permite todos os caracteres
        /// </summary>
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

        /// <summary>
        /// Permite números
        /// </summary>
        public TextFilter AllowNumbers()
        {
            AllowsNumbers = true;
            return this;
        }
        /// <summary>
        /// Permite maiúsculas
        /// </summary>
        public TextFilter AllowUppercaseLetters()
        {
            AllowsUppercaseLetters = true;
            return this;
        }
        /// <summary>
        /// Permite minúsculas
        /// </summary>
        public TextFilter AllowLowercaseLetters()
        {
            AllowsLowercaseLetters = true;
            return this;
        }
        /// <summary>
        /// Permite símbolos
        /// </summary>
        public TextFilter AllowSymbols()
        {
            AllowsSymbols = true;
            return this;
        }
        /// <summary>
        /// Permite pontuações
        /// </summary>
        public TextFilter AllowPunctuation()
        {
            AllowsPunctuation= true;
            return this;
        }
        /// <summary>
        /// Permite espaços e whitespaces
        /// </summary>
        public TextFilter AllowWhitespace()
        {
            AllowsWhitespace = true;
            return this;
        }

        /// <summary>
        /// Remove números
        /// </summary>
        public TextFilter DenyNumbers()
        {
            AllowsNumbers = false;
            return this;
        }
        /// <summary>
        /// Remove maiúsculas
        /// </summary>
        public TextFilter DenyUppercaseLetters()
        {
            AllowsUppercaseLetters = false;
            return this;
        }
        /// <summary>
        /// Remove minúsculas
        /// </summary>
        public TextFilter DenyLowercaseLetters()
        {
            AllowsLowercaseLetters = false;
            return this;
        }
        /// <summary>
        /// Remove símbolos
        /// </summary>
        public TextFilter DenySymbols()
        {
            AllowsSymbols = false;
            return this;
        }
        /// <summary>
        /// Remove pontuações
        /// </summary>
        /// <returns></returns>
        public TextFilter DenyPunctuation()
        {
            AllowsPunctuation = false;
            return this;
        }
        /// <summary>
        /// Remove espaços e whitespaces
        /// </summary>
        public TextFilter DenyWhitespace()
        {
            AllowsWhitespace = false;
            return this;
        }

        /// <summary>
        /// Executa filtro
        /// </summary>
        /// <returns>Retorna texto com filtros aplicados</returns>
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
        
        /// <summary>
        /// Inicializa filtro de texto
        /// </summary>
        public static TextFilter Filter(string text) => new TextFilter(text);
    }

    /// <summary>
    /// Extensão de filtro de texto
    /// </summary>
    public static class TextFilterExtension
    {
        /// <summary>
        /// Executa filtragem de textos
        /// </summary>
        /// <param name="text">Texto a ser filtrado</param>
        /// <returns>Chaining de filtragem de texto</returns>
        public static TextFilter Filter(this string text) => TextFilter.Filter(text);
    }
}
