namespace Simple.Brazilian.Information.Places.StateSpecific;

using System;

public class DF : IStateData
{
    public UFs UF => UFs.DF;

    public bool IsSateHoliday(DateTime date, out string name)
    {
        name = null;
        return false;
    }
}
