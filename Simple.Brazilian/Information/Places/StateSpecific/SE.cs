namespace Simple.Brazilian.Information.Places.StateSpecific;

using System;
using Simple.Brazilian.Information.Places;

public class SE : IStateData
{
    public UFs UF => UFs.SE;

    public bool IsSateHoliday(DateTime date, out string name)
    {
        if (date.Month == 7)
        {
            if (date.Day == 8)
            {
                name = "Emancipação política de Sergipe";
                return true;
            }
        }

        name = null;
        return false;
    }
}
