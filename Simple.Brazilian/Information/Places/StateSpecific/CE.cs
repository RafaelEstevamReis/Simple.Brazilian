namespace Simple.Brazilian.Information.Places.StateSpecific;

using System;
using Simple.Brazilian.Information.Places;

public class CE : IStateData
{
    public UFs UF => UFs.CE;

    public bool IsSateHoliday(DateTime date, out string name)
    {
        if (date.Month == 3)
        {
            if (date.Day == 19)
            {
                name = "Dia de S�o Jos�";
                return true;
            }

            if (date.Day == 25)
            {
                name = "Data Magna do Cear�";
                return true;
            }
        }

        name = null;
        return false;
    }
}
