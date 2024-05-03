namespace Simple.Brazilian.Information.Places.StateSpecific;

using System;

public class AM : IStateData
{
    public UFs UF => UFs.AM;

    public bool IsSateHoliday(DateTime date, out string name)
    {
        if (date.Month == 9)
        {
            if (date.Day == 5)
            {
                name = "Eleva��o do Amazonas � categoria de prov�ncia";
                return true;
            }
        }
        if (date.Month == 11)
        {
            if (date.Day == 20)
            {
                name = "Dia da Consci�ncia Negra";
                return true;
            }
        }
        if (date.Month == 12)
        {
            if (date.Day == 8)
            {
                name = "Dia de Nossa Senhora da Concei��o";
                return true;
            }
        }

        name = null;
        return false;
    }
}
