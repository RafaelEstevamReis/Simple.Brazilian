using System;

namespace Simple.Brazilian.Validadores
{
    public static class CPF
    {
        public static bool IsValid(string cpf)
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
