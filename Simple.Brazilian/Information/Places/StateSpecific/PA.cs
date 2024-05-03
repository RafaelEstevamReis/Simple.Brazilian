namespace Simple.Brazilian.Information.Places.StateSpecific;

using System;

public class PA : IStateData
{
    public UFs UF => UFs.PA;

    public bool IsSateHoliday(DateTime date, out string name)
    {
        name = null;
        return false;
    }
}
