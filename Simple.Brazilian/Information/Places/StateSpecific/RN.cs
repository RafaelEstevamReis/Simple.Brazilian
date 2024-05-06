namespace Simple.Brazilian.Information.Places.StateSpecific;

using System;
using Simple.Brazilian.Information.Places;

public class RN : IStateData
{
    public UFs UF => UFs.RN;

    public bool IsSateHoliday(DateTime date, out string name)
    {
        if (date.Month == 10)
        {
            if (date.Day == 3)
            {
                name = "Protomártires de Uruaçu e Cunhaú";
                return true;
            }
        }

        name = null;
        return false;
    }
}
