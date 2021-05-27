using System.Linq;

namespace Simple.Brazilian.Documents
{
    /// <summary>
    /// Validador de CPF
    /// </summary>
    public static class CPF
    {
        /// <summary>
        /// CPFs com dígitos repetidos são considerados inválidos, mesmo passando pelas verificações.
        /// </summary>
        private static readonly string[] InvalidCPFs = { 
            "11111111111",
            "22222222222",
            "33333333333",
            "44444444444",
            "55555555555",
            "66666666666",
            "77777777777",
            "88888888888",
            "99999999999",
            "00000000000"
        };

        /// <summary>
        /// Valida se um CPF é válido
        /// </summary>
        /// <param name="cpf">Um CPF não formatado (ex.: 55487565082)</param>
        /// <returns></returns>
        public static bool IsValid(string cpf)
        {
            if (string.IsNullOrEmpty(cpf) || cpf.Length != 11 || !IsDigitsOnly(cpf) || InvalidCPFs.Any(s => s == cpf))
                return false;

            int firstDigit = cpf[9] - '0';
            int secondDigit = cpf[10] - '0';

            int firstSum = 0;
            int secondSum = 0;
            int countdown = 11;

            foreach(var digit in cpf.Substring(0, 9))
            {
                int intValue = digit - '0';
                firstSum += intValue * (countdown - 1);
                secondSum += intValue * countdown;
                countdown -= 1;
            }
            secondSum += 2 * firstDigit;

            int firstDigitVerification = (firstSum * 10) % 11;
            int secondDigitVerification = (secondSum * 10) % 11;

            if (firstDigitVerification == 10)
                firstDigitVerification = 0;
            if (secondDigitVerification == 10)
                secondDigitVerification = 0;

            if (firstDigitVerification != firstDigit || secondDigitVerification != secondDigit)
                return false;

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

        private static bool IsDigitsOnly(string input)
        {
            foreach (var digit in input.ToCharArray())
            {
                if (!char.IsDigit(digit))
                    return false;
            }
            return true;
        }
    }
}
