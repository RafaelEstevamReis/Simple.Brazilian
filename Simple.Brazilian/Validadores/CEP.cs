using System;

namespace Simple.Brazilian.Validadores
{
    public static class CEP
    {
        public static bool IsValid(string cep, Dados.Locais.UF uf)
        {
            throw new NotImplementedException();
        }
        public static string Mask(string cep)
        {
            throw new NotImplementedException();
        }
        public static string Unmask(string cep)
        {
            return Formatadores.Texto.RemoveMascara(cep);
        }
    }
}
