namespace Simple.Brazilian.Validators;

using System;

/// <summary>
/// Classe para funções de validação de boletos bancários
/// </summary>
public static class Boleto
{
    private static readonly DateTime DATA_BASE = new DateTime(1997, 10, 07);

    /// <summary>
    /// Executa o calculo do digito verificador para Linha digitável, 
    /// Nosso Número, Seu Número e outros que são padrão 2121 Mod 10
    /// com dígitos individuais
    /// </summary>
    /// <returns>int DigitoVerificador</returns>
    public static char CalculateDV_Itau(string texto)
        => ModValidation.Calculate2121Mod10IndividualDigitsChar(texto);

    /// <summary>
    /// Executa o cálculo do Fator de Vencimento com retorno em texto com 4 dígitos
    /// </summary>
    /// <param name="dataVencimento">Data de vencimento do boleto</param>
    /// <returns>Fator de vencimento com 4 dígitos</returns>
    public static string CalculateDueDateFactor_Text(DateTime dataVencimento)
    {
        var texto = CalculateDueDateFactor(dataVencimento).ToString("0000");
        if (texto.Length != 4) throw new FormatException($"Formato inválido: '{texto}'");
        return texto;
    }
    /// <summary>
    /// Executa o cálculo do Fator de Vencimento
    /// </summary>
    /// <param name="dataVencimento">Data de vencimento do boleto</param>
    /// <returns>Fator de vencimento</returns>
    public static int CalculateDueDateFactor(DateTime dataVencimento)
    {
        // O fator de vencimento é o total de dias entre
        // a data base e a data de vencimento
        return (dataVencimento - DATA_BASE).Days;
    }
}
