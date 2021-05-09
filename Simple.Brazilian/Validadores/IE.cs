using System;

namespace Simple.Brazilian.Validadores
{
    public static class IE
    {
        public static bool IsValid(string cep)
        {
            throw new NotImplementedException();
        }
        public static string Mask(string cep)
        {
            throw new NotImplementedException();
        }
        public static string Unmask(string cep) => Formatadores.Texto.RemoveMascara(cep);

    }
}
