using System;

namespace Simple.Brazilian.Validadores
{
    public static  class RG
    {
        public static bool IsValid(string rg)
        {
            throw new NotImplementedException();
        }
        public static string Mask(string rg)
        {
            throw new NotImplementedException();
        }
        public static string Unmask(string rg)
        {
            return Formatadores.Texto.RemoveMascara(rg);
        }
    }
}
