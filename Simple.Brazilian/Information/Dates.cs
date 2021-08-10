using System;

namespace Simple.Brazilian.Information
{
    /// <summary>
    /// Informações sobre datas
    /// </summary>
    public static class Dates
    {
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

            return false;
        }

    }
}
