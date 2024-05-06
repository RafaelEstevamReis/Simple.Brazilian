namespace Simple.Brazilian.Information.Places.StateSpecific;

using System;
using Simple.Brazilian.Information.Places;

public class RJ : IStateData
{
    public UFs UF => UFs.RJ;

    public bool IsSateHoliday(DateTime date, out string name)
    {
        // Carnaval - data móvel

        if(date.Month == 4)
        {
            if(date.Day == 23)
            {
                name = "Dia de São Jorge";
                return true;
            }
        }
        // Dia do Comércio - Data móvel: 3ª segunda-feira de outubro
        if (date.Month == 10)
        {
            if (date.DayOfWeek == DayOfWeek.Monday)
            {
                if(date.Day >= 15 // Mês começou numa terça feira
                    && date.Day <= 21) // Mês começou numa quarta
                {
                    name = "Dia do Comércio";
                    return true;
                }
            }
        }
        if (date.Month == 11)
        {
            if(date.Day == 20)
            {
                name = "Dia da Consciência Negra";
                return true;
            }
        }
        
        name = null;
        return false;
    }
}
