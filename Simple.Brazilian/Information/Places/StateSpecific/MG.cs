namespace Simple.Brazilian.Information.Places.StateSpecific;

using System;

public class MG : IStateData
{
    public UFs UF => UFs.MG;

    public bool IsSateHoliday(DateTime date, out string name)
    {
        name = null;
        return false;
    }
}
