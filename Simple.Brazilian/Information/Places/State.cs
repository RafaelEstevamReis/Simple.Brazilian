using System;

namespace Simple.Brazilian.Information.Places
{
    public sealed class State
    {
        private State() { }

        public string Name { get; set; }
        public string UF { get; set; }
        public int IdIBGE { get; set; }
        public string Capital { get; set; }
        public double AreaKm2 { get; set; }


        internal static State FromIndex(int index)
        {
            return new State()
            {
                Name = States.Names[index],
                UF = States.UF[index],
                IdIBGE = States.IdIBGE[index],
                Capital = States.Capital[index],
                AreaKm2 = States.AreaKm2[index],
            };
        }
    }
}
