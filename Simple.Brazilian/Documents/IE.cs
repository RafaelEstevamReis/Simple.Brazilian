using System;
using static Simple.Brazilian.Dados.Locais;

namespace Simple.Brazilian.Documents
{
    /// <summary>
    /// Validador de IE
    /// </summary>
    public static class IE
    {
        internal static bool IsValid(string ie)
        {
            throw new NotImplementedException();
        }
        internal static bool IsValid(string ie, UF uf)
        {
            throw new NotImplementedException();
        }
        /// <summary>
        /// Aplica a máscara de IE
        /// </summary>
        /// <param name="ie">Texto para aplicar a máscara</param>
        /// <param name="uf">Especifica qual UF deve ser usada para aplicar a máscara</param>
        /// <returns>Texto com a máscara</returns>
        public static string Mask(string ie, UF uf)
        {
            throw new NotImplementedException();
        }
        /// <summary>
        /// Remove a máscara
        /// </summary>
        /// <param name="cep">Texto com a máscara aplicada</param>
        /// <returns>Texto com a máscara removida</returns>
        public static string Unmask(string cep) => Formatters.Text.RemoveMascara(cep);

    }
}
