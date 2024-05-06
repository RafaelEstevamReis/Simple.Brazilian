namespace Simple.Brazilian.Information.Places.StateSpecific;

using System;
using Simple.Brazilian.Information.Places;

public class TO : IStateData
{
    public UFs UF => UFs.TO;

    public bool IsSateHoliday(DateTime date, out string name)
    {
        if (date.Month == 1)
        {
            if (date.Day ==1)
            {
                name = "Instalação de Tocantins";
                return true;
            }
        }
        if (date.Month == 9)
        {
            if (date.Day == 8)
            {
                name = "Nossa Senhora da Natividade";
                return true;
            }
        }
        if (date.Month == 10)
        {
            if (date.Day == 5)
            {
                name = "Criação de Tocantins";
                return true;
            }
        }

        name = null;
        return false;
    }
}
