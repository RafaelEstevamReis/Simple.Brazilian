namespace Simple.Brazilian.Information.Places.StateSpecific;

using System;

public class BA : IStateData
{
    public UFs UF => UFs.BA;

    public bool IsSateHoliday(DateTime date, out string name)
    {
        if (date.Month == 7)
        {
            if (date.Day == 2)
            {
                name = "Independência do Estado da Bahia";
                return true;
            }
        }

        name = null;
        return false;
    }
}
