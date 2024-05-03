namespace Simple.Brazilian.Information.Places.StateSpecific;

using System;

public class PI : IStateData
{
    public UFs UF => UFs.PI;

    public bool IsSateHoliday(DateTime date, out string name)
    {
        name = null;
        return false;
    }
}
