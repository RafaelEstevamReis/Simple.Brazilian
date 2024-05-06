namespace Simple.Brazilian.Information.Places.StateSpecific;

using System;
using Simple.Brazilian.Information.Places;

public class RO : IStateData
{
    public UFs UF => UFs.RO;

    public bool IsSateHoliday(DateTime date, out string name)
    {
        if (date.Month == 1)
        {
            if (date.Day == 4)
            {
                name = "Criação do Estado de Rondônia";
                return true;
            }
        }
        if (date.Month == 6)
        {
            if (date.Day == 18)
            {
                name = "Dia do Evangélico";
                return true;
            }
        }

        name = null;
        return false;
    }
}
