namespace Simple.Brazilian.Documents;

using System;

/// <summary>
/// Validador de CNPJ
/// </summary>
public static class CNPJ
{
    /// <summary>
    /// Executa a validação de um CNPJ
    /// com ou sem máscara
    /// </summary>
    /// <param name="cnpj">CNPJ a ser verificado</param>
    /// <returns>True se o CNPJ é válido de acordo com o cálculo do Dígito Verificador;
    /// False senão</returns>
    public static bool IsValid(string cnpj)
    {
        /* Comparativo entre a versão corrente e a original (60f80c9)
         |       Method   |      Mean |     Error |    StdDev |    Median |  Gen 0 | Gen 1 | Gen 2 | Allocated |
         |--------------- |----------:|----------:|----------:|----------:|-------:|------:|------:|----------:|
         | ValidaCNPJ     |  20.56 ns |  0.863 ns |  2.545 ns |  19.53 ns |      - |     - |     - |         - |
         | ValidaCNPJ_Org | 578.52 ns | 21.540 ns | 63.511 ns | 596.85 ns | 0.4320 |     - |     - |     904 B |
         */

        // Vazio ou nulo
        if (string.IsNullOrEmpty(cnpj))
            return false;

        // Se for maior, retira a máscara
        if (cnpj.Length > 14) cnpj = Unmask(cnpj);

        // Deve ser exatamente 11
        if (cnpj.Length != 14)
            return false;

        int firstDigit = cnpj[12] - '0';
        int secondDigit = cnpj[13] - '0';

        if (!CalculateDigits(cnpj, out int firstDigitVerification, out int secondDigitVerification))
            return false;

        if (firstDigitVerification != firstDigit || secondDigitVerification != secondDigit)
            return false;

        // Remove "11111..."
        // Não é válido se qualquer um dos dígitos for diferente
        for (int i = 1; i < 14; i++)
        {
            // Se algum for diferente, o CNPJ é válido
            if (cnpj[i] != cnpj[0]) return true;
        }

        return false;
    }

    private static bool CalculateDigits(string cnpj, out int firstDigitVerification, out int secondDigitVerification)
    {
        int firstSum = 0;
        int secondSum = 0;
        int countdown1 = 5;
        int countdown2 = 6;
        // Calcula simultâneo
        for (int i = 0; i < 12; i++)
        {
            int intValue = cnpj[i] - '0';
            // Não é número ?
            if (intValue > 9 || intValue < 0)
            {
                firstDigitVerification = 0;
                secondDigitVerification = 0;

                return false; // Interrompe
            }

            firstSum += intValue * countdown1;
            secondSum += intValue * countdown2;

            countdown1 -= 1;
            countdown2 -= 1;

            if (countdown1 == 1) countdown1 = 9;
            if (countdown2 == 1) countdown2 = 9;
        }

        // Termina o dígito 1
        firstDigitVerification = (firstSum * 10) % 11;
        if (firstDigitVerification == 10)
            firstDigitVerification = 0;

        // Termina o dígito 2
        secondSum += 2 * firstDigitVerification;
        secondDigitVerification = (secondSum * 10) % 11;

        if (secondDigitVerification == 10)
            secondDigitVerification = 0;

        // Finalizou
        return true;
    }

    /// <summary>
    /// Completa um CNPJ que esteja sem os dígitos verificadores
    /// </summary>
    /// <param name="partialCNPJ">CNPJ parcial com 12 dígitos a ser completado</param>
    /// <returns>CPF válido</returns>
    /// <exception cref="ArgumentNullException">Parâmetro não deve ser NULL</exception>
    /// <exception cref="ArgumentException">Parâmetro informado é inválido</exception>
    public static string CompleteWithDigitsCNPJ(string partialCNPJ)
    {
        if (partialCNPJ is null) throw new ArgumentNullException(nameof(partialCNPJ));
        if (partialCNPJ.Length != 12) throw new ArgumentException($"{nameof(partialCNPJ)} deve ser composto pelos 12 dígitos iniciais");

        bool valid = CalculateDigits(partialCNPJ, out int d1, out int d2);
        if (!valid) throw new ArgumentException($"{nameof(partialCNPJ)} é inválido");

        return $"{partialCNPJ}{d1}{d2}";
    }


    /// <summary>
    /// Aplica a máscara de CNPJ __.___.___/____-__
    /// </summary>
    /// <param name="cnpj">Texto para aplicar a máscara</param>
    /// <returns>Texto com a máscara</returns>
    public static string Mask(string cnpj) => Formatters.Text.ApplyMask(cnpj, "__.___.___/____-__");
    /// <summary>
    /// Remove a máscara
    /// </summary>
    /// <param name="cnpj">Texto com a máscara aplicada</param>
    /// <returns>Texto com a máscara removida</returns>
    public static string Unmask(string cnpj) => Formatters.Text.RemoveMask(cnpj);

}
