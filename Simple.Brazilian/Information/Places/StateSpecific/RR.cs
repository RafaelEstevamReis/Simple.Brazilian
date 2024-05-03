namespace Simple.Brazilian.Information.Places.StateSpecific;

using System;

public class RR : IStateData
{
    public UFs UF => UFs.RR;

    public bool IsSateHoliday(DateTime date, out string name)
    {
        name = null;
        return false;
    }
}
