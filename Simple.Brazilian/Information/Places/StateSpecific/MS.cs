namespace Simple.Brazilian.Information.Places.StateSpecific;

using System;

public class MS : IStateData
{
    public UFs UF => UFs.MS;

    public bool IsSateHoliday(DateTime date, out string name)
    {
        name = null;
        return false;
    }
}
