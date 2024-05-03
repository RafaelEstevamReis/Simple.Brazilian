namespace Simple.Brazilian.Information.Places.StateSpecific;

using System;

public class SP : IStateData
{
    public UFs UF => UFs.SP;

    public bool IsSateHoliday(DateTime date, out string name)
    {
        name = null;
        return false;
    }
}
