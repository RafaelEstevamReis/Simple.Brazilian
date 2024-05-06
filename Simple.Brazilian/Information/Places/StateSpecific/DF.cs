namespace Simple.Brazilian.Information.Places.StateSpecific;

using System;
using Simple.Brazilian.Information.Places;

public class DF : IStateData
{
    public UFs UF => UFs.DF;

    public bool IsSateHoliday(DateTime date, out string name)
    {
        // Corpus Christi (data m�vel)

        if (date.Month == 4)
        {
            if (date.Day == 21)
            {
                name = "Funda��o de Bras�lia";
                return true;
            }
        }
        if (date.Month == 11)
        {
            if (date.Day == 30)
            {
                name = "Dia do Evang�lico";
                return true;
            }
        }

        name = null;
        return false;
    }
}
