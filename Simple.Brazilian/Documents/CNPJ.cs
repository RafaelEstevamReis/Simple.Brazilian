using System;

namespace Simple.Brazilian.Documents
{
    /// <summary>
    /// Validador de CNPJ
    /// </summary>
    public static class CNPJ
    {
        /// <summary>
        /// Valida CNPJ
        /// </summary>
        /// <param name="cnpj"></param>
        /// <returns></returns>
        public static bool IsValid(string cnpj)
        {
            int[] numMultiplier1 = new int[12]
            { 5, 4, 3, 2, 9, 8, 7, 6, 5, 4, 3, 2 };
            int[] numMultiplier2 = new int[13]
            { 6, 5, 4, 3, 2, 9, 8, 7, 6, 5, 4, 3, 2 };

            cnpj = Unmask(cnpj);

            if (cnpj.Length != 14) return false;

            string auxCNPJ = cnpj.Substring(0, 12);

            int result = 0;

            for (int i = 0; i < 12; i++)
            {
                result += int.Parse(auxCNPJ[i].ToString()) * numMultiplier1[i];
            }

            int resto = (result % 11);

            if (resto < 2) resto = 0;
            else resto = 11 - resto;

            auxCNPJ = auxCNPJ + resto;
            string digitoV = resto.ToString();
            result = 0;

            for (int i = 0; i < 13; i++)
            {
                result += int.Parse(auxCNPJ[i].ToString()) * numMultiplier2[i];
            }

            resto = (result % 11);

            if (resto < 2) resto = 0;
            else resto = 11 - resto;

            auxCNPJ = auxCNPJ + resto;

            return auxCNPJ == cnpj;

        }









        /// <summary>
        /// Aplica a máscara de CNPJ __.___.___/____-__
        /// </summary>
        /// <param name="cnpj">Texto para aplicar a máscara</param>
        /// <returns>Texto com a máscara</returns>
        public static string Mask(string cnpj) => Formatters.Text.ApplyMask(cnpj, "__.___.___/____-__");
        /// <summary>
        /// Remove a máscara
        /// </summary>
        /// <param name="cnpj">Texto com a máscara aplicada</param>
        /// <returns>Texto com a máscara removida</returns>
        public static string Unmask(string cnpj) => Formatters.Text.RemoveMask(cnpj);

    }
}
