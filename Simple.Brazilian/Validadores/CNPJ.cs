using System;

namespace Simple.Brazilian.Validadores
{
    public static class CNPJ
    {
        public static bool IsValid(string cnpj)
        {
            throw new NotImplementedException();
        }
        /// <summary>
        /// Aplica a máscara de CNPJ __.___.___/____-__
        /// </summary>
        /// <param name="cnpj">Texto para aplicar a máscara</param>
        /// <returns>Texto com a máscara</returns>
        public static string Mask(string cnpj) => Formatadores.Texto.AplicaMascara(cnpj, "__.___.___/____-__");
        /// <summary>
        /// Remove a máscara
        /// </summary>
        /// <param name="cnpj">Texto com a máscara aplicada</param>
        /// <returns>Texto com a máscara removida</returns>
        public static string Unmask(string cnpj) => Formatadores.Texto.RemoveMascara(cnpj);
        
    }
}
