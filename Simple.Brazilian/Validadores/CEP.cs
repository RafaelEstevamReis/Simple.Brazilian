using System;

namespace Simple.Brazilian.Validadores
{
    public static class CEP
    {
        /// <summary>
        /// Verifica se o CEP tem ocomprimento correto
        /// </summary>
        /// <param name="cep">CEP a ser verificado</param>
        /// <returns>True se o CEP tem o comprimento correto; False senão</returns>
        public static bool IsValid(string cep)
        {
            if (cep == null) return false;

            return Unmask(cep).Length == 8;
        }

        /// <summary>
        /// Verifica se o CEP tem ocomprimento correto e se corresponde ao UF designado
        /// </summary>
        /// <param name="cep">CEP a ser verificado</param>
        /// <param name="uf">UF a ser comparado</param>
        /// <returns>True se o CEP tem o comprimento correto; False senão</returns>
        public static bool IsValid(string cep, Dados.Locais.UF uf)
        {
            // Executa teste base
            if (!IsValid(cep)) return false;

            // Checa o UF
            switch (cep[0])
            {
                case '0':
                case '1':
                    return uf == Dados.Locais.UF.SP;

                case '2':
                    if (uf == Dados.Locais.UF.RJ) return true;
                    if (uf == Dados.Locais.UF.ES) return true;
                    return false;

                case '3':
                    return uf == Dados.Locais.UF.MG;

                case '4':
                    if (uf == Dados.Locais.UF.BA) return true;
                    if (uf == Dados.Locais.UF.SE) return true;
                    return false;

                case '5':
                    if (uf == Dados.Locais.UF.PE) return true;
                    if (uf == Dados.Locais.UF.AL) return true;
                    if (uf == Dados.Locais.UF.PB) return true;
                    if (uf == Dados.Locais.UF.RN) return true;
                    return false;

                case '6':
                    if (uf == Dados.Locais.UF.CE) return true;
                    if (uf == Dados.Locais.UF.PI) return true;
                    if (uf == Dados.Locais.UF.MA) return true;
                    if (uf == Dados.Locais.UF.PA) return true;
                    if (uf == Dados.Locais.UF.AP) return true;
                    if (uf == Dados.Locais.UF.AM) return true;
                    if (uf == Dados.Locais.UF.RR) return true;
                    if (uf == Dados.Locais.UF.AC) return true;
                    return false;

                case '7':
                    if (uf == Dados.Locais.UF.DF) return true;
                    if (uf == Dados.Locais.UF.GO) return true;
                    if (uf == Dados.Locais.UF.TO) return true;
                    if (uf == Dados.Locais.UF.MT) return true;
                    if (uf == Dados.Locais.UF.RO) return true;
                    if (uf == Dados.Locais.UF.MS) return true;
                    return false;

                case '8':
                    if (uf == Dados.Locais.UF.PR) return true;
                    if (uf == Dados.Locais.UF.SC) return true;
                    return false;

                case '9':
                    return uf == Dados.Locais.UF.RS;
            }
            throw new Exception("Nao é possível comparar o CEP informado com a UF informada");
        }

        public static string Mask(string cep) => Formatadores.Texto.AplicaMascara(cep, "__.___-___");
        public static string Unmask(string cep) => Formatadores.Texto.RemoveMascara(cep);

    }
}
