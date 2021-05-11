using System;

namespace Simple.Brazilian.Documentos
{
    /// <summary>
    /// Validador de CPF
    /// </summary>
    public static class CPF
    {
        internal static bool IsValid(string cpf)
        {
            throw new NotImplementedException();
        }
        /// <summary>
        /// Aplica a máscara de CPF ___.___.___-__
        /// </summary>
        /// <param name="cpf">Texto para aplicar a máscara</param>
        /// <returns>Texto com a máscara</returns>
        public static string Mask(string cpf) => Formatadores.Texto.AplicaMascara(cpf, "___.___.___-__");
        /// <summary>
        /// Remove a máscara
        /// </summary>
        /// <param name="cpf">Texto com a máscara aplicada</param>
        /// <returns>Texto com a máscara removida</returns>
        public static string Unmask(string cpf) => Formatadores.Texto.RemoveMascara(cpf);

    }
}
