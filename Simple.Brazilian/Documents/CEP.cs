using System;

namespace Simple.Brazilian.Documents
{
    /// <summary>
    /// Validador de CEP
    /// </summary>
    public static class CEP
    {
        /// <summary>
        /// Verifica se o CEP tem o comprimento correto
        /// </summary>
        /// <param name="cep">CEP a ser verificado</param>
        /// <returns>True se o CEP tem o comprimento correto; False senão</returns>
        public static bool IsValid(string cep)
        {
            if (cep == null) return false;

            return Unmask(cep).Length == 8;
        }
       
        /// <summary>
        /// Verifica se o CEP tem o comprimento correto e se corresponde ao UF designado
        /// </summary>
        /// <param name="cep">CEP a ser verificado</param>
        /// <param name="uf">UF a ser comparado</param>
        /// <returns>True se o CEP tem o comprimento correto; False senão</returns>
        public static bool IsValid(string cep, Information.Places.UFs uf)
        {
            // Executa teste base
            if (!IsValid(cep)) return false;

            // Checa a Região
            // É possível checar faixa de CEP por Sub-Região, 
            //  não teria repetição de UF na região
            // A tabela completa pode ser obtida em:
            // https://pt.wikipedia.org/wiki/C%C3%B3digo_de_Endere%C3%A7amento_Postal#Estrutura_do_CEP
            switch (cep[0])
            {
                case '0':
                case '1':
                    return uf == Information.Places.UFs.SP;

                case '2':
                    if (uf == Information.Places.UFs.RJ) return true;
                    if (uf == Information.Places.UFs.ES) return true;
                    return false;

                case '3':
                    return uf == Information.Places.UFs.MG;

                case '4':
                    if (uf == Information.Places.UFs.BA) return true;
                    if (uf == Information.Places.UFs.SE) return true;
                    return false;

                case '5':
                    if (uf == Information.Places.UFs.PE) return true;
                    if (uf == Information.Places.UFs.AL) return true;
                    if (uf == Information.Places.UFs.PB) return true;
                    if (uf == Information.Places.UFs.RN) return true;
                    return false;

                case '6':
                    if (uf == Information.Places.UFs.CE) return true;
                    if (uf == Information.Places.UFs.PI) return true;
                    if (uf == Information.Places.UFs.MA) return true;
                    if (uf == Information.Places.UFs.PA) return true;
                    if (uf == Information.Places.UFs.AP) return true;
                    if (uf == Information.Places.UFs.AM) return true;
                    if (uf == Information.Places.UFs.RR) return true;
                    if (uf == Information.Places.UFs.AC) return true;
                    return false;

                case '7':
                    if (uf == Information.Places.UFs.DF) return true;
                    if (uf == Information.Places.UFs.GO) return true;
                    if (uf == Information.Places.UFs.TO) return true;
                    if (uf == Information.Places.UFs.MT) return true;
                    if (uf == Information.Places.UFs.RO) return true;
                    if (uf == Information.Places.UFs.MS) return true;
                    return false;

                case '8':
                    if (uf == Information.Places.UFs.PR) return true;
                    if (uf == Information.Places.UFs.SC) return true;
                    return false;

                case '9':
                    return uf == Information.Places.UFs.RS;
            }
            throw new Exception("Nao é possível comparar o CEP informado com a UF informada");
        }
      
        /// <summary>
        /// Aplica a máscara de CEP __.___-___
        /// </summary>
        /// <param name="cep">Texto para aplicar a máscara</param>
        /// <returns>Texto com a máscara</returns>
        public static string Mask(string cep) => Formatters.Text.ApplyMask(cep, "__.___-___");
     
        /// <summary>
        /// Remove a máscara
        /// </summary>
        /// <param name="cep">Texto com a máscara aplicada</param>
        /// <returns>Texto com a máscara removida</returns>
        public static string Unmask(string cep) => Formatters.Text.RemoveMask(cep);

    }
}
