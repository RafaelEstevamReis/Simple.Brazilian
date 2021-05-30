using System;
using System.Globalization;

namespace Simple.Brazilian.Formatters
{
    public class Numbers
    {
        public static CultureInfo DefaultCulture { get; }
        static Numbers()
        {
            DefaultCulture = new CultureInfo("pt-BR", false);
        }

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

        public static string ToText(int value)
        {
            return Convert.ToString(value, DefaultCulture);
        }
        public static string ToText(double value, int decimals = 2)
        {
            var rounded = abntRounding(value, decimals);
            return rounded.ToString($"N{decimals}", DefaultCulture);
        }
        public static string ToText(decimal value, int decimals = 2)
        {
            var rounded = abntRounding(value, decimals);
            return rounded.ToString($"N{decimals}", DefaultCulture);
        }
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
