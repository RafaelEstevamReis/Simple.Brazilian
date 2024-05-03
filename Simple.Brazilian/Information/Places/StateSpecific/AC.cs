namespace Simple.Brazilian.Information.Places.StateSpecific;

using System;

public class AC : IStateData
{
    public UFs UF => UFs.AC;

    public bool IsSateHoliday(DateTime date, out string name)
    {
        if (date.Month == 1)
        {
            if (date.Day == 20)
            {
                name = "Dia do Católico";
                return true;
            }
        }
        if (date.Month == 1)
        {
            if (date.Day == 25)
            {
                name = "Dia do Evangélico";
                return true;
            }
        }
        if (date.Month == 6)
        {
            if (date.Day == 15)
            {
                name = "Aniversário do Estado do Acre";
                return true;
            }
        }
        if (date.Month == 9)
        {
            if (date.Day == 5)
            {
                name = "Dia da Amazônia";
                return true;
            }
        }
        if (date.Month == 11)
        {
            if (date.Day == 17)
            {
                name = "Tratado de Petrópolis";
                return true;
            }
        }

        name = null;
        return false;
    }
}
