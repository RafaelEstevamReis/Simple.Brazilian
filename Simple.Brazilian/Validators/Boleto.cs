using System;
using System.Linq;

namespace Simple.Brazilian.Validators
{
    public static class Boleto
    {
        /// <summary>
        /// Executa cálculo do Mod10 no texto, retorna INT
        /// </summary>
        public static int Mod10(string str)
        {
            int mult = 2;
            int sum = 0;

            for (int i = (str.Length - 1); i >= 0; i--)
            {
                char c = str[i];

                int res = Convert.ToInt32(c.ToString()) * mult;
                sum += res > 9 ? (res - 9) : res;
                mult = mult == 2 ? 1 : 2;
            }

            int DigitoVerificador = 10 - (sum % 10);
            if (DigitoVerificador == 10) DigitoVerificador = 0;

            return DigitoVerificador;
        }
        /// <summary>
        /// Executa cálculo do Mod11
        /// </summary>
        public static int Mod11(string campo1, string campo2, string campo3)
        {
            int mult = 2;
            int sum = 0;

            for (int i = 9; i >= 0; i--)
            {
                char c = campo1[i];
                int res = Convert.ToInt32(c.ToString()) * mult;
                sum += res;
                mult++;
                if (mult > 9) mult = 2;
            }
            mult = 2;
            for (int i = 10; i >= 0; i--)
            {
                char c = campo2[i];
                int res = Convert.ToInt32(c.ToString()) * mult;
                sum += res;
                mult++;
                if (mult > 9) mult = 2;
            }
            mult = 2;
            for (int i = 10; i >= 0; i--)
            {
                char c = campo3[i];
                int res = Convert.ToInt32(c.ToString()) * mult;
                sum += res;
                mult++;
                if (mult > 9) mult = 2;
            }

            int mod11 = sum % 11;

            if (mod11 == 0 || mod11 == 10 || mod11 == 11)
            {
                return 1;
            }

            return mod11;
        }
        /// <summary>
        /// Executa o cálculo do Fator de Vencimento no formato "dd/mm/yyyy"
        /// </summary>
        /// <param name="dataVencimentoRaw"></param>
        /// <returns>int fatorVencimento</returns>
        public static int FatorVencimento(string dataVencimentoRaw)
        {
            // Uma int array recebe os valores da data sem as barras '/'
            var dataUnmask = dataVencimentoRaw.Split('/')
                                          .Select(Int32.Parse)
                                          .ToArray();

            // Data de refêrencia imutável
            var dataInicial = new DateTime(1997, 10, 07);

            // Recebe as datas nas seguintes ordens:
            // Ano posição 2, Mês posição 1, Dia posição 0
            var dataVencimento = new DateTime(dataUnmask[2],
                                              dataUnmask[1], 
                                              dataUnmask[0]);

            // O fator de vencimento é o total de dias entre
            // a data inicial e a data de vencimento
            var fatorVencimento = (dataVencimento - dataInicial).Days;

            return fatorVencimento;
        }
        /// <summary>
        /// Executa cálculo do Mod10 no texto, retorna []INT
        /// </summary>
        //public static int[] CalculateMod10_old(string LinhaDigitavelBoleto)
        //{
        //    int[] camposDV = new int[3];
        //    int soma = 0;

        //    for (int i = 0; i < 29; i++)
        //    {
        //        int digito = Convert.ToInt32(LinhaDigitavelBoleto[i..(i + 1)]);
        //        int peso = i % 2 == 0 ? 2 : 1;

        //        int valor = digito * peso;

        //        if (valor < 10)
        //        {
        //            soma += valor;
        //        }
        //        else
        //        {
        //            int d1 = valor % 10;
        //            int d2 = valor / 10;

        //            soma += d1;
        //            soma += d2;
        //        }

        //        if (i == 8) camposDV[0] = 30 - (soma % 10);
        //        if (i == 18) camposDV[1] = 40 - ((soma - camposDV[0]) % 10);
        //        if (i == 28) camposDV[2] = 40 - ((soma - (camposDV[0] + camposDV[1])) % 10);
        //    }
        //    return camposDV;
        //}
    }
}
