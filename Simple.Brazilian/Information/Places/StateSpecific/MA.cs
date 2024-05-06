namespace Simple.Brazilian.Information.Places.StateSpecific;

using System;
using Simple.Brazilian.Information.Places;

public class MA : IStateData
{
    public UFs UF => UFs.MA;

    public bool IsSateHoliday(DateTime date, out string name)
    {
        if (date.Month == 7)
        {
            if (date.Day == 28)
            {
                name = "Dia da Adesão do Maranhão à Independência do Brasil";
                return true;
            }
        }

        name = null;
        return false;
    }
}
