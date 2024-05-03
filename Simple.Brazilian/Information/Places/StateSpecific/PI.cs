namespace Simple.Brazilian.Information.Places.StateSpecific;

using System;

public class PI : IStateData
{
    public UFs UF => UFs.PI;

    public bool IsSateHoliday(DateTime date, out string name)
    {
        if (date.Month == 3)
        {
            if (date.Day == 13)
            {
                name = "Dia da Batalha do Jenipapo";
                return true;
            }
        }
        if (date.Month == 10)
        {
            if (date.Day == 19)
            {
                name = "Dia do Piauí";
                return true;
            }
        }

        name = null;
        return false;
    }
}
