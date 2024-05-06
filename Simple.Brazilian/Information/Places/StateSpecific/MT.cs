namespace Simple.Brazilian.Information.Places.StateSpecific;

using System;
using Simple.Brazilian.Information.Places;

public class MT : IStateData
{
    public UFs UF => UFs.MT;

    public bool IsSateHoliday(DateTime date, out string name)
    {
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
