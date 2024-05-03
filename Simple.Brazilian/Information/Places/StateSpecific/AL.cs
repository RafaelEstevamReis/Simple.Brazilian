namespace Simple.Brazilian.Information.Places.StateSpecific;

using System;

public class AL : IStateData
{
    public UFs UF => UFs.AL;

    public bool IsSateHoliday(DateTime date, out string name)
    {
        name = null;
        return false;
    }
}
