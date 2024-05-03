namespace Simple.Brazilian.Information.Places.StateSpecific;

using System;

public class AL : IStateData
{
    public UFs UF => UFs.AL;

    public bool IsSateHoliday(DateTime date, out string name)
    {
        if (date.Month == 6)
        {
            if (date.Day == 24)
            {
                name = "Dia de S�o Jo�o";
                return true;
            }
        }
        if (date.Month == 6)
        {
            if (date.Day == 29)
            {
                name = "Dia de S�o Pedro";
                return true;
            }
        }
        if (date.Month == 9)
        {
            if (date.Day == 16)
            {
                name = "Emancipa��o Pol�tica de Alagoas";
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

        name = null;
        return false;
    }
}
