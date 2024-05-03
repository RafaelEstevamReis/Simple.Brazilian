namespace Simple.Brazilian.Information.Places.StateSpecific;

using System;

public class PE : IStateData
{
    public UFs UF => UFs.PE;

    public bool IsSateHoliday(DateTime date, out string name)
    {
        name = null;
        return false;
    }
}
