using System;

namespace Simple.Brazilian.Documentos
{
    /// <summary>
    /// Validador de RG
    /// </summary>
    public static class RG
    {
        internal static bool IsValid(string rg)
        {
            throw new NotImplementedException();
        }
        /// <summary>
        /// Aplica a máscara de RG
        /// </summary>
        /// <param name="rg">Texto para aplicar a máscara</param>
        /// <returns>Texto com a máscara</returns>
        internal static string Mask(string rg)
        {
            throw new NotImplementedException();
        }
        /// <summary>
        /// Remove a máscara
        /// </summary>
        /// <param name="rg">Texto com a máscara aplicada</param>
        /// <returns>Texto com a máscara removida</returns>
        public static string Unmask(string rg) => Formatadores.Texto.RemoveMascara(rg);

    }
}
