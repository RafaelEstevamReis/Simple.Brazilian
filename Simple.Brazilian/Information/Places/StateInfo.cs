namespace Simple.Brazilian.Information.Places
{
    public sealed class StateInfo
    {
        private StateInfo() { }

        public string Name { get; set; }
        public string UF { get; set; }
        public int IdIBGE { get; set; }
        public string Capital { get; set; }
        public double AreaKm2 { get; set; }

        private byte[] bandeiraPng;
        public byte[] BandeiraPNG() => bandeiraPng;

        private byte[] bandeiraSvg;
        public byte[] BandeiraSVG() => bandeiraSvg;

        internal static StateInfo FromIndex(int index)
        {
            return new StateInfo()
            {
                Name = States.Names[index],
                UF = States.UF[index],
                IdIBGE = States.IdIBGE[index],
                Capital = States.Capital[index],
                AreaKm2 = States.AreaKm2[index],
                bandeiraPng = bandeiraPngFromIndex(index),
                bandeiraSvg = bandeiraSvgFromIndex(index),
            };
        }

        private static byte[] bandeiraSvgFromIndex(int index)
        {
            switch (index)
            {
                case 0: return BandeirasSVG.Acre;
                case 1: return BandeirasSVG.Alagoas;
                case 2: return BandeirasSVG.Amapa;
                case 3: return BandeirasSVG.Amazonas;
                case 4: return BandeirasSVG.Bahia;
                case 5: return BandeirasSVG.Ceara;
                case 6: return BandeirasSVG.Distrito_Federal;
                case 7: return BandeirasSVG.Espirito_Santo;
                case 8: return BandeirasSVG.Goias;
                case 9: return BandeirasSVG.Maranhao;
                case 10: return BandeirasSVG.Mato_Grosso;
                case 11: return BandeirasSVG.Mato_Grosso_do_Sul;
                case 12: return BandeirasSVG.Minas_Gerais;
                case 13: return BandeirasSVG.Para;
                case 14: return BandeirasSVG.Paraiba;
                case 15: return BandeirasSVG.Parana;
                case 16: return BandeirasSVG.Pernambuco;
                case 17: return BandeirasSVG.Piaui;
                case 18: return BandeirasSVG.Rio_de_Janeiro;
                case 19: return BandeirasSVG.Rio_Grande_do_Norte;
                case 20: return BandeirasSVG.Rio_Grande_do_Sul;
                case 21: return BandeirasSVG.Rondonia;
                case 22: return BandeirasSVG.Roraima;
                case 23: return BandeirasSVG.Santa_Catarina;
                case 24: return BandeirasSVG.Sao_Paulo;
                case 25: return BandeirasSVG.Sergipe;
                case 26: return BandeirasSVG.Tocantins;
                default: return null;
            }
        }
        private static byte[] bandeiraPngFromIndex(int index)
        {
            switch (index)
            {
                case 0: return  BandeirasPNG._45px_Acre;
                case 1: return  BandeirasPNG._45px_Alagoas;
                case 2: return  BandeirasPNG._45px_Amapa;
                case 3: return  BandeirasPNG._45px_Amazonas;
                case 4: return  BandeirasPNG._45px_Bahia;
                case 5: return  BandeirasPNG._45px_Ceara;
                case 6: return  BandeirasPNG._45px_Distrito_Federal;
                case 7: return  BandeirasPNG._45px_Espirito_Santo;
                case 8: return  BandeirasPNG._45px_Goias;
                case 9: return  BandeirasPNG._45px_Maranhao;
                case 10: return BandeirasPNG._45px_Mato_Grosso;
                case 11: return BandeirasPNG._45px_Mato_Grosso_do_Sul;
                case 12: return BandeirasPNG._45px_Minas_Gerais;
                case 13: return BandeirasPNG._45px_Para;
                case 14: return BandeirasPNG._45px_Paraiba;
                case 15: return BandeirasPNG._45px_Parana;
                case 16: return BandeirasPNG._45px_Pernambuco;
                case 17: return BandeirasPNG._45px_Piaui;
                case 18: return BandeirasPNG._45px_Rio_de_Janeiro;
                case 19: return BandeirasPNG._45px_Rio_Grande_do_Norte;
                case 20: return BandeirasPNG._45px_Rio_Grande_do_Sul;
                case 21: return BandeirasPNG._45px_Rondonia;
                case 22: return BandeirasPNG._45px_Roraima;
                case 23: return BandeirasPNG._45px_Santa_Catarina;
                case 24: return BandeirasPNG._45px_Sao_Paulo;
                case 25: return BandeirasPNG._45px_Sergipe;
                case 26: return BandeirasPNG._45px_Tocantins;
                default: return null;
            }
        }
    }
}
