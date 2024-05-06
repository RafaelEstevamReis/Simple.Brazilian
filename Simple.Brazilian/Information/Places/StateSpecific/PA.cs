namespace Simple.Brazilian.Information.Places.StateSpecific;

using System;
using Simple.Brazilian.Information.Places;

public class PA : IStateData
{
    public UFs UF => UFs.PA;

    public bool IsSateHoliday(DateTime date, out string name)
    {
        if (date.Month == 8)
        {
            if (date.Day == 15)
            {
                name = "Ades�o do Gr�o-Par� � independ�ncia do Brasil";
                return true;
            }
        }

        name = null;
        return false;
    }
}
