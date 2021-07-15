using System;
using System.Linq;

namespace Simple.Brazilian.Validators
{
    /// <summary>
    /// Validação e dados com "Mod"
    /// </summary>
    public static class ModValidation
    {
        /// <summary>
        /// Retorna a soma da multiplicação de sequencias geradas entre Min e Max
        /// </summary>
        public static int SumMultiplySequence(char[] chars, int min, int max, bool reverse)
        {
            // Generate sequence
            int[] sequence = new int[chars.Length];
            int current = min;
            for (int i = 0; i < sequence.Length; i++)
            {
                sequence[i] = current;
                current++;
                if (current > max) current = min;
            }
            // Reverse
            if (reverse) Array.Reverse(sequence);
            // Sum
            int total = 0;
            for (int i = 0; i < chars.Length; i++)
            {
                total += (chars[i] - '0') * sequence[i];
            }
            return total;
        }

        /// <summary>
        /// Executa cálculo do Mod11 com multiplicação por 10 no texto, retorna INT
        /// </summary>
        public static int CalculateMult10Mod11(string text, int min, int max)
        {
            // Este Mod11 não serve para codigos de barras, apenas documentos
            var soma = SumMultiplySequence(text.ToCharArray(), min, max, true);

            // O valor deve calculado Mod 11 e então subtraído de 11
            int resto = (10 * soma) % 11;
            // Para códigos de barras, o resto prefere 1
            // para documentos o resto prefere 0
            if (resto == 10) return 0;

            return resto;
        }
        /// <summary>
        /// Executa cálculo do Mod11 no texto, retorna INT
        /// </summary>
        public static int CalculateMod11(string text, int min, int max)
        {
            var soma = SumMultiplySequence(text.ToCharArray(), min, max, true);
            // O valor deve calculado Mod 11 e então subtraído de 11
            int resto = soma % 11;
            // Para códigos de barras, o resto prefere 1
            // para documentos o resto prefere 0
            if (resto == 10) return 0;

            return resto;
        }
        /// <summary>
        /// Executa cálculo do Mod11 com multiplicação por 10 no texto, retorna CHAR
        /// </summary>
        public static char CalculateMult10Mod11Char(string text, int min, int max)
            => (char)('0' + CalculateMult10Mod11(text, min, max));

        /// <summary>
        /// Executa cálculo do Mod11 no texto, retorna CHAR
        /// </summary>
        public static char CalculateMod11Char(string text, int min, int max)
            => (char)('0' + CalculateMod11(text, min, max));

        /// <summary>
        /// Executa verificação de documento com Mod11, valores de 9 a 2
        /// </summary>
        public static bool CheckDocumentMod1129(string text)
        {
            if (text == null) return false;
            if (text.Length < 2) return false;

            char orgDv = text[text.Length - 1];
            var calcDv = CalculateMult10Mod11Char(text.Substring(0, text.Length - 1), 2, 9);

            return orgDv == calcDv;
        }
    }
}
