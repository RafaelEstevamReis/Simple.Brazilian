using System;

namespace Simple.Brazilian.Validadores
{
    public static class PIS
    {
        public static bool IsValid(string pis)
        {
            throw new NotImplementedException();
        }

        public static string Mask(string pis) => Formatadores.Texto.AplicaMascara(pis, "___._____.__._");
        public static string Unmask(string pis) => Formatadores.Texto.RemoveMascara(pis);

    }
}
