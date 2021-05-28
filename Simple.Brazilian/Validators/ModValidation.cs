using System;

namespace Simple.Brazilian.Validators
{
    public static class ModValidation
    {
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

        public static int CalculateMod11(string text, int min, int max)
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
        public static char CalculateMod11Char(string text, int min, int max)
            => (char)('0' + CalculateMod11(text, min, max));
    }
}
