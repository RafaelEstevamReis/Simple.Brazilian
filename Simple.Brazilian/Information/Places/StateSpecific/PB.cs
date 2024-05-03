namespace Simple.Brazilian.Information.Places.StateSpecific;

using System;

public class PB : IStateData
{
    public UFs UF => UFs.PB;

    public bool IsSateHoliday(DateTime date, out string name)
    {
        name = null;
        return false;
    }
}
