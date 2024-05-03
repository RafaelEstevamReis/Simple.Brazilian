namespace Simple.Brazilian.Information.Places.StateSpecific;

using System;

public class BA : IStateData
{
    public UFs UF => UFs.BA;

    public bool IsSateHoliday(DateTime date, out string name)
    {
        name = null;
        return false;
    }
}
