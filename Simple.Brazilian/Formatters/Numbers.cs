using System;
using System.Globalization;
using System.Text;

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
        /// <exception cref="FormatException">Lança FormatException caso não seja possível a conversão e OnError seja NULL</exception>
        public static int ToInt(string text, int? OnError = 0)
        {
            if (int.TryParse(text, NumberStyles.Any, DefaultCulture, out int value)) return value;
            return processError(OnError);
        }
        /// <summary>
        /// Parseia um texto para Double
        /// </summary>
        /// <param name="text">Texto a ser convertido</param>
        /// <param name="OnError">Valor a ser retornado em caso de falha</param>
        /// <returns>Número convertido, ou valor padrão</returns>
        /// <exception cref="FormatException">Lança FormatException caso não seja possível a conversão e OnError seja NULL</exception>
        public static double ToDouble(string text, double? OnError = 0)
        {
            if (double.TryParse(text, NumberStyles.Any, DefaultCulture, out double value)) return value;
            return processError(OnError);
        }
        /// <summary>
        /// Parseia um texto para Decimal
        /// </summary>
        /// <param name="text">Texto a ser convertido</param>
        /// <param name="OnError">Valor a ser retornado em caso de falha</param>
        /// <returns>Número convertido, ou valor padrão</returns>
        /// <exception cref="FormatException">Lança FormatException caso não seja possível a conversão e OnError seja NULL</exception>
        public static decimal ToDecimal(string text, decimal? OnError = 0)
        {
            if (decimal.TryParse(text, NumberStyles.Any, DefaultCulture, out decimal value)) return value;
            return processError(OnError);
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

        //
        // Faz conversão tentando ser tolerante à qualquer cultura
        public static decimal ConvertFromUnkown(string text, decimal? OnError = 0)
        {
            // Tolerar o máximo de formatos
            // Será sempre considerado que, em caso de mais de um símbolo,
            // o último será o separador decimal

            int posComa = -1;
            int posPoint = -1;
            StringBuilder sb = new StringBuilder();
            for (int i = 0; i < text.Length; i++)
            {
                if (text[i] == ',')
                {
                    sb.Append(text[i]);
                    posComa = i; // último
                }
                else if (text[i] == '.')
                {
                    sb.Append(text[i]);
                    posPoint = i; // último
                }
                else if (text[i] == ' ') sb.Append(text[i]);
                else if (text[i] == '-') sb.Append(text[i]);
                else if (text[i] == '\r') sb.Append(text[i]);
                else if (text[i] == '\n') sb.Append(text[i]);
                else if (text[i] >= '0' && text[i] <= '9') sb.Append(text[i]);
            }
            string limpo = sb.ToString().Trim();

            // Converte para InvariantCulture
            if (posPoint == -1 && posComa >= 0)
            {
                // Caso especial "$1,900"
                if (posComa == limpo.Length - 3) limpo = limpo.Replace(",", "");
                else limpo = limpo.Replace(",", ".");
            }
            else if (posPoint >= 0 && posComa >= 0)
            {
                if (posPoint < posComa)
                {
                    limpo = limpo.Replace(".", "");
                    limpo = limpo.Replace(",", ".");
                }
                else
                {
                    limpo = limpo.Replace(",", "");
                }
            }

            // Trata como InvariantCulture
            if (decimal.TryParse(limpo, NumberStyles.Any, CultureInfo.InvariantCulture, out decimal value)) return value;
            return processError(OnError);
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
