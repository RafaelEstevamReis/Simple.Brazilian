using System;

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

            if (reverse)
            {
                int current = min;
                for (int i = sequence.Length - 1; i >= 0; i--)
                {
                    sequence[i] = current;
                    current++;
                    if (current > max) current = min;
                }
            }
            else
            {
                int current = min;
                for (int i = 0; i < sequence.Length; i++)
                {
                    sequence[i] = current;
                    current++;
                    if (current > max) current = min;
                }
            }

            // Sum
            int total = 0;
            for (int i = 0; i < chars.Length; i++)
            {
                total += (chars[i] - '0') * sequence[i];
            }
            return total;
        }
        /// <summary>
        /// Retorna a soma da multiplicação de sequencias geradas entre Min e Max
        /// </summary>
        public static int SumMultiplySequence(string text, int min, int max, bool reverse)
            => SumMultiplySequence(text.ToCharArray(), min, max, reverse);

        /// <summary>
        /// Executa cálculo do Mod11 com multiplicação por 10 no texto, retorna INT
        /// </summary>
        public static int CalculateMult10Mod11(string text, int min, int max)
        {
            // Este Mod11 não serve para codigos de barras, apenas documentos
            var soma = SumMultiplySequence(text, min, max, true);

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
            var soma = SumMultiplySequence(text, min, max, true);
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

        /// <summary>
        /// Executa cálculo no padrão 2121 em Mod10 no texto, retorna INT
        /// </summary>
        public static int Calculate2121Mod10IndividualDigits(string text)
        {
            if (string.IsNullOrEmpty(text))
            {
                throw new ArgumentException($"'{nameof(text)}' cannot be null or empty.", nameof(text));
            }

            int sum = 0;
            for (int i = 0; i < text.Length; i++)
            {
                // pega o indice de trás pra frente
                int idx = text.Length - i - 1;

                int digito = text[idx] - '0';
                if (digito < 0 || digito > 9) throw new FormatException($"'{nameof(text)}' deve conter apenas números");

                int somaLocal = digito * (2 - (i % 2));

                // Não tem como ser maior que 18 (2*9)
                if (somaLocal > 9)
                {
                    // Subtrai 9, porém vou deixar separado para ficar mais claro
                    somaLocal -= 10;
                    somaLocal += 1;
                }

                sum += somaLocal;
            }

            var dv = 10 - (sum % 10);
            if (dv == 10) return 0;
            return dv;
        }

        /// <summary>
        /// Executa cálculo no padrão 2121 em Mod10 no texto, retorna CHAR
        /// </summary>
        public static char Calculate2121Mod10IndividualDigitsChar(string text)
            => (char)(Calculate2121Mod10IndividualDigits(text) + '0');
    }

}
