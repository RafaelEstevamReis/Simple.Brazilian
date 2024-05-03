namespace Simple.Brazilian.Information.Places.StateSpecific;

using System;

public class MS : IStateData
{
    public UFs UF => UFs.MS;

    public bool IsSateHoliday(DateTime date, out string name)
    {
        if (date.Month == 10)
        {
            if (date.Day == 11)
            {
                name = "Criação do Estado do Mato Grosso do Sul";
                return true;
            }
        }

        name = null;
        return false;
    }
}
