using System;
using System.Globalization;

namespace Simple.Brazilian.Formatters
{
    /// <summary>
    /// Formata números
    /// </summary>
    public class Numbers
    {
        /// <summary>
        /// CultureInfo padrão a ser utilizado
        /// </summary>
        public static CultureInfo DefaultCulture { get; }
        static Numbers()
        {
#if NETSTANDARD1_0
            DefaultCulture = new CultureInfo("pt-BR");
#else
            DefaultCulture = new CultureInfo("pt-BR", false);
#endif
        }
        
        /// <summary>
        /// Parseia um texto para Int32
        /// </summary>
        /// <param name="text">Texto a ser convertido</param>
        /// <param name="OnError">Valor a ser retornado em caso de falha</param>
        /// <returns>Número convertido, ou valor padrão</returns>
        public static int ToInt(string text, int? OnError = 0)
        {
            if (int.TryParse(text, NumberStyles.Any, DefaultCulture, out int value)) return value;
            return processError(OnError);
        }
        internal static double ToDouble(string text, double? OnError = 0)
        {
            throw new NotImplementedException();
        }
        internal static decimal ToDecimal(string text, decimal? OnError = 0)
        {
            throw new NotImplementedException();
        }
        /// <summary>
        /// Converte número em texto usando DefaultCulture
        /// </summary>
        /// <param name="value">Valor a ser convertido</param>
        /// <returns>Texto convertido</returns>
        public static string ToText(int value)
        {
            return Convert.ToString(value, DefaultCulture);
        }
        /// <summary>
        /// Converte número em texto usando DefaultCulture com a quantidade definida de casas decimais
        /// </summary>
        /// <param name="value">Valor a ser convertido</param>
        /// <param name="decimals">Casas decimais</param>
        /// <returns>Texto convertido</returns>
        public static string ToText(double value, int decimals = 2)
        {
            var rounded = abntRounding(value, decimals);
            return rounded.ToString($"N{decimals}", DefaultCulture);
        }
        /// <summary>
        /// Converte número em texto usando DefaultCulture com a quantidade definida de casas decimais
        /// </summary>
        /// <param name="value">Valor a ser convertido</param>
        /// <param name="decimals">Casas decimais</param>
        /// <returns>Texto convertido</returns>
        public static string ToText(decimal value, int decimals = 2)
        {
            var rounded = abntRounding(value, decimals);
            return rounded.ToString($"N{decimals}", DefaultCulture);
        }
        /// <summary>
        /// Converte número em texto monetário usando DefaultCulture com a quantidade definida de casas decimais
        /// </summary>
        /// <param name="value">Valor a ser convertido</param>
        /// <param name="decimals">Casas decimais</param>
        /// <returns>Texto convertido</returns>
        public static string ToBRL(decimal value, int decimals = 2)
        {
            var rounded = abntRounding(value, decimals);
            return rounded.ToString($"C{decimals}", DefaultCulture);
        }

        private static decimal abntRounding(decimal value, int decimals)
        {
            return Math.Round(value, decimals, MidpointRounding.ToEven);
        }
        private static double abntRounding(double value, int decimals)
        {
            return Math.Round(value, decimals, MidpointRounding.ToEven);
        }

        private static T processError<T>(T? value) where T : struct
        {
            if (value.HasValue) return value.Value;
            throw new FormatException();
        }
    }
}
