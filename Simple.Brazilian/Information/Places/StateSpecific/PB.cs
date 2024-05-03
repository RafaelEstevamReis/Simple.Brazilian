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
                name = "Fundação do Estado da Paraíba";
                return true;
            }
        }

        name = null;
        return false;
    }
}
