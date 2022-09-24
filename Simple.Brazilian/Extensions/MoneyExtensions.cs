namespace Simple.Brazilian
{
    /// <summary>
    /// Extensões para valores monetários
    /// </summary>
    public static class MoneyExtensions
    {
        /// <summary>
        /// Converte número em texto monetário usando Formatters.Numbers.ToBRL com casas decimais especificadas
        /// </summary>
        /// <param name="value">Valor a ser convertido</param>
        /// <param name="decimals">Casas decimais</param>
        /// <returns>Texto convertido</returns>
        public static string ToBRL(decimal value, int decimals = 2)
            => Formatters.Numbers.ToBRL(value, decimals);

    }
}
