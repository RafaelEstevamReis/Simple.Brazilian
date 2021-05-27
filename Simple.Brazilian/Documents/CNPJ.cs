using System;

namespace Simple.Brazilian.Documents
{
    /// <summary>
    /// Validador de CNPJ
    /// </summary>
    public static class CNPJ
    {
        /// <summary>
        /// Executa a validação de um CNPJ
        /// com ou sem máscara
        /// </summary>
        /// <param name="cnpj">CNPJ a ser verificado</param>
        /// <returns>True se o CNPJ é válido de acordo com o cálculo do Dígito Verificador;
        /// False senão</returns>
        public static bool IsValid(string cnpj)
        {
            if (string.IsNullOrEmpty(cnpj)) return false;
            //A validação é feita em duas estapas
            //A primeira etapa precisamos retirar os dois últimos
            //digitos que no caso são os digitos verificadores
            //e em seguida multiplicamos pelo primeiro algorismo
            //e depois soma o total das multiplicações.
            //Na segunda etapa adicionaremos o resultado da primeira etapa
            // para fazer o cálculo, da mesma forma teremos e o resultado
            //e a conclusão.

            // Definindo os algorismos para o cálculo
            int[] numMultiplier1 = new int[12]
            { 5, 4, 3, 2, 9, 8, 7, 6, 5, 4, 3, 2 };
            int[] numMultiplier2 = new int[13]
            { 6, 5, 4, 3, 2, 9, 8, 7, 6, 5, 4, 3, 2 };

            // Checa comprimento
            if (cnpj.Length > 14)
            {
                cnpj = Unmask(cnpj);
            }
            // E já descarta
            if (cnpj.Length != 14) return false;

            // Primeira etapa do cálculo
            string auxCNPJ = cnpj.Substring(0, 12);
            int result = 0;

            for (int i = 0; i < 12; i++)
            {
                result += int.Parse(auxCNPJ[i].ToString()) * numMultiplier1[i];
            }

            int resto = (result % 11);

            if (resto < 2) resto = 0;
            else resto = 11 - resto;

            //Segunda etapa do do cáculo
            auxCNPJ += resto;
            result = 0;

            for (int i = 0; i < 13; i++)
            {
                result += int.Parse(auxCNPJ[i].ToString()) * numMultiplier2[i];
            }

            resto = (result % 11);

            if (resto < 2) resto = 0;
            else resto = 11 - resto;

            auxCNPJ += resto;
            
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
