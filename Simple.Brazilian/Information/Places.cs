using System.ComponentModel;

#if NETSTANDARD1_0
//using Simple.Brazilian.Compatibilidade;
#endif

namespace Simple.Brazilian.Information
{
    /// <summary>
    /// Dados de localidades
    /// </summary>
    public static class Places
    {
        /// <summary>
        /// Unidades federativas
        /// </summary>
        public enum UF
        {
            /// <summary>
            /// Rondônia
            /// </summary>
            [Description("Rondônia")]
            RO = 11,
            /// <summary>
            /// Acre
            /// </summary>
            [Description("Acre")]
            AC = 12,
            /// <summary>
            /// Amazonas
            /// </summary>
            [Description("Amazonas")]
            AM = 13,
            /// <summary>
            /// Roraima
            /// </summary>
            [Description("Roraima")]
            RR = 14,
            /// <summary>
            /// Pará
            /// </summary>
            [Description("Pará")]
            PA = 15,
            /// <summary>
            /// Amapá
            /// </summary>
            [Description("Amapá")]
            AP = 16,
            /// <summary>
            /// Tocantins
            /// </summary>
            [Description("Tocantins")]
            TO = 17,
            /// <summary>
            /// Maranhão
            /// </summary>
            [Description("Maranhão")]
            MA = 21,
            /// <summary>
            /// Piauí
            /// </summary>
            [Description("Piauí")]
            PI = 22,
            /// <summary>
            /// Ceará
            /// </summary>
            [Description("Ceará")]
            CE = 23,
            /// <summary>
            /// Rio Grande do Norte
            /// </summary>
            [Description("Rio Grande do Norte")]
            RN = 24,
            /// <summary>
            /// Paraíba
            /// </summary>
            [Description("Paraíba")]
            PB = 25,
            /// <summary>
            /// Pernambuco
            /// </summary>
            [Description("Pernambuco")]
            PE = 26,
            /// <summary>
            /// Alagoas
            /// </summary>
            [Description("Alagoas")]
            AL = 27,
            /// <summary>
            /// Sergipe
            /// </summary>
            [Description("Sergipe")]
            SE = 28,
            /// <summary>
            /// Bahia
            /// </summary>
            [Description("Bahia")]
            BA = 29,
            /// <summary>
            /// Minas Gerais
            /// </summary>
            [Description("Minas Gerais")]
            MG = 31,
            /// <summary>
            /// Espírito Santo
            /// </summary>
            [Description("Espírito Santo")]
            ES = 32,
            /// <summary>
            /// Rio de Janeiro
            /// </summary>
            [Description("Rio de Janeiro")]
            RJ = 33,
            /// <summary>
            /// São Paulo
            /// </summary>
            [Description("São Paulo")]
            SP = 35,
            /// <summary>
            /// Paraná
            /// </summary>
            [Description("Paraná")]
            PR = 41,
            /// <summary>
            /// Santa Catarina
            /// </summary>
            [Description("Santa Catarina")]
            SC = 42,
            /// <summary>
            /// Rio Grande do Sul
            /// </summary>
            [Description("Rio Grande do Sul")]
            RS = 43,
            /// <summary>
            /// Mato Grosso do Sul
            /// </summary>
            [Description("Mato Grosso do Sul")]
            MS = 50,
            /// <summary>
            /// Mato Grosso
            /// </summary>
            [Description("Mato Grosso")]
            MT = 51,
            /// <summary>
            /// Goiás
            /// </summary>
            [Description("Goiás")]
            GO = 52,
            /// <summary>
            /// Distrito Federal
            /// </summary>
            [Description("Distrito Federal")]
            DF = 53,
            /// <summary>
            /// Exterior
            /// </summary>
            [Description("Exterior")]
            EX = 99,
        }

    }
}
