namespace Simple.Brazilian.Information.Places.StateSpecific;

using System;

public class CE : IStateData
{
    public UFs UF => UFs.CE;

    public bool IsSateHoliday(DateTime date, out string name)
    {
        name = null;
        return false;
    }
}
