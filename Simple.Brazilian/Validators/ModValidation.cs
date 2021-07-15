using System;

namespace Simple.Brazilian.Validators
{
    /// <summary>
    /// Validação e dados com "Mod"
    /// </summary>
    public static class ModValidation
    {
        /// <summary>
        /// Gerador de sequências decrescentes MOD
        /// </summary>
        /// <param name="min">Menor valor</param>
        /// <param name="max">Maior valor</param>
        /// <param name="len">Quantidade de números a serem gerados</param>
        public static int[] GenerateReverseSequence(int min, int max, int len)
        {
            int[] arr = new int[len];
            int corrente = min;

            for (int i = len - 1; i >= 0; i--)
            {
                arr[i] = corrente;
                corrente++;

                if (corrente > max) corrente = min;
            }
            return arr;
        }
        /// <summary>
        /// Multiplica dois arrays e retorna a soma
        /// </summary>
        public static int SumMultiply(int[] arr1, int[] arr2)
        {
            if (arr1 is null) throw new ArgumentNullException(nameof(arr1));
            if (arr2 is null) throw new ArgumentNullException(nameof(arr2));

            if (arr1.Length != arr2.Length) throw new ArgumentException("Os comprimentos devem ser iguais");

            if (arr1.Length == 0) return 0;

            int total = 0;
            for (int i = 0; i < arr1.Length; i++)
            {
                total += arr1[i] * arr2[i];
            }
            return total;
        }
        /// <summary>
        /// Multiplica dois arrays e retorna a soma
        /// </summary>
        public static int SumMultiply(int[] arr1, char[] arr2)
        {
            if (arr1 is null) throw new ArgumentNullException(nameof(arr1));
            if (arr2 is null) throw new ArgumentNullException(nameof(arr2));

            if (arr1.Length != arr2.Length) throw new ArgumentException("Os comprimentos devem ser iguais");

            if (arr1.Length == 0) return 0;

            int total = 0;
            for (int i = 0; i < arr1.Length; i++)
            {
                total += arr1[i] * (arr2[i] - '0');
            }
            return total;
        }
        /// <summary>
        /// Executa cálculo do Mod11 com multiplicação por 10 no texto, retorna INT
        /// </summary>
        public static int CalculateMult10Mod11(string text, int min, int max)
        {
            // Este Mod11 não serve para codigos de barras, apenas documentos

            // Obtém a sequência que será multiplicada
            var sequencia = GenerateReverseSequence(min, max, text.Length);
            var chars = text.ToCharArray();
            // Executa a multiplicação
            var soma = SumMultiply(sequencia, chars);
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
            // Obtém a sequência que será multiplicada
            var sequencia = GenerateReverseSequence(min, max, text.Length);
            var chars = text.ToCharArray();
            // Executa a multiplicação
            var soma = SumMultiply(sequencia, chars);
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
        /// <param name="text">Texto a ser verificado</param>
        /// <param name="expectedLen">Comprimento eperado. 
        /// Será chamada remoção de máscara se o comprimento for maior do que o esperado
        /// </param>
        public static bool CheckDocumentMod1129(string text, int expectedLen)
        {
            if (text == null) return false;

            if (text.Length > expectedLen) text = Formatters.Text.RemoveMask(text);
            if (text.Length != expectedLen) return false;

            return CheckDocumentMod1129(text);
        }
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
