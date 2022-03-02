using System;

namespace Simple.Brazilian.Documents
{
    /// <summary>
    /// Formtador de Telefone
    /// </summary>
    public static class Telefone
    {
        /// <summary>
        /// Aplica a máscara de Telefone
        /// </summary>
        /// <param name="telefone">Texto para aplicar a máscara</param>
        /// <returns>Texto com a máscara</returns>
        public static string Mask(string telefone)
        {
            string mask = "(__) ____-____";
            if(telefone != null && telefone.Length == 11) mask = "(__)_.____-____";

            return Formatters.Text.ApplyMask(telefone, mask);
        }

        /// <summary>
        /// Remove a máscara
        /// </summary>
        /// <param name="telefone">Texto com a máscara aplicada</param>
        /// <returns>Texto com a máscara removida</returns>
        public static string Unmask(string telefone) => Formatters.Text.RemoveMask(telefone);

    }
}
