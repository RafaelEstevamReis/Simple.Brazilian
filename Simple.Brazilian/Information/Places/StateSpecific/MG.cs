namespace Simple.Brazilian.Information.Places.StateSpecific;

using System;
using Simple.Brazilian.Information.Places;

public class MG : IStateData
{
    public UFs UF => UFs.MG;

    public bool IsSateHoliday(DateTime date, out string name)
    {
        if (date.Month == 4)
        {
            if (date.Day == 21)
            {
                name = "Data Magna de Minas Gerais";
                return true;
            }
        }

        name = null;
        return false;
    }
}
