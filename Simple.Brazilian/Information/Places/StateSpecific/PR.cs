namespace Simple.Brazilian.Information.Places.StateSpecific;

using System;

public class PR : IStateData
{
    public UFs UF => UFs.PR;

    public bool IsSateHoliday(DateTime date, out string name)
    {
        // N�o tem

        name = null;
        return false;
    }
}