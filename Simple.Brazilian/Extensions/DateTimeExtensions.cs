namespace Simple.Brazilian.Extensions;

using Simple.Brazilian.Information;
using Simple.Brazilian.Information.Places;
using System;

public static class DateTimeExtensions
{

    /// <summary>
    /// Retorna o nome do mês referenciado formatado
    /// </summary>
    /// <param name="dtReference">Referência para obter o mês</param>
    /// <param name="style">Estilo de capitalização</param>
    /// <param name="WithAccents">Utilizar acentos?</param>
    /// <returns>Nome do mês</returns>
    public static string GetMonthName(this DateTime dtReference, Dates.TextStyle style = Dates.TextStyle.Regular, bool WithAccents = true)
        => Dates.GetMonthName(dtReference, style, WithAccents);

    /// <summary>
    /// Retorna o nome do dia da semana referenciado formatado
    /// </summary>
    /// <param name="dtReference">Referência para obter o dia da semana</param>
    /// <param name="style">Estilo de capitalização</param>
    /// <param name="WithAccents">Utilizar acentos?</param>
    /// <returns>Nome do dia da semana</returns>
    public static string GetWeekdayName(this DateTime dtReference, Dates.TextStyle style = Dates.TextStyle.Regular, bool WithAccents = true)
        => Dates.GetWeekdayName(dtReference, style, WithAccents);

    /// <summary>
    /// Retorna feriados civís nacionais
    /// Segundo as leis 10.607/2002 e 6.802/1980
    /// </summary>
    /// <param name="date">Data a ser validada</param>
    /// <param name="name">Nome do feriado</param>
    /// <returns>True, se é feriado ou False, se não</returns>
    public static bool IsNationalHoliday(this DateTime date, out string name)
        => Dates.IsNationalHoliday(date, out name);
    /// <summary>
    /// Retorna feriados civís estaduais
    /// </summary>
    /// <param name="uf">UF para qual validar</param>
    /// <param name="date">Data a ser validada</param>
    /// <param name="name">Nome do feriado</param>
    /// <returns>True, se é feriado ou False, se não</returns>
    public static bool IsStateHoliday(this DateTime date, UFs uf, out string name)
        => Dates.IsStateHoliday(uf, date, out name);
}
