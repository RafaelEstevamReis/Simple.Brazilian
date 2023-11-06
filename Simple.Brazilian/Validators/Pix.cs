namespace Simple.Brazilian.Validators;

using Simple.Brazilian.Documents;
using System.Text.RegularExpressions;

/// <summary>
/// Validação de Chaves PIX
/// </summary>
public static class Pix
{
    private static readonly string regexGuid = @"^([0-9A-Fa-f]{8}[-][0-9A-Fa-f]{4}[-][0-9A-Fa-f]{4}[-][0-9A-Fa-f]{4}[-][0-9A-Fa-f]{12})$";
    private static readonly Regex rxGuid = new Regex(regexGuid);

    /// <summary>
    /// Valida se o texto é uma das Chaves PIX válidas
    /// </summary>
    public static bool IsValid(string chave)
    {
        if (string.IsNullOrEmpty(chave)) return false;
        
        if (chave.StartsWith("+")) return IsValid_Celular(chave);

        if (chave.Contains("@")) return IsValid_Email(chave);
        if (chave.Contains("-")) return IsValid_Aleatoria(chave);
        // Apenas se não for email
        if (chave.Length == 11) return IsValid_CPF(chave);
        if (chave.Length == 14) return IsValid_CNPJ(chave);

        return false;
    }

    /// <summary>
    /// Valida se o texto é uma Chave PIX de CPF
    /// Exemplo do Manual PIX: 12345678900 (Atenção, o CPF do manual é inválido)
    /// </summary>
    public static bool IsValid_CPF(string chaveCPF)
    {
        if(string.IsNullOrEmpty(chaveCPF)) return false;
        // A chave não pode vir com máscara
        if (chaveCPF.Length != 11) return false;
        return CPF.IsValid(chaveCPF);
    }
    /// <summary>
    /// Valida se o texto é uma Chave PIX de CNPJ
    /// Exemplo do Manual PIX: 00038166000105
    /// </summary>
    public static bool IsValid_CNPJ(string chaveCNPJ)
    {
        if (string.IsNullOrEmpty(chaveCNPJ)) return false;
        // A chave não pode vir com máscara
        if (chaveCNPJ.Length != 14) return false;
        return CNPJ.IsValid(chaveCNPJ);
    }
    /// <summary>
    /// Valida se o texto é uma Chave PIX de Celular
    /// Exemplo do Manual PIX: +5561912345678
    /// </summary>
    public static bool IsValid_Celular(string chaveCelular)
    {
        if (string.IsNullOrEmpty(chaveCelular)) return false;
        // A chave não pode vir com máscara (exceto o "+")
        if (chaveCelular[0] != '+') return false;
        // +55 00 0.0000-0000
        return chaveCelular.Length == 14;
    }
    /// <summary>
    /// Valida se o texto é uma Chave PIX de e-mail
    /// Exemplo do Manual PIX: fulano_da_silva.recebedor@example.com
    /// </summary>
    public static bool IsValid_Email(string chaveEmail)
    {
        if (string.IsNullOrEmpty(chaveEmail)) return false;
        // Chave Pix não pode ter mais de 77 caracteres
        if (chaveEmail.Length > 77) return false;
        return EMail.IsValid(chaveEmail);
    }
    /// <summary>
    /// Valida se o texto é uma Chave PIX Aleatória. 
    /// Exemplo do Manual PIX: 123e4567-e12b-12d1-a456-426655440000
    /// </summary>
    public static bool IsValid_Aleatoria(string chaveAleatoria)
    {
        if (string.IsNullOrEmpty(chaveAleatoria)) return false;
        // Chave Pix não pode ter mais de 77 caracteres
        // Já fica como limitador do Regex
        if (chaveAleatoria.Length > 77) return false;
        if (!chaveAleatoria.Contains("-")) return false;
        // 123e4567-e12b-12d1-a456-426655440000
        return rxGuid.IsMatch(chaveAleatoria);
    }
}
