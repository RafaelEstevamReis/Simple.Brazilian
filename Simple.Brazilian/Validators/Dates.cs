using System;

namespace Simple.Brazilian.Validators
{
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
    }
}
