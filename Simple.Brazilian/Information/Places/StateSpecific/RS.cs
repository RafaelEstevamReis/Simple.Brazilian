namespace Simple.Brazilian.Information.Places.StateSpecific;

using System;

public class RS : IStateData
{
    public UFs UF => UFs.RS;

    public bool IsSateHoliday(DateTime date, out string name)
    {
        name = null;
        return false;
    }
}
