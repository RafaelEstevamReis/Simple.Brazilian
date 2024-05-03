namespace Simple.Brazilian.Information.Places.StateSpecific;

using System;

public class AP : IStateData
{
    public UFs UF => UFs.AP;

    public bool IsSateHoliday(DateTime date, out string name)
    {
        if (date.Month == 3)
        {
            if (date.Day == 19)
            {
                name = "Dia de São José";
                return true;
            }
        }
        if (date.Month == 7)
        {
            if (date.Day == 25)
            {
                name = "Dia de São Tiago";
                return true;
            }
        }
        if (date.Month == 11)
        {
            if (date.Day == 20)
            {
                name = "Dia da Consciência Negra";
                return true;
            }
        }

        name = null;
        return false;
    }
}
