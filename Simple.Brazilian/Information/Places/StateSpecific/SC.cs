namespace Simple.Brazilian.Information.Places.StateSpecific;

using System;

public class SC : IStateData
{
    public UFs UF => UFs.SC;

    public bool IsSateHoliday(DateTime date, out string name)
    {
        if (date.Month == 8)
        {
            if (date.Day == 11)
            {
                name = "Dia do Estado de Santa Catarina";
                return true;
            }
        }

        name = null;
        return false;
    }
}
