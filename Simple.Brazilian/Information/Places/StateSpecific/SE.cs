namespace Simple.Brazilian.Information.Places.StateSpecific;

using System;

public class SE : IStateData
{
    public UFs UF => UFs.SE;

    public bool IsSateHoliday(DateTime date, out string name)
    {
        name = null;
        return false;
    }
}
