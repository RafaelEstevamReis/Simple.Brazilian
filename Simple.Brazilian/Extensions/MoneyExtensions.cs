namespace Simple.Brazilian
{
    public static class MoneyExtensions
    {
        /// <summary>
        /// Converte número em texto monetário usando Formatters.Numbers.ToBRL com duas casas decimais
        /// </summary>
        /// <param name="value">Valor a ser convertido</param>
        /// <returns>Texto convertido</returns>
        public static string ToBRL(decimal value)
            => Formatters.Numbers.ToBRL(value);

    }
}
