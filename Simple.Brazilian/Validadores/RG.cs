using System;

namespace Simple.Brazilian.Validadores
{
    public static class RG
    {
        public static bool IsValid(string rg)
        {
            throw new NotImplementedException();
        }
        /// <summary>
        /// Aplica a máscara de RG
        /// </summary>
        /// <param name="rg">Texto para aplicar a máscara</param>
        /// <returns>Texto com a máscara</returns>
        public static string Mask(string rg)
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
