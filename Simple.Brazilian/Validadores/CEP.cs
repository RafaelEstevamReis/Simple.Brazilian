using System;

namespace Simple.Brazilian.Validadores
{
    public static class CEP
    {
        public static bool IsValid(string cep, Dados.Locais.UF uf)
        {
            throw new NotImplementedException();
        }

        public static string Mask(string cep) => Formatadores.Texto.AplicaMascara(cep, "__.___-___");
        public static string Unmask(string cep) => Formatadores.Texto.RemoveMascara(cep);

    }
}
