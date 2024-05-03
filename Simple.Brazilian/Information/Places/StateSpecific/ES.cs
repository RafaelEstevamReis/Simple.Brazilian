namespace Simple.Brazilian.Information.Places.StateSpecific;

using System;

public class ES : IStateData
{
    public UFs UF => UFs.ES;

    public bool IsSateHoliday(DateTime date, out string name)
    {
        name = null;
        return false;
    }
}
