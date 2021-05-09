using System;

namespace Simple.Brazilian.Validadores
{
    public static class CPF
    {
        public static bool IsValid(string cpf)
        {
            throw new NotImplementedException();
        }
        public static string Mask(string cpf)
        {
            throw new NotImplementedException();
        }
        public static string Unmask(string cpf)
        {
            return Formatadores.Texto.RemoveMascara(cpf);
        }
    }
}
