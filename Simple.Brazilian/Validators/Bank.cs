namespace Simple.Brazilian.Validators;

using System.Linq;
using System.Text.RegularExpressions;

/// <summary>
/// Validações de dados bancários
/// </summary>
public static class Bank
{
    private static readonly string regexAgenciaComDigito = "^([0-9]{1,5})(-[A-Z0-9]{1,2}){0,1}$";
    private static readonly Regex rxAgencia = new Regex(regexAgenciaComDigito);

    private static readonly string regexContaComDigito = "^([0-9]{1,12})(-[A-Z0-9]{1,2}){0,1}$";
    private static readonly Regex rxConta = new Regex(regexContaComDigito);

    /// <summary>
    /// Validação simples de número do banco (COMPE), sem dígito
    /// </summary>
    /// <param name="bankNumber">Número do banco</param>
    public static bool IsBankNumberValid(string bankNumber)
    {
        if (bankNumber is null) return false;
        if (bankNumber.Length != 3) return false;

        if (bankNumber.Any(c => c < '0' || c > '9')) return false;
        return true;
    }

    /// <summary>
    /// Validação simples de número da agência, sem dígito
    /// </summary>
    /// <param name="agencyNumber">Número do banco</param>
    public static bool IsAgencyValid(string agencyNumber)
    {
        if (agencyNumber is null) return false;
        if (agencyNumber.Length < 1) return false;
        if (agencyNumber.Length > 5) return false;

        if (agencyNumber.Any(c => c < '0' || c > '9')) return false;
        return true;
    }

    /// <summary>
    /// Validação simples de número da conta, sem dígito
    /// </summary>
    /// <param name="accountNumber">Número do banco</param>
    public static bool IsAccountValid(string accountNumber)
    {
        if (accountNumber is null) return false;
        if (accountNumber.Length < 1) return false;
        if (accountNumber.Length > 12) return false;

        if (accountNumber.Any(c => c < '0' || c > '9')) return false;
        return true;
    }

    /// <summary>
    /// Validação simples de de dados bancários com digito. 
    /// Não é feita a checagem do digito verificador.
    /// </summary>
    /// <param name="bankNumber">Código do Banco (COMPE)</param>
    /// <param name="agencyWithDigit">Número da agência</param>
    /// <param name="accountWithDigit">Número da Conta</param>
    public static bool IsValid(string bankNumber, string agencyWithDigit, string accountWithDigit)
    {
        if (string.IsNullOrEmpty(bankNumber)) return false;
        if (string.IsNullOrEmpty(agencyWithDigit)) return false;
        if (string.IsNullOrEmpty(accountWithDigit)) return false;

        if (!IsBankNumberValid(bankNumber)) return false;

        // Regex é vulnerável contra inputs muito longos,
        // vou limitar antes de chamar o Match
        if (agencyWithDigit.Length > 20) return false;
        if (accountWithDigit.Length > 20) return false;

        if (!rxAgencia.IsMatch(agencyWithDigit)) return false;
        if (!rxConta.IsMatch(accountWithDigit)) return false;

        return true;
    }

}
