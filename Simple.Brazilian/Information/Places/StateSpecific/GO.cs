namespace Simple.Brazilian.Information.Places.StateSpecific;

using System;

public class GO : IStateData
{
    public UFs UF => UFs.GO;

    public bool IsSateHoliday(DateTime date, out string name)
    {
        // N�o tem

        name = null;
        return false;
    }
}