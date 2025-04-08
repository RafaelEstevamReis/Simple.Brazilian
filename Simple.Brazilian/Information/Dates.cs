namespace Simple.Brazilian.Information;

using Simple.Brazilian.Information.Places;
using System;

/// <summary>
/// Informações sobre datas
/// </summary>
public static class Dates
{
    public enum TextStyle
    {
        Regular,
        Upper,
        Lower
    }

    /* Normais */
    /// <summary>
    /// Lista de Months com a iniciaLowermaiúscula, com acentos
    /// </summary>
    public static readonly string[] MonthsWithAccent = { "Janeiro", "Fevereiro", "Março", "Abril", "Maio", "Junho", "Julho", "Agosto", "Setembro", "Outubro", "Novembro", "Dezembro" };
    /// <summary>
    /// Lista de Months com a iniciaLowermaiúscula, sem acentos
    /// </summary>
    public static readonly string[] MonthsWithoutAccent = { "Janeiro", "Fevereiro", "Marco", "Abril", "Maio", "Junho", "Julho", "Agosto", "Setembro", "Outubro", "Novembro", "Dezembro" };
    /// <summary>
    /// Lista de dias da semana com a iniciaLowermaiúscula, com acentos
    /// </summary>
    public static readonly string[] WeekDayWithAccent = { "Domingo", "Segunda", "Terça", "Quarta", "Quinta", "Sexta", "Sábado" };
    /// <summary>
    /// Lista de dias da semana com a iniciaLowermaiúscula, sem acentos
    /// </summary>
    public static readonly string[] WeekDayWithoutAccent = { "Domingo", "Segunda", "Terca", "Quarta", "Quinta", "Sexta", "Sabado" };

    /* Em MAIÚSCULO */
    /// <summary>
    /// Lista de Months em maiúsculo, com acentos
    /// </summary>
    public static readonly string[] MonthsWithAccentUpper = { "JANEIRO", "FEVEREIRO", "MARÇO", "ABRIL", "MAIO", "JUNHO", "JULHO", "AGOSTO", "SETEMBRO", "OUTUBRO", "NOVEMBRO", "DEZEMBRO" };
    /// <summary>
    /// Lista de Months em maiúsculo, sem acentos
    /// </summary>
    public static readonly string[] MonthsWithoutAccentUpper = { "JANEIRO", "FEVEREIRO", "MARCO", "ABRIL", "MAIO", "JUNHO", "JULHO", "AGOSTO", "SETEMBRO", "OUTUBRO", "NOVEMBRO", "DEZEMBRO" };
    /// <summary>
    /// Lista de dias da semana em maiúsculo, com acentos
    /// </summary>
    public static readonly string[] WeekDayWithAccentUpper = { "DOMINGO", "SEGUNDA", "TERÇA", "QUARTA", "QUINTA", "SEXTA", "SÁBADO" };
    /// <summary>
    /// Lista de dias da semana em maiúsculo, sem acentos
    /// </summary>
    public static readonly string[] WeekDayWithoutAccentUpper = { "DOMINGO", "SEGUNDA", "TERCA", "QUARTA", "QUINTA", "SEXTA", "SABADO" };

    /* Em minúsculo */
    /// <summary>
    /// Lista de Months em minúsculo, com acentos
    /// </summary>
    public static readonly string[] MonthsWithAccentLower = { "janeiro", "fevereiro", "março", "abril", "maio", "junho", "julho", "agosto", "setembro", "outubro", "novembro", "dezembro" };
    /// <summary>
    /// Lista de Months em minúsculo, sem acentos
    /// </summary>
    public static readonly string[] MonthsWithoutAccentLower = { "janeiro", "fevereiro", "marco", "abril", "maio", "junho", "julho", "agosto", "setembro", "outubro", "novembro", "dezembro" };
    /// <summary>
    /// Lista de dias da semana em minúsculo, com acentos
    /// </summary>
    public static readonly string[] WeekDayWithAccentLower = { "domingo", "segunda", "terça", "quarta", "quinta", "sexta", "sábado" };
    /// <summary>
    /// Lista de dias da semana em minúsculo, sem acentos
    /// </summary>
    public static readonly string[] WeekDayWithoutAccentLower = { "domingo", "segunda", "terca", "quarta", "quinta", "sexta", "sabado" };

    /// <summary>
    /// Retorna o nome do mês referenciado formatado
    /// </summary>
    /// <param name="dtReference">Referência para obter o mês</param>
    /// <param name="style">Estilo de capitalização</param>
    /// <param name="WithAccents">Utilizar acentos?</param>
    /// <returns>Nome do mês</returns>
    public static string GetMonthName(DateTime dtReference, TextStyle style = TextStyle.Regular, bool WithAccents = true)
    {
        int monthIndex = dtReference.Month - 1;
        return style switch
        {
            TextStyle.Regular => WithAccents ? MonthsWithAccent[monthIndex] : MonthsWithoutAccent[monthIndex],
            TextStyle.Upper => WithAccents ? MonthsWithAccentUpper[monthIndex] : MonthsWithoutAccentUpper[monthIndex],
            TextStyle.Lower => WithAccents ? MonthsWithAccentLower[monthIndex] : MonthsWithoutAccentLower[monthIndex],
            _ => throw new Exception("Invalid style"),
        };
    }

