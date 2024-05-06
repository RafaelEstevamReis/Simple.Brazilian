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
                name = "Eleva��o do antigo Territ�rio Federal do Rio Branco a estado de Roraima";
                return true;
            }
        }

        name = null;
        return false;
    }
}
