namespace Simple.Brazilian.Information.Places.StateSpecific;

using System;

public class SC : IStateData
{
    public UFs UF => UFs.SC;

    public bool IsSateHoliday(DateTime date, out string name)
    {
        name = null;
        return false;
    }
}
