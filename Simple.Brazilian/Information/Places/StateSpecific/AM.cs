namespace Simple.Brazilian.Information.Places.StateSpecific;

using System;

public class AM : IStateData
{
    public UFs UF => UFs.AM;

    public bool IsSateHoliday(DateTime date, out string name)
    {
        name = null;
        return false;
    }
}
