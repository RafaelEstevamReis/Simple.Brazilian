namespace Simple.Brazilian.Information.Places.StateSpecific;

using System;

public class RO : IStateData
{
    public UFs UF => UFs.RO;

    public bool IsSateHoliday(DateTime date, out string name)
    {
        name = null;
        return false;
    }
}
