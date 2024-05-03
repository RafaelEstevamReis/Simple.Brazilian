namespace Simple.Brazilian.Information.Places.StateSpecific;

using System;

public class RN : IStateData
{
    public UFs UF => UFs.RN;

    public bool IsSateHoliday(DateTime date, out string name)
    {
        name = null;
        return false;
    }
}
