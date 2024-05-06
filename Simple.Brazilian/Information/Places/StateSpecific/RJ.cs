namespace Simple.Brazilian.Information.Places.StateSpecific;

using System;
using Simple.Brazilian.Information.Places;

public class RJ : IStateData
{
    public UFs UF => UFs.RJ;

    public bool IsSateHoliday(DateTime date, out string name)
    {
        // Carnaval - data m�vel

        if(date.Month == 4)
        {
            if(date.Day == 23)
            {
                name = "Dia de S�o Jorge";
                return true;
            }
        }
        // Dia do Com�rcio - Data m�vel: 3� segunda-feira de outubro
        if (date.Month == 10)
        {
            if (date.DayOfWeek == DayOfWeek.Monday)
            {
                if(date.Day >= 15 // M�s come�ou numa ter�a feira
                    && date.Day <= 21) // M�s come�ou numa quarta
                {
                    name = "Dia do Com�rcio";
                    return true;
                }
            }
        }
        if (date.Month == 11)
        {
            if(date.Day == 20)
            {
                name = "Dia da Consci�ncia Negra";
                return true;
            }
        }
        
        name = null;
        return false;
    }
}
