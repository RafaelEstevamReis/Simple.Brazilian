namespace Simple.Brazilian.Information.Places.StateSpecific;

using System;

public class TO : IStateData
{
    public UFs UF => UFs.TO;

    public bool IsSateHoliday(DateTime date, out string name)
    {
        name = null;
        return false;
    }
}
