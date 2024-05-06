namespace Simple.Brazilian.Information;

using Simple.Brazilian.Information.Places;
using System;

public interface IStateData
{
    public UFs UF { get; }

    public bool IsSateHoliday(DateTime date, out string name);
}