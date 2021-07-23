using System;

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

        public static int FatorVencimento(string dataVencimentoRaw)
        {
            int ano = Convert.ToInt32(dataVencimentoRaw.Substring(0, 4));
            int mes = Convert.ToInt32(dataVencimentoRaw.Substring(4, 2));
            int dia = Convert.ToInt32(dataVencimentoRaw.Substring(6, 2));

            // Calcula o fator de vencimento
            var dataInicial = new DateTime(1997, 10, 07); // Imutável
            var dataVencimento = new DateTime(ano, mes, dia);

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
