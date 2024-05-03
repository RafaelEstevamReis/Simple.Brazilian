namespace Simple.Brazilian.Information.Places.StateSpecific;

using System;

public class MT : IStateData
{
    public UFs UF => UFs.MT;

    public bool IsSateHoliday(DateTime date, out string name)
    {
        name = null;
        return false;
    }
}
