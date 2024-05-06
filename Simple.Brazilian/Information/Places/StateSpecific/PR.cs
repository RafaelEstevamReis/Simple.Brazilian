namespace Simple.Brazilian.Information.Places.StateSpecific;

using System;
using Simple.Brazilian.Information.Places;

public class PR : IStateData
{
    public UFs UF => UFs.PR;

    public bool IsSateHoliday(DateTime date, out string name)
    {
        // Não tem

        name = null;
        return false;
    }
}
