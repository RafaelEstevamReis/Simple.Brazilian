namespace Simple.Brazilian.Information.Places.StateSpecific;

using System;

public class SP : IStateData
{
    public UFs UF => UFs.SP;

    public bool IsSateHoliday(DateTime date, out string name)
    {
        if(date.Month == 7)
        {
            if(date.Day == 9)
            {
                name = "Revolução Constitucionalista de 1932";
                return true;
            }
        }

        name = null;
        return false;
    }
}
