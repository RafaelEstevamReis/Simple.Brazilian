namespace Simple.Brazilian.Information.Places.StateSpecific;

using System;

public class MA : IStateData
{
    public UFs UF => UFs.MA;

    public bool IsSateHoliday(DateTime date, out string name)
    {
        name = null;
        return false;
    }
}
