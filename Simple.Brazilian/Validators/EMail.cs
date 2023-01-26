using System.Text.RegularExpressions;

namespace Simple.Brazilian.Validators
{
    /// <summary>
    /// Validação de endereços de e-mail
    /// </summary>
    public static class EMail
    {
        // Usa a validação do HTML5
        // Não usa a RFC5322
        private static readonly string regexEmail = @"^[a-zA-Z0-9.!#$%&'*+\/=?^_`{|}~-]+@[a-zA-Z0-9](?:[a-zA-Z0-9-]{0,61}[a-zA-Z0-9])?(?:\.[a-zA-Z0-9](?:[a-zA-Z0-9-]{0,61}[a-zA-Z0-9])?)*$";
        private static readonly Regex rx = new Regex(regexEmail);
        /// <summary>
        /// Valida se o texto é uma e-mail válido
        /// </summary>
        public static bool IsValid(string email)
        {
            // a@a.co
            if (email.Length < 6) return false;
            // Impede ataque na validação do Regex
            if (email.Length > 256) return false;
            
            if (!email.Contains("@")) return false;

            return rx.IsMatch(email);
        }

    }
}
