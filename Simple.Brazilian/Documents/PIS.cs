namespace Simple.Brazilian.Documents
{
    /// <summary>
    /// Validador de PIS
    /// </summary>
    public static class PIS
    {
        /// <summary>
        /// Executa a validação de um PIS
        /// com ou sem máscara
        /// </summary>
        /// <param name="pis">PIS a ser verificado</param>
        /// <returns>True se o PIS é válido de acordo com o cálculo do Dígito Verificador</returns>
        public static bool IsValid(string pis)
        {
            if (string.IsNullOrEmpty(pis)) return false;

            if (pis.Length > 11) pis = Unmask(pis);
            if (pis.Length != 11) return false;

            return Validators.ModValidation.CheckDocumentMod1129(pis);
        }
        /// <summary>
        /// Aplica a máscara de PIS ___._____.__._
        /// </summary>
        /// <param name="pis">Texto para aplicar a máscara</param>
        /// <returns>Texto com a máscara</returns>
        public static string Mask(string pis) => Formatters.Text.ApplyMask(pis, "___._____.__._");
        /// <summary>
        /// Remove a máscara
        /// </summary>
        /// <param name="pis">Texto com a máscara aplicada</param>
        /// <returns>Texto com a máscara removida</returns>
        public static string Unmask(string pis) => Formatters.Text.RemoveMask(pis);

    }
}