    /// <summary>
    /// Retorna o nome do dia da semana referenciado formatado
    /// </summary>
    /// <param name="dtReference">Referência para obter o dia da semana</param>
    /// <param name="style">Estilo de capitalização</param>
    /// <param name="WithAccents">Utilizar acentos?</param>
    /// <returns>Nome do dia da semana</returns>
    public static string GetWeekdayName(DateTime dtReference, TextStyle style = TextStyle.Regular, bool WithAccents = true)
    {
        int weekIndex = (int)dtReference.DayOfWeek;
        return style switch
        {
            TextStyle.Regular => WithAccents ? WeekDayWithAccent[weekIndex] : WeekDayWithoutAccent[weekIndex],
            TextStyle.Upper => WithAccents ? WeekDayWithAccentUpper[weekIndex] : WeekDayWithoutAccentUpper[weekIndex],
            TextStyle.Lower => WithAccents ? WeekDayWithAccentLower[weekIndex] : WeekDayWithoutAccentLower[weekIndex],
            _ => throw new Exception("Invalid style"),
        };
    }

    /// <summary>
    /// Retorna feriados civís nacionais
    /// Segundo as leis 10.607/2002 e 6.802/1980
    /// </summary>
    /// <param name="date">Data a ser validada</param>
    /// <param name="name">Nome do feriado</param>
    /// <returns>True, se é feriado ou False, se não</returns>
    public static bool IsNationalHoliday(DateTime date, out string name)
    {
        name = null;
        // Feriados Nacionais
        // LEI No 10.607, DE 19 DE DEZEMBRO DE 2002.
        // "Art. 1o São feriados nacionais os dias 1o de janeiro, 21 de abril, 1o de maio, 7 de setembro, 2 de novembro, 15 de novembro e 25 de dezembro."(NR)
        // https://www.in.gov.br/en/web/dou/-/portaria-mgi-n-9.783-de-27-de-dezembro-de-2024-604395869
        // > Portaria lista vários outros

        // 1o de janeiro
        if (date.Day == 01 && date.Month == 1)
        {
            name = "Confraternização Universal";
            return true;
        }
        // 21 de abril
        if (date.Day == 21 && date.Month == 04)
        {
            name = "Tiradentes";
            return true;
        }
        // 1o de maio
        if (date.Day == 01 && date.Month == 05)
        {
            name = "Dia do Trabalhador";
            return true;
        }
        // 7 de setembro
        if (date.Day == 07 && date.Month == 09)
        {
            name = "Independência do Brasil";
            return true;
        }
        // 2 de novembro
        if (date.Day == 02 && date.Month == 11)
        {
            name = "Finados";
            return true;
        }
        // 15 de novembro
        if (date.Day == 15 && date.Month == 11)
        {
            name = "Proclamação da República";
            return true;
        }

        // 20 de novembro, Dia Nacional de Zumbi e da Consciência Negra (feriado nacional)
        if (date.Year >= 2024 && date.Day == 20 && date.Month == 11)
        {
            name = "Dia Nacional de Zumbi e da Consciência Negra";
            return true;
        }

        // 25 de dezembro
        if (date.Day == 25 && date.Month == 12)
        {
            name = "Natal";
            return true;
        }

        // LEI No 6.802, DE 30 DE JUNHO DE 1980.
        // Art. 1º É declarado feriado nacional o dia 12 de outubro, para culto público e oficial a Nossa Senhora Aparecida, Padroeira do Brasil.
        if (date.Day == 12 && date.Month == 10)
        {
            name = "Nossa Senhora Aparecida";
            return true;
        }

        // Portaria MGI Nº 9.783, DE 27 DE dezembro DE 2024
        // 18 de abril
        if (date.Year >= 2025 && date.Day == 18 && date.Month == 04)
        {
            name = "Paixão de Cristo";
            return true;
        }

        return false;
    }

    /// <summary>
    /// Retorna feriados civís estaduais
    /// </summary>
    /// <param name="uf">UF para qual validar</param>
    /// <param name="date">Data a ser validada</param>
    /// <param name="name">Nome do feriado</param>
    /// <returns>True, se é feriado ou False, se não</returns>
    public static bool IsStateHoliday(UFs uf, DateTime date, out string name)
    {
        var si = States.GetStateDataObject(uf);
        return si.IsSateHoliday(date, out name);
    }
}
