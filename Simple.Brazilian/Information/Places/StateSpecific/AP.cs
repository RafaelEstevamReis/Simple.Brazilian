namespace Simple.Brazilian.Information.Places.StateSpecific;

using System;

public class AP : IStateData
{
    public UFs UF => UFs.AP;

    public bool IsSateHoliday(DateTime date, out string name)
    {
        name = null;
        return false;
    }
}
