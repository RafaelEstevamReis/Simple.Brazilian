namespace Simple.Brazilian.Information.Places.StateSpecific;

using System;
using Simple.Brazilian.Information.Places;

public class GO : IStateData
{
    public UFs UF => UFs.GO;

    public bool IsSateHoliday(DateTime date, out string name)
    {
        // Não tem

        name = null;
        return false;
    }
}
