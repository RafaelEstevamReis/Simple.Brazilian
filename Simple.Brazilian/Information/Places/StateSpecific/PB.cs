namespace Simple.Brazilian.Information.Places.StateSpecific;

using System;

public class PB : IStateData
{
    public UFs UF => UFs.PB;

    public bool IsSateHoliday(DateTime date, out string name)
    {
        if (date.Month == 8)
        {
            if (date.Day == 5)
            {
                name = "Funda��o do Estado da Para�ba";
                return true;
            }
        }

        name = null;
        return false;
    }
}
