using System;

namespace Simple.Brazilian.Validadores
{
    public static class PIS
    {
        public static bool IsValid(string pis)
        {
            throw new NotImplementedException();
        }
        /// <summary>
        /// Aplica a máscara de PIS ___._____.__._
        /// </summary>
        /// <param name="pis">Texto para aplicar a máscara</param>
        /// <returns>Texto com a máscara</returns>
        public static string Mask(string pis) => Formatadores.Texto.AplicaMascara(pis, "___._____.__._");
        /// <summary>
        /// Remove a máscara
        /// </summary>
        /// <param name="pis">Texto com a máscara aplicada</param>
        /// <returns>Texto com a máscara removida</returns>
        public static string Unmask(string pis) => Formatadores.Texto.RemoveMascara(pis);

    }
}
