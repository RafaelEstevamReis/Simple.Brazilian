namespace Simple.Brazilian.Information.Places.StateSpecific;

using System;

public class RS : IStateData
{
    public UFs UF => UFs.RS;

    public bool IsSateHoliday(DateTime date, out string name)
    {
        if (date.Month == 9)
        {
            if (date.Day == 20)
            {
                name = "Revolu��o Farroupilha (Dia do Ga�cho)";
                return true;
            }
        }

        name = null;
        return false;
    }
}
