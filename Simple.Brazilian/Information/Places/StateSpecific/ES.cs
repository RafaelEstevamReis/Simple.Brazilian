namespace Simple.Brazilian.Information.Places.StateSpecific;

using System;

public class ES : IStateData
{
    public UFs UF => UFs.ES;

    public bool IsSateHoliday(DateTime date, out string name)
    {
        // 2.ª feira, 8 dias depois do Domingo de Páscoa: Dia de Nossa Senhora da Penha(Data Magna do Estado)


        name = null;
        return false;
    }
}
