namespace Simple.Brazilian.Information.Places.StateSpecific;

using System;

public class AC : IStateData
{
    public UFs UF => UFs.AC;

    public bool IsSateHoliday(DateTime date, out string name)
    {
        name = null;
        return false;
    }
}
