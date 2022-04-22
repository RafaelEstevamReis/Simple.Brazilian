using System;

namespace Simple.Brazilian.Documents
{
    /// <summary>
    /// Validador de CPF
    /// </summary>
    public static class CPF
    {
        /// <summary>
        /// Valida se um CPF é válido
        /// </summary>
        /// <param name="cpf">Um CPF com ou sem máscara (ex.: 55487565082 ou 554.875.650-82)</param>
        /// <returns>True se o CPF for válido, False se não</returns>
        public static bool IsValid(string cpf)
        {
            /* Comparativo entre a versão corrente e a original (d803ac3)
            |      Method   |      Mean |    Error |   StdDev |  Gen 0 | Gen 1 | Gen 2 | Allocated |
            |-------------- |----------:|---------:|---------:|-------:|------:|------:|----------:|
            | ValidaCPF     |  12.30 ns | 0.097 ns | 0.081 ns |      - |     - |     - |         - |
            | ValidaCPF_Org | 196.09 ns | 1.214 ns | 1.136 ns | 0.0801 |     - |     - |     168 B |
             */

            if (string.IsNullOrEmpty(cpf))
                return false;

            // Se for maior, retira a máscara
            if (cpf.Length > 11) cpf = Unmask(cpf);
            if (cpf.Length != 11) return false;

            int firstDigit = cpf[9] - '0';
            int secondDigit = cpf[10] - '0';

            if (!CalculateDigits(cpf.Substring(0, 9), out int firstDigitVerification, out int secondDigitVerification))
                return false;

            if (firstDigitVerification != firstDigit || secondDigitVerification != secondDigit)
                return false;

            // Não é válido se qualquer um dos dígitos for diferente
            for (int i = 1; i < 11; i++)
            {
                // Se algum for diferente, o CPF é válido
                if (cpf[i] != cpf[0]) return true;
            }

            return false;
        }
        /// <summary>
        /// Completa um CPF parcial com os dígitos verificadores
        /// </summary>
        /// <param name="partialCPF">CPF parcial com 9 dígitos a ser completado</param>
        /// <returns>CPF válido</returns>
        /// <exception cref="ArgumentNullException">Parâmetro não deve ser NULL</exception>
        /// <exception cref="ArgumentException">Parâmetro informado é inválido</exception>
        public static string CompleteWithDigitsCPF(string partialCPF)
        {
            if (partialCPF is null) throw new ArgumentNullException(nameof(partialCPF));
            if(partialCPF.Length != 9) throw new ArgumentException($"{nameof(partialCPF)} deve ser composto pelos 9 dígitos iniciais");

            bool valid = CalculateDigits(partialCPF, out int d1, out int d2);
            if(!valid) throw new ArgumentException($"{nameof(partialCPF)} é inválido");

            return $"{partialCPF}{d1}{d2}";
        }

        private static bool CalculateDigits(string cpf, out int firstDigitVerification, out int secondDigitVerification)
        {
            firstDigitVerification = -1;
            secondDigitVerification = -1;

            // Vazio ou nulo
            if (string.IsNullOrEmpty(cpf))
                return false;

            if (cpf.Length != 9)
                return false;

            int firstSum = 0;
            int secondSum = 0;
            int countdown = 11;
            for (int i = 0; i < 9; i++)
            {
                int intValue = cpf[i] - '0';
                // Não é número ?
                if (intValue < 0 || intValue > 9) return false;

                firstSum += intValue * (countdown - 1);
                secondSum += intValue * countdown;
                countdown -= 1;
            }

            firstDigitVerification = (firstSum * 10) % 11;


            if (firstDigitVerification == 10)
                firstDigitVerification = 0;

            secondSum += 2 * firstDigitVerification;
            secondDigitVerification = (secondSum * 10) % 11;

            if (secondDigitVerification == 10)
                secondDigitVerification = 0;

            return true;
        }


        /// <summary>
        /// Aplica a máscara de CPF ___.___.___-__
        /// </summary>
        /// <param name="cpf">Texto para aplicar a máscara</param>
        /// <returns>Texto com a máscara</returns>
        public static string Mask(string cpf) => Formatters.Text.ApplyMask(cpf, "___.___.___-__");
        /// <summary>
        /// Remove a máscara
        /// </summary>
        /// <param name="cpf">Texto com a máscara aplicada</param>
        /// <returns>Texto com a máscara removida</returns>
        public static string Unmask(string cpf) => Formatters.Text.RemoveMask(cpf);
    }
}
