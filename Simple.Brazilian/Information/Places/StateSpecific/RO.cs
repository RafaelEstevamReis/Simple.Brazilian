namespace Simple.Brazilian.Information.Places.StateSpecific;

using System;
using Simple.Brazilian.Information.Places;

public class RO : IStateData
{
    public UFs UF => UFs.RO;

    public bool IsSateHoliday(DateTime date, out string name)
    {
        if (date.Month == 1)
        {
            if (date.Day == 4)
            {
                name = "Cria��o do Estado de Rond�nia";
                return true;
            }
        }
        if (date.Month == 6)
        {
            if (date.Day == 18)
            {
                name = "Dia do Evang�lico";
                return true;
            }
        }

        name = null;
        return false;
    }
}
