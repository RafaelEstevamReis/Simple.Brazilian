namespace Simple.Brazilian.Information.Places.StateSpecific;

using System;
using Simple.Brazilian.Information.Places;

public class RR : IStateData
{
    public UFs UF => UFs.RR;

    public bool IsSateHoliday(DateTime date, out string name)
    {
        if (date.Month == 10)
        {
            if (date.Day == 5)
            {
                name = "Elevação do antigo Território Federal do Rio Branco a estado de Roraima";
                return true;
            }
        }

        name = null;
        return false;
    }
}
