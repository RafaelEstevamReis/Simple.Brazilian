namespace Simple.Brazilian.Information.Places.StateSpecific;

using System;

public class PE : IStateData
{
    public UFs UF => UFs.PE;

    public bool IsSateHoliday(DateTime date, out string name)
    {
        if (date.Month == 3)
        {
            if (date.Day == 6)
            {
                name = "Data Magna do Estado de Pernambuco";
                return true;
            }
        }
        if (date.Month == 6)
        {
            if (date.Day == 24)
            {
                name = "Dia de São João";
                return true;
            }
        }

        name = null;
        return false;
    }
}
