namespace Simple.Brazilian.Validators;

using System;

/// <summary>
/// Classe para validar datas
/// </summary>
public class Dates
{
    /// <summary>
    /// Verifca se uma data é dia útil ou não
    /// </summary>
    /// <param name="date">Data a ser validada</param>
    /// <param name="checkNationalHolydays">Verificar se é feriado nacional</param>
    /// <returns>True se for dia útil, False se não</returns>
    public static bool IsBusinessDay(DateTime date, bool checkNationalHolydays = true)
    {
        if (date.DayOfWeek == DayOfWeek.Saturday) return false;
        if (date.DayOfWeek == DayOfWeek.Sunday) return false;

        if (checkNationalHolydays)
        {
            bool isHoliday = Information.Dates.IsNationalHoliday(date, out _);

            if (isHoliday) return false;
        }

        return true;
    }

    /// <summary>
    /// Retorna o próximo dia útil a partir de uma data base.
    /// InvalidOperationException: Caso não seja localizada nos 14 dias seguintes à dataBase
    /// </summary>
    /// <param name="baseDate">Data a ser verificada</param>
    /// <param name="checkNationalHolydays">Define se deve considerar feriados nacionais na verificação</param>
    /// <param name="acceptBaseDate">Define se a dataBase é uma data válida para retorno case seja dia útil</param>
    /// <returns>Próximo dia útil</returns>
    public static DateTime NextBusinessDay(DateTime baseDate, bool checkNationalHolydays = true, bool acceptBaseDate = false)
    {
        if (acceptBaseDate)
        {
            if (IsBusinessDay(baseDate, checkNationalHolydays)) return baseDate;
        }
        // Verifica no máximo 14 dias
        for (int i = 1; i <= 14; i++)
        {
            var data = baseDate.AddDays(i);

            if (IsBusinessDay(data, checkNationalHolydays)) return data;
        }

        throw new InvalidOperationException("Não foi localizado um dia útil nos 14 dias seguintes à data informada");
    }
    /// <summary>
    /// Encontra o próximo X dia útil a partir de uma data base
    /// </summary>
    /// <param name="baseDate">Data base a ser verificada</param>
    /// <param name="days">Dias úteis a serem contados</param>
    /// <param name="checkNationalHolydays">Define se deve considerar feriados nacionais na verificação</param>
    /// <returns>Data após o número `days` de dias úteis</returns>
    public static DateTime FindNextBusinessDays(DateTime baseDate, int days, bool checkNationalHolydays = true)
    {
        if (days < 0)
        {
            throw new ArgumentException("Não é possível calcular dias úteis negativos");
        }
        if (days == 0)
        {
            throw new ArgumentException("Não é possível calcular zero dias úteis. Utilize NextBusinessDay com o parâmetro acceptBaseDate=true");
        }

        int diasOlhar = days * 2 + 7; // no mínimo 12 dias

        int contaDias = 0;
        for (int i = 1; i < diasOlhar; i++) // Olha no máximo o dobro de dias
        {
            var data = baseDate.AddDays(i);
            if (IsBusinessDay(data, checkNationalHolydays))
            {
                contaDias++;
            }
            if (contaDias == days) return data;
        }

        throw new InvalidOperationException($"Não foi localizado um dia útil nos {diasOlhar} dias seguintes à data informada");
    }

}
