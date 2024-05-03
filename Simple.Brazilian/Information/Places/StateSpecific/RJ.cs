namespace Simple.Brazilian.Information.Places.StateSpecific;

using System;

public class RJ : IStateData
{
    public UFs UF => UFs.RJ;

    public bool IsSateHoliday(DateTime date, out string name)
    {
        name = null;
        return false;
    }
}
