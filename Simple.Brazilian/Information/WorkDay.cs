namespace Simple.Brazilian.Information;

using Simple.Brazilian.Information.Places;
using System;

/// <summary>
/// Classe para lidar com dias úteis
/// Segundo as leis 10.607/2002 e 6.802/1980
/// </summary>
public class WorkDay
{
    /// <summary>
    /// Tipo de data
    /// </summary>
    public enum DayType
    {
        /// <summary>
        /// Feriado nacional, ver Dates.IsNationalHoliday
        /// </summary>
        NationalHoliday,
        /// <summary>
        /// Feriado estadual, ver Dates.IsStateHoliday
        /// </summary>
        StateHoliday,
        /// <summary>
        /// Fim de semana
        /// </summary>
        WeekEnd,
        /// <summary>
        /// Dia de semana
        /// </summary>
        WeekDay,
    }
    /// <summary>
    /// Obtém o tipo de dia
    /// </summary>
    /// <param name="date">Data base</param>
    /// <param name="uf">UF para qual verificar feriados estaduais, EX para não verificar</param>
    /// <returns>Tipo de data</returns>
    public static DayType GetDayType(DateTime date, UFs uf = UFs.EX)
    {
        if (Dates.IsNationalHoliday(date, out _)) return DayType.NationalHoliday;
        if (uf != UFs.EX)
        {
            if (Dates.IsStateHoliday(uf, date, out _)) return DayType.StateHoliday;
        }

        if (date.DayOfWeek == DayOfWeek.Saturday) return DayType.WeekEnd;
        if (date.DayOfWeek == DayOfWeek.Sunday) return DayType.WeekEnd;

        return DayType.WeekDay;
    }

    /// <summary>
    /// Obtém dias úteis entre as datas
    /// </summary>
    /// <param name="start">Data de início, inclusive</param>
    /// <param name="end">Data de dim, inclusive</param>
    /// <param name="uf">UF para qual verificar feriados estaduais, EX para não verificar</param>
    /// <returns>Dias úteis</returns>
    public static int WorkDaysBetween(DateTime start, DateTime end, UFs uf = UFs.EX)
    {
        int count = 0;
        for (DateTime dt = start.Date; dt <= end; dt = dt.AddDays(1).Date)
        {
            var type = GetDayType(dt, uf);
            if (type == DayType.WeekDay) count++;
        }
        return count;
    }

    /// <summary>
    /// Retorna o n'ésimo dia útil a partir do início
    /// </summary>
    /// <param name="start">Dia 0 da busca</param>
    /// <param name="days">Número N de dias a serem buscados</param>
    /// <param name="uf">UF para qual verificar feriados estaduais, EX para não verificar</param>
    /// <returns>Data do n'ésimo dia</returns>
    public static DateTime WorkdayIn(DateTime start, int days, UFs uf = UFs.EX)
    {
        var dt = start;
        while (days > 0)
        {
            dt = dt.AddDays(1);
            var dayType = GetDayType(dt, uf);
            if (dayType == DayType.WeekDay) days--;
        }
        return dt;
    }

}
